import SimpleITK as sitk
import csv
import matplotlib.pyplot as plt
import torch
import os
import PIL
from torchvision import transforms
import h5py

case_number = f"{1:03}" # Three digits number
slice_number = 0 # Iterate through the slices
# File path TBD
file_path = f'kidney-ct-abnormality/imagesTr/kidneyabnormalityKiTS-0{case_number}_0000.mha'
image = sitk.ReadImage(file_path)
image_array = sitk.GetArrayFromImage(image)
slice = image_array[:, slice_number, :]

# Narrawing the feasible length and width by iterating the value below manually after the first run
# # Col
# slice[:, :117] = 0
# slice[:, 161:] = 0
# # Row
# slice[:60, :] = 0
# slice[80:, :] = 0

csv_file_path = f'./Label/0{case_number}/tensor_{slice_number}.csv'
with open(csv_file_path, 'w', newline='') as file:
    writer = csv.writer(file)
    writer.writerows(slice)

print(f'Data saved to {csv_file_path}')

# Visualize the image array
plt.imshow(slice, cmap='gray')
plt.axis('off')
plt.show()