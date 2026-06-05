# E-Commerce Backend API

A backend-focused e-commerce project built with **.NET 9**, **Clean Architecture**, **Entity Framework Core**, and **PostgreSQL**.

The purpose of this repository is to practice and demonstrate enterprise-level backend development, focusing on maintainable architecture, SOLID principles, authentication, authorization, and scalable API design.

---

## 🚀 Tech Stack

- .NET 9
- ASP.NET Core Web API
- Entity Framework Core
- PostgreSQL
- JWT Authentication
- FluentValidation
- Swagger / OpenAPI

---

## 📁 Project Structure

```text
src/
├── Ecommerce.Domain
├── Ecommerce.Application
├── Ecommerce.Infrastructure
└── Ecommerce.API
```

### Domain Layer

Contains:

- Entities
- Enums
- Value Objects
- Domain Rules

This layer has no dependency on any external framework.

### Application Layer

Contains:

- DTOs
- Interfaces
- Services
- Use Cases
- Validation Rules

Responsible for application business logic.

### Infrastructure Layer

Contains:

- Entity Framework Core
- DbContext
- Repository Implementations
- Database Migrations
- External Services

Responsible for data access and third-party integrations.

### API Layer

Contains:

- Controllers
- Middleware
- Dependency Injection
- Swagger Configuration

Acts as the entry point for client requests.

---

## 🏗 Architecture

The project follows Clean Architecture principles.

```text
API
 ↓
Application
 ↓
Domain

Infrastructure
 ↓
Application
 ↓
Domain
```

Dependency flow:

```text
Ecommerce.API
    ├── Ecommerce.Application
    └── Ecommerce.Infrastructure

Ecommerce.Infrastructure
    ├── Ecommerce.Application
    └── Ecommerce.Domain

Ecommerce.Application
    └── Ecommerce.Domain
```

---

## 🔑 Features

### Authentication

- User Registration
- User Login
- JWT Access Token
- Refresh Token Support
- Password Hashing

### Authorization

- Role-Based Access Control (RBAC)
- Admin Role
- Customer Role

### Product Management

- Create Product
- Update Product
- Delete Product
- Product Details
- Product Search
- Pagination
- Filtering

### Category Management

- Create Category
- Update Category
- Delete Category

### Shopping Cart

- Add Item
- Update Quantity
- Remove Item
- View Cart

### Order Management

- Checkout
- Order History
- Update Order Status
- Admin Order Management

---

## 🗄 Database

Database Provider:

```text
PostgreSQL
```

Main Tables:

```text
Users
Categories
Products
Carts
CartItems
Orders
OrderItems
```

Entity Framework Core Code-First approach is used.

---

## 🎯 Learning Objectives

This project is built to improve skills in:

- Clean Architecture
- SOLID Principles
- Entity Framework Core
- PostgreSQL
- JWT Authentication
- RESTful API Design
- Dependency Injection
- Validation & Error Handling
- Enterprise Backend Development

---

## 📌 Future Improvements

- CQRS Pattern
- MediatR
- Redis Caching
- Docker Support
- Unit Testing
- Integration Testing
- CI/CD Pipeline
- Cloud Deployment
- Event-Driven Architecture

---

> A production-inspired backend project built to practice Clean Architecture, SOLID principles, and enterprise-level API development using .NET and PostgreSQL.