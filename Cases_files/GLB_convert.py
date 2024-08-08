import torch
import csv

import trimesh
import json
import struct
import numpy as np
from skimage import measure

case_number = f"{0:03}" # Three digits number
slice_number = [15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84]

# Segmentation Mask Preprocessing
print('Loading segmentation mask data...')
seg = torch.zeros((len(slice_number), 124, 300), dtype=torch.float32)
for i in slice_number:
    # Path to your CSV file
    csv_file_path = f'Label/0{case_number}/tensor_{i}.csv'
    data = []

    # Open and read the CSV file
    with open(csv_file_path, 'r') as file:
        reader = csv.reader(file)
        for j, row in enumerate(reader):
            if j <= 123:
                # Convert each string to float, replace empty strings with 0.0
                float_row = [float(value) if value != '' else 0.0 for value in row]
                data.append(float_row)
            else:
                break

    print(f'Loaded data from {csv_file_path}')
    # Convert the list of lists into a tensor
    tensor_data = torch.tensor(data, dtype=torch.float32)
    # print(tensor_data.shape)

    seg[i-15] = tensor_data

print(f'Loaded {len(seg)} slices')
print('Slice shape:', seg[0].shape)
print(seg.shape)

# tensor = seg.numpy()

# for value in np.unique(tensor):
#     if value == 0:
#         continue  # Skip empty space
#     # Create a binary mask for the current class
#     mask = (tensor == value).astype(np.uint8)
#     print(mask.shape)
#     print(np.unique(mask))
#     print(value)
#     mesh = trimesh.voxel.ops.multibox(mask, pitch=1.0)

# def tensor_to_meshes(tensor):
#     meshes = []
#     for value in np.unique(tensor):
#         if value == 0:
#             continue  # Skip empty space
#         # Create a binary mask for the current class
#         mask = (tensor == value).astype(np.uint8)
#         # Convert the mask to a mesh
#         mesh = trimesh.voxel.ops.multibox(mask, pitch=1.0)
#         meshes.append((mesh, value))
#     return meshes

def tensor_to_meshes(tensor):
    meshes = []
    for value in np.unique(tensor):
        if value == 0:
            continue  # Skip empty space
        # Create a binary mask for the current class
        mask = (tensor == value).astype(np.uint8)
        # Use marching cubes to get vertices and faces for the mesh
        verts, faces, _, _ = measure.marching_cubes(mask, level=0)
        # Create the mesh
        mesh = trimesh.Trimesh(vertices=verts, faces=faces)
        meshes.append((mesh, value))
    return meshes

def create_glb(meshes):
    gltf = {
        "asset": {"version": "2.0"},
        "buffers": [{"byteLength": 0}],
        "bufferViews": [],
        "accessors": [],
        "meshes": [],
        "materials": [],
        "nodes": [],
        "scenes": [{"nodes": []}],
        "scene": 0
    }
    
    buffer_data = b''
    
    for i, (mesh, class_id) in enumerate(meshes):
        print(f"Processing class {class_id}")
        vertices = mesh.vertices.astype(np.float32).tobytes()
        faces = mesh.faces.astype(np.uint32).tobytes()
        
        vertex_view = {
            "buffer": 0,
            "byteOffset": len(buffer_data),
            "byteLength": len(vertices),
            "target": 34962  # ARRAY_BUFFER
        }
        buffer_data += vertices
        
        index_view = {
            "buffer": 0,
            "byteOffset": len(buffer_data),
            "byteLength": len(faces),
            "target": 34963  # ELEMENT_ARRAY_BUFFER
        }
        buffer_data += faces
        
        gltf["bufferViews"].append(vertex_view)
        gltf["bufferViews"].append(index_view)
        
        vertex_accessor = {
            "bufferView": len(gltf["bufferViews"]) - 2,
            "byteOffset": 0,
            "componentType": 5126,  # FLOAT
            "count": len(mesh.vertices),
            "type": "VEC3",
            "max": mesh.vertices.max(axis=0).tolist(),
            "min": mesh.vertices.min(axis=0).tolist()
        }
        
        index_accessor = {
            "bufferView": len(gltf["bufferViews"]) - 1,
            "byteOffset": 0,
            "componentType": 5125,  # UNSIGNED_INT
            "count": len(mesh.faces) * 3,
            "type": "SCALAR"
        }
        
        gltf["accessors"].append(vertex_accessor)
        gltf["accessors"].append(index_accessor)
        
        primitive = {
            "attributes": {"POSITION": len(gltf["accessors"]) - 2},
            "indices": len(gltf["accessors"]) - 1,
            "material": i  # Material index corresponding to class_id
        }
        
        gltf["meshes"].append({"primitives": [primitive]})
        
        if class_id == -100:
            gltf["materials"].append({
                "pbrMetallicRoughness": {
                    "baseColorFactor": [255 / 255.0, 182 / 255.0, 193 / 255.0, 1.0],
                    "metallicFactor": 0.0,
                    "roughnessFactor": 1.0
                }
            })
        elif class_id == 100:
            gltf["materials"].append({
                "pbrMetallicRoughness": {
                    "baseColorFactor": [153 / 255.0, 51 / 255.0, 51 / 255.0, 1.0],
                    "metallicFactor": 0.0,
                    "roughnessFactor": 1.0
                }
            })
        else:
            gltf["materials"].append({
                "pbrMetallicRoughness": {
                    "baseColorFactor": [204 / 255.0, 102 / 255.0, 102 / 255.0, 1.0],
                    "metallicFactor": 0.0,
                    "roughnessFactor": 1.0
                }
            })
        
        gltf["nodes"].append({"mesh": i})
        gltf["scenes"][0]["nodes"].append(i)
    
    gltf["buffers"][0]["byteLength"] = len(buffer_data)
    gltf_json = json.dumps(gltf).encode('utf-8')
    
    # Align to 4-byte boundary
    def align_to_4_bytes(data):
        padding = (4 - (len(data) % 4)) % 4
        return data + b' ' * padding
    
    gltf_json_aligned = align_to_4_bytes(gltf_json)
    binary_data = align_to_4_bytes(buffer_data)
    
    # GLB Header (12 bytes)
    glb_header = struct.pack('<III', 0x46546C67, 2, 12 + 8 + len(gltf_json_aligned) + 8 + len(binary_data))
    
    # JSON Chunk Header (8 bytes)
    json_chunk_header = struct.pack('<II', len(gltf_json_aligned), 0x4E4F534A)
    
    # Binary Chunk Header (8 bytes)
    binary_chunk_header = struct.pack('<II', len(binary_data), 0x004E4942)
    
    # Combine all parts to form GLB
    glb_data = glb_header + json_chunk_header + gltf_json_aligned + binary_chunk_header + binary_data
    
    return glb_data

# Convert PyTorch tensor to NumPy array
tensor = seg.numpy()

# Convert tensor to meshes
meshes = tensor_to_meshes(tensor)

# Create GLB file data
glb_data = create_glb(meshes)

# Write GLB data to a file
with open("viz/kidney_test.glb", "wb") as f:
    f.write(glb_data)

print("GLB file has been created: kidney_test.glb")