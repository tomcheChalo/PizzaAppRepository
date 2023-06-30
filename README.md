# PizzaApp Repository
Welcome to the PizzaApp repository! This repository houses the codebase for a delightful pizza ordering application. Here, we leverage a powerful N-tier architecture and follow the Repository pattern to ensure a scalable and maintainable codebase.

# N-tier Architecture
The PizzaApp follows a robust N-tier architecture, which separates different components of the application into distinct layers, promoting modularity, flexibility, and ease of maintenance. The architecture consists of the following tiers:

Presentation Tier: This tier handles the user interface and interaction. It includes components such as the user interface layer, user input validation, and presentation logic. Our goal is to provide an intuitive and user-friendly interface for ordering pizzas.

Business Logic Tier: The business logic tier encapsulates the core functionalities of the PizzaApp. It encompasses components responsible for processing business rules, executing workflows, and coordinating data flow between the presentation and data tiers. We strive to implement clean and efficient business logic to ensure a seamless pizza ordering experience.

Data Tier: The data tier deals with data persistence and storage. It includes components such as the database layer, data access objects (DAOs), and data models. We leverage industry-standard database technologies to store and retrieve pizza order information securely and efficiently.

# Repository Pattern
To enhance code maintainability and flexibility, we have implemented the Repository pattern in the PizzaApp. The Repository pattern provides an abstraction layer between the data access logic and the rest of the application, allowing us to decouple our business logic from the underlying data storage implementation.

With the Repository pattern, we can easily switch between different data storage technologies or frameworks without affecting the higher-level components. This ensures that our application remains scalable and adaptable to future changes.

# Directory Structure

# SEDC.PizzaApp.DataAccess
This directory contains the data access layer of the PizzaApp. It includes the following files and directories:

IRepository.cs: This file represents the interface for the repository pattern, providing a contract for data access operations.
PizzaAppDbContext.cs: This file defines the PizzaApp's database context for Entity Framework.

# SEDC.PizzaApp.Domain
The SEDC.PizzaApp.Domain directory contains the domain models and business logic of the PizzaApp. It includes the following files and directories:


# SEDC.PizzaApp.Helpers
The SEDC.PizzaApp.Helpers directory contains helper classes or utility functions that assist in various aspects of the PizzaApp's functionality. It includes the following files and directories:


# SEDC.PizzaApp.Mappers
The SEDC.PizzaApp.Mappers directory contains mapper classes responsible for mapping between different data models or view models. It includes the following files and directories:

OrderMapper.cs: This file handles mapping operations related to orders.
PizzaMapper.cs: This file handles mapping operations related to pizzas.
UserMapper.cs: This file handles mapping operations related to users.

# SEDC.PizzaApp.Refactored
The SEDC.PizzaApp.Refactored directory contains the refactored version of the PizzaApp, including the following files and directories:

*** Controllers: This directory contains the controller classes for the application's routes and endpoints, including HomeController.cs and OrderController.cs.
*** Models: This directory contains model classes used within the PizzaApp, such as ErrorViewModel.cs.
*** Properties: This directory may contain application-specific properties files or resources.
*** Views: This directory contains the view files for the PizzaApp's user interface, organized into subdirectories based on controllers and actions.
*** wwwroot: This directory may contain static files used by the PizzaApp, such as CSS stylesheets or JavaScript files.
*** Program.cs: This file contains the entry point of the PizzaApp.

# SEDC.PizzaApp.Services
The SEDC.PizzaApp.Services directory contains service classes that implement the business logic and handle various operations within the PizzaApp. It includes the following files and directories:

# SEDC.PizzaApp.ViewModels
The SEDC.PizzaApp.ViewModels directory contains view model classes that represent the data displayed in the PizzaApp's views. It includes the following files and directories:

*** OrderViewModels: This directory contains view models specific to orders.
*** PizzaViewModels: This directory contains view models specific to pizzas.
*** UserViewModels: This directory contains view models
