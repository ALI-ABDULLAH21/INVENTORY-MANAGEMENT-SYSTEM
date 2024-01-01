# Inventory Management System

## Overview
This Inventory Management System is a web-based application developed using C# .NET WebForms with a Microsoft SQL Server database. The system is designed to manage and track inventory-related operations for an organization. The application supports three main entities: Admin, Employee, and Customer.

## Features
- **Admin Module:**
  - Access to Customer, Supplier, Product, StockTransaction, Order, OrderDetail, OrderHistory, OrderDetailHistory tables.
  - Full control over inventory-related operations and transactions.

- **Employee Module:**
  - Access to Product, Order, OrderDetail, OrderHistory, OrderDetailHistory tables.
  - Limited access compared to the Admin, focused on managing products and orders.

- **Customer Module:**
  - Access to the Customer and OrderDetail tables.
  - Limited access, allowing customers to view and manage their orders.

## Technologies Used
- C# .NET WebForms
- Microsoft SQL Server

## Database Structure
- The database includes the following tables:
  - Customer
  - Supplier
  - Product
  - StockTransaction
  - Order
  - OrderDetail
  - OrderHistory
  - OrderDetailHistory

## Installation
1. Clone the repository to your local machine.
2. Open the solution in Visual Studio.
3. Restore NuGet packages and ensure the correct .NET Framework version is set.
4. Update the connection string in the web.config file to point to your Microsoft SQL Server database.
5. Run the database scripts provided in the `DatabaseScripts` folder to create the required tables.
6. Build and run the application in Visual Studio.

## Usage
- Login using the appropriate credentials based on the user role (Admin, Employee, Customer).
- Navigate through the modules to perform the desired inventory management tasks.

## Contributors
- Ali Abdullah

## License
This project is licensed under the [License Name] - see the [LICENSE.md](LICENSE.md) file for details.

## Acknowledgments
- Special thanks to [Any Acknowledgments]

Feel free to contribute and improve this Inventory Management System!
