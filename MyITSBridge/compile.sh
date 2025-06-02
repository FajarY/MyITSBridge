dotnet restore
dotnet publish -c Release -f net9.0 -r linux-x64 --no-restore --property:PublishDir=../build