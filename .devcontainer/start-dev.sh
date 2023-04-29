start_dotnet_server() {
  if ! pgrep -f "dotnet run --urls=http://*:8080"; then
    echo "Starting dotnet server..."
    cd /workspace/server
    dotnet restore
    dotnet dev-certs https --trust &
    dotnet_pid=$!
    
  else
    echo "Dotnet server is already running."
  fi
}

# Function to start the React app if it's not running
start_react_app() {
  if ! pgrep -f "yarn start"; then
    echo "Starting React app..."
    cd ../workspace/app
    yarn start &
    yarn_pid=$!
  else
    echo "React app is already running."
  fi
}

# Function to terminate both processes on receiving termination signals
terminate_processes() {
  echo "Terminating dotnet and yarn processes..."
  kill $dotnet_pid
  kill $yarn_pid
  exit 0
}



# Call the functions to start the apps if they are not running
start_dotnet_server
start_react_app

trap terminate_processes SIGINT SIGTERM
# Wait for both processes to complete
wait $dotnet_pid
wait $yarn_pid

# Keep the terminal session active
exec "$@"