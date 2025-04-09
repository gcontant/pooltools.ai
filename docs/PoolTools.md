I want to build fantasy hockey app that will include the following:

* User authentication and profiles
* Listing of all signed NHL players 
* Pool creation and management including configuration such as number of players by position, number of points per goal, assists and other statistical categories
* Competitive standing board per pool
* Personalized suggestions for drafting a player based on the pool configuration and current roster

It should be separated by domain (player, pool, etc.)

generate instructions in this order

1. Create the pooltools directory structure
2. Initialize the project with Azure Developper CLI (azd)
3. Add a devcontainer configuration file base on .net 9 image
4. All infrastructure as code (IaC) files must be centralized in the infra folder
5. Following Clean architecture pattern, the components of each application (player API, pool API, etc.) must respect the following constraints
* The Domain project must only be referenced by the Application project
* The Application project can be referenced by the Infrastructure or Web projects
* The Web projects is not referenced by the other projects
6. Use .net Aspire to orchestrate the different components 

The directory tree for the PoolTools App
pooltools/
├── docs
├── infra
│   ├── pooltools.player.api/
│   ├── pooltools.player.api/
│   ├── main.bicep
├── src/
│   ├── pooltools.player.api/
|   |   ├── application
|   |   ├── domain
|   |   ├── infrastructure
|   |   ├── web
│   ├── pooltools.pool.api/
|   |   ├── application
|   |   ├── domain
|   |   ├── infrastructure
|   |   ├── web
│   ├── pooltools.pool.app/
└── test/

We'll be using a modern web application stack:

Frontend: Blazor
Backend: .net 9
Database: postgresql
Infrastructure as Code (IaC): Bicep with Azure Developper CLI (azd)
Development Environment: GitHub Codespaces or visual studio code

