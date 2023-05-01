cd server
dotnet restore
dotnet dev-certs https --trust
chmod +x data_fetcher.R
./data_fetcher.R

cd ../client
yarn