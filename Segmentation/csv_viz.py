import csv
import torch
import matplotlib.pyplot as plt

case_number = f"{1:03}" # Three digits number
slice_number = 0 # Iterate through the slices

# Path to your CSV file
csv_file_path = f'./Label/0{case_number}/tensor_{slice_number}.csv'

# Initialize an empty list to store the rows from the CSV file
data = []

# Open and read the CSV file
with open(csv_file_path, 'r') as file:
    reader = csv.reader(file)
    for i, row in enumerate(reader):
        if i <= 123: # Limit the number of rows to a number depending on the image size
            # Convert each string to float, replace empty strings with 0.0
            float_row = [float(value) if value != '' else 0.0 for value in row]
            data.append(float_row)
        else:
            break

# Modify the data
# V_1.0
# for i in range(len(data)):
#     for j in range(len(data[i])):
#         if data[i][j] != 0 and data[i][j] != -100 and data[i][j] != 100:
#             data[i][j] = 200

# V_2.0
# for i in range(len(data)):
#     for j in range(len(data[i])):
#         if data[i][j] < 0:
#             data[i][j] = 0
#         elif data[i][j] > 0 and data[i][j] != 200 and data[i][j] != 100:
#             data[i][j] = -100

# V_3.0
# for i in range(len(data)):
#     for j in range(len(data[i])):
#         if data[i][j] < 0 and data[i][j] != -100:
#             data[i][j] = 0
#         elif data[i][j] > 0 and data[i][j] != 100:
#             data[i][j] = 200

# V_4.0
# for i in range(len(data)):
#     for j in range(len(data[i])):
#         if data[i][j] < 0:
#             data[i][j] = 0
#         elif data[i][j] > 0:
#             data[i][j] = 200

# Class exchange
# for i in range(len(data)):
#     for j in range(len(data[i])):
#         if data[i][j] == 100:
#             data[i][j] = -100
#         elif data[i][j] == -100:
#             data[i][j] = 100

# Save the modified data back to the CSV file
with open(csv_file_path, 'w', newline='') as file:
    writer = csv.writer(file)
    writer.writerows(data)

# Convert the list of lists into a tensor
tensor_data = torch.tensor(data, dtype=torch.float32)

# Now tensor_data is a tensor representation of your CSV file
print(tensor_data.shape)

# Visualize the image array
plt.imshow(tensor_data, cmap='gray')
plt.axis('off')
plt.show()