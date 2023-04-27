pre-commit install

cd server
dotnet restore
dotnet dev-certs https --trust

cd ../client
yarn