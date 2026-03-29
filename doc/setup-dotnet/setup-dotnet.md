# Guide to Setting Up the .NET Environment on Windows and Creating a Project

## 1. Purpose
This document outlines the steps for setting up the .NET environment and how to launch a basic .NET project.

## 2. Setting Up the .NET Environment
**Step 1:** Visit the [.NET Download](https://dotnet.microsoft.com/download) homepage.

![Trang chủ .NET Download](<Screenshot 2026-03-22 200726.png>)

**Step 2:** Download the .NET SDK installer for Windows (x64 version).

![Tải bộ cài đặt](<Screenshot (18).png>)

**Step 3:** Run the installer.

![Cài đặt thành công](<Screenshot 2026-03-22 193039.png>)

**Step 4:** Verify the installation by opening the Terminal and running the command:
` ` `bash
dotnet --version
` ` `

![Kiểm tra cài đặt](<Screenshot 2026-03-22 193130.png>)

*(Insert a screenshot of your terminal here using the syntax: `![Image description](image_link_or_path)`)*

## 3. Initialize the Source Code (Init Project)

Open Terminal, create a new directory for the project, and navigate to that directory:

![tạo một thư mục mới](<Screenshot 2026-03-22 193505.png>)

To create a new project, run the following command in the empty directory:
` ` `bash
dotnet new console
` ` `
This command will create a basic Console application.

![Tạo Console](<Screenshot 2026-03-22 193604.png>)

## 4. Run the Project
Use the following command to build and run the application:
` ` `bash
dotnet run
` ` `
The result displayed on the screen will be: `Hello, World!`

![Kết quả màn hình](<Screenshot 2026-03-22 193633.png>)

## 5. Push Code to GitHub
Create a GitHub repository for the project

![Tạo 1 Repository](<Screenshot 2026-03-22 204300.png>)

Next, type `git init` to initialize a Git repository and add the command `git commit -m “Add new project food”`. This command is used to note changes for easy tracking

![Tạo lệnh git init và git commit](<Screenshot 2026-03-22 205513.png>)

Next, type the command `git branch -M main`

Then add the command `git remote add origin <GitHub link of the repository created earlier>

![Tạo lệnh git branch và git remote](<Screenshot 2026-03-22 205851.png>)

Finally, type the command `git push -u origin main` to push the code to GitHub

![Đưa code lên Github](<Screenshot 2026-03-22 210408.png>)

Result upon completion

![Kết quả](<Screenshot 2026-03-22 210908.png>)
