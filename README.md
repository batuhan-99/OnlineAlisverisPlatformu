Online Shopping Platform

This project has been developed to create an online shopping platform. While customers can browse products and place orders, admins can manage products and orders. The project is equipped with technologies and features commonly used in modern web applications.

Table of Contents

Purpose of the Project

Features

Technologies Used

Setup

Usage

API Endpoints

To-Do List

Purpose of the Project

This project provides features that cater to the needs of users with customer and admin roles in a shopping platform. The aim is to deliver a secure, performant, and user-friendly shopping experience with features like JWT authentication, user authorization, logging with middleware, and maintenance mode.

Features

JWT Authentication and Authorization: Secure authentication and authorization.

Middleware:

LoggingMiddleware: Logs all incoming requests.

MaintenanceMiddleware: Returns a "Site under maintenance" message for all requests when in maintenance mode.

Data Protection: User passwords are securely stored.

Global Exception Handling: Unexpected errors are centrally caught and managed.

Technologies Used

ASP.NET Core Web API

Entity Framework Core (Code First Approach)

ASP.NET Core Identity

JWT (JSON Web Token) for Authentication

Middleware

Data Protection API
