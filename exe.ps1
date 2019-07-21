
dotnet msbuild src\HelloForms /v:m
dotnet publish src\HelloForms --no-restore --no-build -r win-x64 -c Debug --self-contained
