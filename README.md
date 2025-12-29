# URL Shortening Service

A simple and clean URL Shortening API built using ASP.NET Core.  
This project demonstrates REST API design, layered architecture, and basic service abstraction.

## Features
- Generate short URLs from long URLs
- Redirect short URLs to original URLs
- Clean and maintainable project structure
- Configuration-based setup using appsettings.json

## Tech Stack
- ASP.NET Core Web API
- C#
- .NET
- REST principles

## Project Structure
- **Model** – Request and response models
- **Services** – Business logic for URL generation and lookup
- **Exceptions** – Custom exception handling
- **Properties / Configuration** – Application settings

## Getting Started

### Prerequisites
- .NET SDK installed

### Run the project
```bash
dotnet restore
dotnet run
