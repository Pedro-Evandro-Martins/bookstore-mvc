## Boosktore MVC

A simple web application to manage a bookstore, built using the Model-View-Controller (MVC) pattern in .NET. This project aims to provide CRUD functionality for managing books, authors, and orders while serving as a learning tool for .NET MVC web development

## Features
**Planned features include:**
- User management (registration, login, roles)
- CRUD operations for books
- Dynamic UI with Razor views
- Integration with Docker for containerized deployment

## Getting Started

### Prerequisites
**Project was built using the following tools and versions:**
- dotnet-sdk 8.0
- docker 27.3
- docker compose v2.31

### Building the Project
Clone the repository and use the following commands to build the project:
```bash
git clone https://github.com/Pedro-Evandro-Martins/bookstore-mvc
cd bookstore-mvc

docker compose up -d

dotnet ef migrations add "InitialCreation"
dotnet ef database update

dotnet restore  # Restore dependencies
dotnet build    # Build the project
dotnet run      # Start the application 
```

## Author
Pedro Evandro Martins, Systems Analysis and Development Technology Course's student at State University of Campinas (UNICAMP).

### Contributing
Currently, this is a personal project for learning and practice. No active collaboration is expected, but contributions are welcome! If you find any improvements or new features worth adding, feel free to fork the repository, experiment, and submit a pull request!

## Credits and Reference
No personal credit is intended for this learning project as direct references and third party code snippets were used.

This project is based on the tutorial series from the YouTube channel "DotNetMastery":
- [ASP.NET Core MVC Tutorial](https://www.youtube.com/watch?v=AopeJjkcRvU) (last accessed: 01/09/2025)
- [Author Github repository](https://github.com/bhrugen/Bulky_MVC) (last accessed 01/09/2025)