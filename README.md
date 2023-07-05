# BaseApp.API
A .NET Core 7 backend API for the BaseApp application, which interacts with a MySQL database. This API retrieves data from a `Test` table in the database and exposes it through an endpoint.

## Prerequisites
- .NET Core 7.0
- MySQL server
- Visual Studio 2019+
- Entity Framework Core Tools (For running migrations)

## Setup and Running

1. **Clone the repository**  
   Clone this repository to your local machine.

2. **Set up the MySQL database**  
   Create a MySQL database and a user with the necessary privileges to access the database.

3. **Update the connection string**  
   Navigate to the `appsettings.json` file in the `BaseApp.API` directory and update the `BaseDbConnection` connection string with your MySQL server details.

4. **Apply database migrations**  
   Navigate to the `BaseApp.API` directory in your terminal and run the following commands:

   - `dotnet ef migrations add InitialCreate`  
   - `dotnet ef database update`

   These commands will create the `Test` table in your database and seed it with two entries:

   1. Id: 1, Name: "Rzv"
   2. Id: 2, Name: "Izu"

5. **Run the application**  
   Still in the `BaseApp.API` directory, run `dotnet run` to start the .NET Core backend. The API will be running at `https://localhost:5001/` (or another port depending on your setup).

## API Endpoints

- `GET /api/Test`: Retrieves the entries from the `Test` table in the database.

## Troubleshooting

- If you encounter an "Access Denied" error when connecting to the MySQL database, ensure that your MySQL user has the necessary privileges. You can manage user privileges in the MySQL section of your cPanel.
- If you get a "The term 'Add-Migration' is not recognized..." error, ensure that the Entity Framework Core Tools are properly installed.

## Security Considerations

This project is intended for educational and demonstration purposes. In a production application, you should take steps to secure your application:

- Do not store sensitive data like database connection strings in your code or `appsettings.json`. Use secure methods to store these secrets, like Azure Key Vault, environment variables, or user secrets in development.
- Implement proper error handling and logging.
- Consider using HTTPS for your API endpoints.
