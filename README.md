# Tuition Solution

Tuition Solution is a C# based desktop application developed as a group project to manage tuition-related activities efficiently. The system provides separate functionalities for **Admin**, **Teacher**, and **Student** users through an interactive Windows Forms interface.

## Project Overview

This project was built to simplify the management of tuition-related operations such as user registration, login, profile management, teacher-student allocation, and account approval. It is designed as a role-based system where each type of user has different access and features.

## Technologies Used

- C#
- .NET Windows Forms
- SQL Server
- Visual Studio

## Main Features

- User registration system
- Secure login system
- Role-based access for Admin, Teacher, and Student
- Admin approval for newly registered users
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
- Delete users if needed

### Teacher
- View assigned tuition allocations
- Update profile information
- Change password
- Search student-related information
- Delete account

### Student
- Update profile information
- View tuition-related details
- Search for teacher/student allocation information
- Change password
- Delete account

## Project Structure

- `Login.cs` – User login system
- `registration.cs` – New account registration
- `Admin_Dashboard.cs` – Admin panel
- `teacher_desh.cs` – Teacher dashboard
- `student_dash.cs` – Student dashboard
- `Allocation.cs` – Allocation management
- `Forgot.cs` – Password recovery with OTP
- `Change_Pass.cs` – Password changing feature
- `databse.cs` – Database connection and query execution
- `otp_and_code.cs` – OTP and unique ID generation

## Database

This project uses **SQL Server** as the backend database.  
The connection string is currently configured in:

```csharp
databse.cs
