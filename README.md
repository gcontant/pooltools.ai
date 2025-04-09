# PoolTools.AI

PoolTools.AI is a fantasy hockey application designed to provide an engaging and competitive experience for hockey enthusiasts. The app includes features such as user authentication, NHL player listings, pool creation and management, competitive standings, and personalized drafting suggestions.

## Technologies Used

- **Frontend**: Blazor
- **Backend**: .NET 9
- **Database**: PostgreSQL
- **Infrastructure as Code (IaC)**: Bicep with Azure Developer CLI (azd)
- **Development Environment**: GitHub Codespaces or Visual Studio Code

## Features

- User authentication and profiles
- Listing of all signed NHL players
- Pool creation and management with customizable configurations
- Competitive standings board per pool
- Personalized drafting suggestions based on pool configuration and current roster

## Architecture

The application follows a clean architecture pattern:

- **Domain**: Contains the core business logic and domain entities.
- **Application**: Handles use cases and application logic, referencing only the Domain project.
- **Infrastructure**: Manages external dependencies and infrastructure concerns, referencing the Application project.
- **Web**: Provides the user interface and API endpoints, without being referenced by other projects.
