# Speech Inference Environment Setup

Here provides a setup for speech inference using a predefined Conda environment. Follow the steps below to set up and activate the environment.

## Prerequisites

- **Anaconda/Miniconda**: Make sure you have Anaconda or Miniconda installed on your system.

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



