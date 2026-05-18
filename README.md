# 🛒 Mini Market Management System

A desktop-based **Mini Market Management System** developed using **C# (Windows Forms)** and **SQL Server**. This project helps manage supermarket operations including products, sellers, categories, and billing efficiently.

## 📌 Features

- 🔐 **Admin Login System**
- 👨‍💼 **Seller Management**
- 📦 **Product Management**
- 🏷️ **Category Management**
- 🧾 **Billing System**
- 💾 **Database Connectivity using SQL Server**
- 📊 Easy inventory and sales management

---

## 🛠️ Technologies Used

- **Programming Language:** C#
- **Framework:** .NET Framework (Windows Forms)
- **Database:** SQL Server
- **IDE:** Visual Studio

---

## 📂 Project Modules

### 1. Login Module
- Admin Login
- Seller Login Authentication

### 2. Seller Management
- Add Seller
- Update Seller Information
- Delete Seller
- View Seller List

### 3. Category Management
- Add Categories
- Edit Categories
- Remove Categories

### 4. Product Management
- Add Products
- Update Product Information
- Delete Products
- Product Categorization

### 5. Billing System
- Generate Bills
- Product Selling
- Calculate Total Price

---

## 🗃️ Database Design

The system uses the following database tables:

### AdminTbl
| Column Name | Data Type |
|-------------|-----------|
| AdminId | Int |
| AdminName | Varchar |
| AdminPassword | Varchar |

### SellerTbl
| Column Name | Data Type |
|-------------|-----------|
| SellerId | Int |
| SellerName | Varchar |
| SellerAge | Int |
| SellerPhone | Varchar |
| SellerPassword | Varchar |

### CategoryTbl
| Column Name | Data Type |
|-------------|-----------|
| CatId | Int |
| CatName | Varchar |
| CatDescription | Varchar |

### ProductTbl
| Column Name | Data Type |
|-------------|-----------|
| ProdId | Int |
| ProdName | Varchar |
| ProdQty | Int |
| ProdPrice | Decimal |
| ProdCategory | Varchar |

### BillTbl
| Column Name | Data Type |
|-------------|-----------|
| BillId | Int |
| SellerName | Varchar |
| TotalAmount | Decimal |
| BillDate | Date |

---

## 🧩 System Workflow

1. User logs in as **Admin** or **Seller**
2. Admin manages:
   - Sellers
   - Categories
   - Products
3. Seller generates bills for customers
4. Sales are processed and stored

---

## 📸 Screenshots

### Login Form
(Add screenshot here)

### Product Management
(Add screenshot here)

### Category Management
(Add screenshot here)

### Billing System
(Add screenshot here)

---

## 🚀 Installation Guide

### Prerequisites
- Visual Studio
- SQL Server
- .NET Framework

### Steps to Run

1. Clone the repository

```bash
git clone https://github.com/your-username/mini-market-management-system.git
```

2. Open the project in **Visual Studio**

3. Restore the database in **SQL Server**

4. Update the database connection string

5. Run the project

---

## 📁 Project Structure

```text
Mini Market Management System/
│── Database/
│── Forms/
│── Seller.cs
│── Product.cs
│── Category.cs
│── Login.cs
│── Billing.cs
│── Program.cs
│── App.config
```

---

## 🔮 Future Improvements

- Sales Report Generation
- Barcode Scanner Integration
- Stock Alert System
- Multi-user Access
- Cloud Database Support

---

## 👨‍💻 Author

**Your Name**

---

## 📄 License

This project is developed for **educational purposes**.
