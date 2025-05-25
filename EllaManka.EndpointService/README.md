# EllaManka.EndpointService

## Overview
EllaManka.EndpointService is an ASP.NET Core project that exposes REST APIs for weather forecast data. It provides endpoints to retrieve weather information and is structured to facilitate easy expansion and maintenance.

## Project Structure
- **Controllers**: Contains the API controllers that handle HTTP requests.
  - `WeatherForecastController.cs`: Manages requests related to weather forecasts.
  
- **Models**: Defines the data structures used in the application.
  - `WeatherForecast.cs`: Represents the properties of a weather forecast object.

- **Program.cs**: The entry point of the application that sets up and runs the web application.

- **Startup.cs**: Configures services and the application's request pipeline.

- **appsettings.json**: Contains configuration settings for the application.

- **EllaManka.EndpointService.csproj**: The project file that defines dependencies and build settings.

## Setup Instructions
1. Clone the repository or download the project files.
2. Open the project in your preferred IDE.
3. Restore the project dependencies by running:
   ```
   dotnet restore
   ```
4. Run the application using:
   ```
   dotnet run
   ```
5. Access the API endpoints at `http://localhost:5000/api/weatherforecast`.

## Usage
- To retrieve weather forecast data, send a GET request to the `/api/weatherforecast` endpoint.
- The response will include a list of weather forecasts with properties such as Date, TemperatureC, TemperatureF, Summary, and Icon.

## Contributing
Contributions are welcome! Please submit a pull request or open an issue for any enhancements or bug fixes.