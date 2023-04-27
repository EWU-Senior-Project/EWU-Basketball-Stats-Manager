# EWU Basketball Stats Manager

## Steps before starting development

- ### Install VS Code [https://code.visualstudio.com/](https://code.visualstudio.com/)

- ### Add Remote Development Extension to VS Code

## Steps for development on Windows.

- ### Open powershell and run `wsl --install`

- ### Install Ubuntu LTS from windows store.

- ### Make sure that WSL 2 is running and not WSL 1 by using `wsl -l -v` in powershell

  - #### If WSL 1 is running then use `wsl --set-version <distro name> 2` in powershell to swap the version to WSL 2

## How to Setup Dev Container

- ### Install Docker CLI in Ubuntu.

  - #### Follow Steps on: [https://docs.docker.com/engine/install/ubuntu/](https://docs.docker.com/engine/install/ubuntu/)
  - #### Run the command: `dockerd` to start the docker daemon

- ### Open ubuntu terminal and clone repository.

- ### Navigate to cloned repo and enter `code .` to open the repo in vsCode using remote connection.

- ### Remote into devContainer <small>(using green box in the bottom left)<small>

## Contributing

### Conventional Commits

This repository uses `conventional commits` to ensure that the commit log is readable, and follows industry best practices.

https://www.conventionalcommits.org/en/v1.0.0/
