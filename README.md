# Tuition Solution

Tuition Solution is a C# based desktop application developed as a group project to manage tuition-related activities efficiently. The system provides separate functionalities for **Admin**, **Teacher**, and **Student** users through an interactive Windows Forms interface.

## Project Overview

This project simplifies tuition management by providing features such as user registration, login authentication, profile management, teacher–student allocation, and admin approval. The system follows a **role-based architecture** where different users have different permissions.

## Technologies Used

- C#
- .NET Windows Forms
- SQL Server
- Visual Studio

## Main Features

- User registration system
- Secure login system
- Role-based access (Admin, Teacher, Student)
- Admin approval for new accounts
- Student and teacher profile management
- Tuition allocation system
- Password change option
- Forgot password with OTP verification
- Device verification using processor ID
- View active students and teachers

## User Roles

### Admin
- Approve suspended accounts
- View active students and teachers
- Manage user information
- Reactivate devices
- Delete users if necessary

### Teacher
- View assigned tuition allocations
- Update profile information
- Change password
- Search student information
- Delete account

### Student
- Update profile information
- View tuition details
- Search teacher allocation information
- Change password
- Delete account

## Project Structure

- `Login.cs` – User login system
- `registration.cs` – Account registration
- `Admin_Dashboard.cs` – Admin dashboard
- `teacher_desh.cs` – Teacher dashboard
- `student_dash.cs` – Student dashboard
- `Allocation.cs` – Allocation management
- `Forgot.cs` – Password recovery with OTP
- `Change_Pass.cs` – Password changing feature
- `databse.cs` – Database connection
- `otp_and_code.cs` – OTP and ID generation

## Database

This project uses **SQL Server** as the backend database.

Database connection is configured in:


## Project Report

Full documentation of the system is available here:

[Download Project Report](Tuition_Solution_Project_Report.pdf)

## Team Members

- Sajid Mohammad Talukdar
- Argho Dey
- Kazi Samia Mostofa
- Mohammad Saib

## Notes

- This project was developed as part of an **Object Oriented Programming 2 (OOP2)** course project.
- Developed using **C# Windows Forms with SQL Server integration**.

## License

This project is for **educational purposes only**.
