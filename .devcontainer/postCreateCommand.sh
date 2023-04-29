pre-commit install

terminate_processes() {
  echo "Terminating dotnet and yarn processes..."
  kill $dotnet_pid
  kill $yarn_pid
  exit 0
}

# Trap for term
trap terminate_processes SIGINT SIGTERM

#run api
cd server
dotnet restore
dotnet dev-certs https --trust
dotnet run &

#save the background process id
dotnet_pid=$!

#run web app
cd ../client
yarn run dev &

#save the background process id
yarn_pid=$!


wait $dotnet_pid
wait $yarn_pid
