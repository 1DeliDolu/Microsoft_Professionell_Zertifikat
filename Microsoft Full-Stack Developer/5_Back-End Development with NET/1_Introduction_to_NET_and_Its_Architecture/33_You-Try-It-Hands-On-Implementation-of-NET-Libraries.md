
# Instructions

### Lab instructions

5 of 5 completed

[ ] 

Before working with any .NET libraries, you need to create a basic C# console application in Visual Studio Code. This step will guide you through setting up the project.

#### **Steps:**

1. Open Visual Studio Code.
2. Open the terminal by selecting **View** > **Terminal**.
3. In the terminal, create a new directory for your project and navigate into it using the cd command:
   * Create a new folder for your project with a command like mkdirMyFirstConsoleApp.
   * Navigate into the folder with cd MyFirstConsoleApp.
4. Initialize a new C# console application by running the command:
   * dotnet new console -n JsonExample
   * This command creates a new folder named JsonExample with the necessary files for a basic console app.
5. Change directories into your project folder with:
   * cd JsonExample
6. Open the project in Visual Studio Code by running:
   * code .
7. Confirm that your project has been created by checking the presence of the Program.cs file. It should contain a basic "Hello World" program.


[ ]
inLabInstructionsPart~iic1kp1OEe-J0BIVpSBxnw


Now that you have created the project, you should run it to make sure everything is set up correctly.

### Steps:

1. In Visual Studio Code, ensure you are in the root directory of the project (where Program.cs and JsonExample.csproj are located).
2. Open the terminal and run the following command to build and execute the project using dotnet run
3. Confirm that the output displays "Hello World!" to ensure your project is working.


In this step, you will add the **Newtonsoft.Json** library to a .NET project using NuGet. This library is widely used for handling JSON data in web applications and APIs.

### Steps:

1. Open your console app project in Visual Studio Code.
2. In Visual Studio Code, open the **Terminal** and install the Newtonsoft.Json package using the appropriate command.
3. Verify that the package was installed by checking the csproj file, which should list Newtonsoft.Json as a dependency.


Now that you have installed the **Newtonsoft.Json** library, you will use it to parse a JSON string into a C# object.

### Steps:

1. In the Program.cs file, define a simple class named Person.
2. Create a JSON string inside the Main method.
3. Use Newtonsoft.Json to convert the JSON string into a Person object. Write code to output the parsed data.
4. Run the program using the terminal and check the output to confirm that the JSON string was successfully parsed.


In this step, you will take a C# object and convert it back into a JSON string using the **Newtonsoft.Json** library.

### Steps:

1. Add additional code to the Main method to create a new Person object.
2. Use Newtonsoft.Json to serialize the Person object to a JSON string.
3. Run the program again using the terminal.
4. Verify that the output displays the JSON string representation of the Person object.
