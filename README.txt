CarDealer Web Application
========================

Project Description:
-------------------
This is a backend web application for a Car Dealer. It allows:

- Admin to add new cars (simulated, no authentication)
- Users to view all cars
- Users to submit inquiries about cars

Technologies Used:
------------------
- C# 12
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server (localdb or full server)

Project Structure:
------------------
1. CarDealer.Core       -> Contains domain models (Car, Inquiry)
2. CarDealer.Infrastructure -> DbContext and database migrations
3. CarDealer.Web        -> ASP.NET Core Web API project with controllers

How to Run Locally:
------------------
1. Open the solution in Visual Studio 2022 (or later)
2. Ensure SQL Server is running
3. Run the following commands in terminal (inside project root):

   # Apply migrations
   dotnet ef database update --project CarDealer.Infrastructure --startup-project CarDealer.Web

   # Run the API
   dotnet run --project CarDealer.Web

API Endpoints:
--------------
1. GET /api/Cars
   - Get all cars

2. POST /api/Cars
   - Add a new car
   - Body JSON example:
     {
       "make": "Toyota",
       "model": "Corolla",
       "year": 2020,
       "price": 15000,
       "description": "Good condition, one owner"
     }

3. GET /api/Inquiries
   - Get all inquiries

4. POST /api/Inquiries
   - Submit a new inquiry
   - Body JSON example:
     {
       "carId": 1,
       "name": "Kolya",
       "email": "kolya@example.com",
       "phone": "+373XXXXXXXX",
       "message": "I want to know more about this car"
     }

Notes:
------
- Admin login is simulated; no real authentication is implemented.
- CreatedAt fields are automatically populated with current datetime.
- This project is part of the Bincom Academy C# Beginner Test.

Author:
-------
Kolya (skromn1k)
