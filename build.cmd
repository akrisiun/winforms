@echo off

powershell -ExecutionPolicy ByPass -NoProfile -command "& """%~dp0eng\common\Build.ps1""" -restore -build -bl %*"

@REM # +  Core SDK 2.2.101
@REM # .\eng\common\Build.ps1 -restore -build -bl 

@REM eng\common\darc-init.ps1
@REM https://dotnetcli.azureedge.net/dotnet/Sdk/3.0.100-preview-009820/dotnet-sdk-3.0.100-preview-009820-win-x64.zip

@REM .\eng\common\Build.ps1 -restore -build -bl 
@REM #%*"

exit /b %ErrorLevel%
