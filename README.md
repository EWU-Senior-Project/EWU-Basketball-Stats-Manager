# EWU Basketball Stats Manager

# Setup

## Steps Before Starting Development

- ### Install VS Code [https://code.visualstudio.com/](https://code.visualstudio.com/)

- ### Add remote development extension to VS Code

## Steps for Development on Windows.

- ### Open powershell and run `wsl --install`

- ### Install Ubuntu LTS from Windows Store.

- ### Make sure that WSL 2 is running and not WSL 1 by using `wsl -l -v` in powershell

  - #### If WSL 1 is running then use `wsl --set-version <distro name> 2` in powershell to swap the version to WSL 2

## How to Setup Dev Container

- ### Install Docker CLI in Ubuntu.

  - #### Follow steps on: [https://docs.docker.com/engine/install/ubuntu/](https://docs.docker.com/engine/install/ubuntu/)
  - #### Run the command: `dockerd` to start the docker daemon

- ### Open ubuntu terminal and clone repository.

- ### Navigate to cloned repo and enter `code .` to open the repo in VS Code using remote connection.

- ### Look at the box in the bottom left to see if the container is running
- ### If it is not running, select the box to open the command palette
- ### Select the option: `reopen in container`

## VERY IMPORTANT!!!

### Dev Certificates not implemented yet. This blocks Fetch API's access to endpoints.

- ### To fix this, you can create a file called .env at the root of the client directory and paste `export NODE_TLS_REJECT_UNAUTHORIZED=0` into it.

# Development

## How to Start Development Server

- ### Open the Project in the Dev Container

- ### From the Project's Root Directory run the commands: `cd server` then `dotnet run`. <small>This will start up the backend of the program</small>

  - #### You can access the [Swagger Tool](https://swagger.io/) by pressing `ctrl + click` on the `https://localhost:8080` link in the terminal

- ### Open a New VS Code Integrated Terminal

- ### From the Project's Root Directory run the commands: `cd client` then `yarn dev`. <small>This will start up the frontend of the program</small>
  - #### You can access the live sever by pressing `ctrl + click` on the `http://localhost:3000` link in the terminal

# Tech Stack

- ## Frontend

  - ### [Typescript](https://www.typescriptlang.org/docs/)
  - ### [React](https://react.dev/)
  - ### [Material UI](https://mui.com/)
  - ### [Remix](https://remix.run/docs/en/main)
  - ### [Slate JS](https://docs.slatejs.org/)

- ## Backend

  - ### [C#](https://learn.microsoft.com/en-us/dotnet/csharp/)
  - ### [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/)
  - ### [Swagger](https://swagger.io/)
  - ### [PostgreSQL](https://www.postgresql.org/)
  - ### [PGAdmin](https://www.pgadmin.org/download/)

- ## Development Container

  - ### [Docs](https://code.visualstudio.com/docs/devcontainers/containers)

- ## Data Source
  - ### [Repository](https://github.com/sportsdataverse/hoopR/)
  - ### [R Documentation](https://www.r-project.org/other-docs.html)
