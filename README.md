# 💼 Employee & User Management System - C# Windows Forms  

## 📌 Project Overview  
This project was developed as part of the **System Analysis and Design course**, using the **Scrum methodology** for project management and iterative development.  
It is submitted to **Dr. Ibrahim Al-Haddad**.  

The application is a simple desktop system built with **C# and Windows Forms**, following a **Three-Tier Architecture**:  
- **Presentation Layer** (UI Forms)  
- **Business Logic Layer** (Processing logic and rules)  
- **Data Access Layer** (Database operations)  

The application allows:  
- User login authentication.  
- A dashboard that displays real-time statistics.  
- Managing users (Add, Edit, Delete).  
- Smooth navigation between windows.  

---

## 🖼️ Application Features  

### 1. Login Screen  
- Validates username and password.  
- Redirects to the dashboard upon successful login.  
- Includes clickable GitHub and LinkedIn icons.  

### 2. Dashboard  
- Displays real-time statistics:  
  - Total number of employees.  
  - Total salary of all employees.  
  - Total number of system users.  
- Buttons to manage employees or users.  

### 3. Manage Users Form  
- Displays all users in a DataGridView.  
- Allows adding new users, editing existing ones, or deleting.  
- Uses an internal enum-based mode (AddNew, Update) to switch between insert and edit functionality.  

---

## ⚙️ Technologies Used  
- 💻 C#  
- 🪟 Windows Forms  
- 🧱 Three-Tier Architecture (UI Layer, Business Layer, Data Access Layer)  
- 💾 Database Access (via ADO.NET or equivalent logic in Business Layer)  

---

## 🚀 How to Run  
1. Open the project in Visual Studio.  
2. Set up your database connection string (if needed).  
3. Start the application from `frmLogin`.  

---

## 📁 Project Structure  
📁 EmployeesWindowsForm  
│  
├── frmLogin.cs             # Login Form  
├── frmDashBoard.cs         # Dashboard Form  
├── frmManageUsers.cs       # User Management Form  
├── clsUser.cs              # User logic (Business Layer)  
├── clsEmployee.cs          # Employee logic (Business Layer)  

---

## 👨‍💻 Developer  
**Name:** Mohamed Abass  
🔗 LinkedIn Profile  
💻 GitHub Profile  

---

## 📝 Notes  
- This project was built as part of a **university course**.  
- Developed using **Scrum methodology** for iterative development.  
- Still a work in progress and open for suggestions or improvements.  
Feel free to contribute or share your feedback! 🙌  
