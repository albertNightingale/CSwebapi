## creating a project
### mac user:
dotnet new webapi --name <PROJ_NAME>
### window user:
follow the prompt to create a project on Visual Studio

## running the project
### mac user:
dotnet run 
### window user:
click on debug to start

## Details:
### Controller:
Controllers represents paths in a webAPI. For example, WeatherForecastController listens to requests at the path of <WeatherForecast>
### Program.cs
Program.cs is the file that calls the controllers and set the app for any configuration in the API server. 