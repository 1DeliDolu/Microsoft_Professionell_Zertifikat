# Instructions


You’ll create a small web API using ASP.NET Core. This API will manage a simple list of items with basic CRUD (Create, Read, Update, Delete) operations.

Steps:

1. Open Visual Studio Code.
2. Make sure you have the .NET SDK installed. If not, install the latest version from the [official .NET website](https://dotnet.microsoft.com/).
3. Open the terminal in Visual Studio Code (Ctrl + ~ for Windows/Linux or Cmd + ~ for Mac).
4. Create a new ASP.NET Core Web API project:
5. Navigate to the project directory.
6. Open the project in Visual Studio Code.


You’ll now set up the basic project structure and configure the necessary components for your API.

Steps:

1. In the Program.cs file, remove any existing code and start with a clean slate.
2. Use the following basic structure to set up your API routes:
   var builder = WebApplication.CreateBuilder(args);
   var app = builder.Build();
   // Basic routes
   app.MapGet("/", () => "Welcome to the Simple Web API!");
   app.Run();
3. Save the file and run your project.
4. Open a web browser and check if the API is running.


Create the necessary endpoints for managing a list of items (GET, POST, PUT, DELETE).

Steps:

1. Create a new folder named Models and add a file called Item.cs.
2. Define a basic model for the items.
3. In the Program.cs file, create an in-memory list to store items.
4. Implement the endpoints.
   1. **GET** all items:
   2. **GET** a specific item by ID:
   3. **POST** a new item:
   4. **PUT** to update an existing item:
   5. **DELETE** an item by ID:
5. Save the file and test the endpoints by running the project.


Use Postman to test your API endpoints.

Steps:

1. Open Postman and create a new request.
2. Set the request type (GET, POST, PUT, DELETE) in the dropdown menu.
3. Enter the API URL in the request field (e.g., http://localhost:5000/items).
4. For POST and PUT requests, go to the "Body" tab, select "raw", and choose "JSON" as the format. Enter your JSON data, for example:

   {
   "name": "New Item"
   }
5. Click "Send" to make the request.
6. Check the response in the lower section of Postman to ensure the API behaves as expected.
