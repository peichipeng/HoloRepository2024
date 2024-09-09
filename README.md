# 1. Speech Inference Environment Setup

Here provides a setup for speech inference using a predefined Conda environment. Follow the steps below to set up and activate the environment.

## Prerequisites

- **Anaconda/Miniconda**: Make sure you have Anaconda or Miniconda installed on your system. If not, you can download and install it from the official website: [Anaconda Download](https://www.anaconda.com/download/success).
  - **Manually Add Anaconda to System Environment Variables**
    1. **Locate Your Anaconda Installation Path:**
       - Common default installation paths are:
         - For 64-bit systems: `C:\ProgramData\Anaconda3` or `C:\Users\<YourUsername>\Anaconda3`
         - For 32-bit systems: `C:\ProgramData\Anaconda2` or `C:\Users\<YourUsername>\Anaconda2`
    2. **Add the Path to Environment Variables:**
       - Open the **Settings** by pressing `Win + I` or by clicking on the Start menu and selecting "Settings."
       - In the Settings window, navigate to **System > About**.
       - Scroll down and click on **Advanced system settings** under the "Related settings" section on the right.
       - Click the "Environment Variables" button in the System Properties window that appears.
       - In the "System variables" section, find the `Path` variable and click "Edit."
       - In the window that pops up, click "New" and add the following paths:
         - `<Your Anaconda Installation Path>`
         - `<Your Anaconda Installation Path>\Scripts`
         - `<Your Anaconda Installation Path>\Library\bin`
       - Ensure these paths are added to the `Path` variable and click "OK" to save the changes.


## Environment Setup

To set up the environment for speech inference, follow these steps:

1. **Navigate to the directory containing the `.yml` file**  
   Open your terminal and change to the directory where the `speech_recognition_env.yml` file is located:

   ```bash
   cd path\to\yml\file
   ```
2. **Create the Conda environment**
   Create a new Conda environment using the .yml file. The environment will be created in the current directory under the name speech_recognition_env:

   ```bash
   conda env create -f speech_recognition_env.yml --prefix ./speech_recognition_env
   ```
3. **Activate the Conda environment**
   Once the environment is created, activate it with the following command:

   ```bash
   conda activate ./speech_recognition_env
   ```
## Usage
After activating the environment, you can run your speech inference scripts and tools as needed. Make sure to keep the environment activated while working with speech-related tasks.

## Deactivation
When you are done, you can deactivate the environment with:

   ```bash
   conda deactivate
   ```
## Removing the Environment
If you need to remove the environment for any reason, use the following command:
```bash
conda env remove --prefix ./speech_recognition_env
```

# 2. Change the Database Setting

Create a new database, restore the database using the file provided and change the parameters of connection string in DatabaseConnection.cs to your own.

# 3. Change the directory path to the Organ Slices

Change the directoryPath in the AddOrganSlice.cs to the path accessing the pictures stored in your computer.



