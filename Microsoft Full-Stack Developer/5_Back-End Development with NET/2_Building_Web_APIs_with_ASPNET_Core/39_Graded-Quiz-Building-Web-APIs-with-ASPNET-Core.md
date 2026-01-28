### 1.

Question 1

A small business is developing an API to support its growing e-commerce platform. They want a cost-effective framework that can handle increasing traffic without requiring expensive licensing fees. Why is ASP.NET Core a suitable choice?

[ ]It includes built-in caching and database scaling without additional configuration

[ ]It guarantees 99.99% uptime with automatic failover

[ ]It is free, open-source, and designed for high-performance applications

[ ]It requires a subscription-based license for advanced API features

1 point

### 2.

Question 2

A company is deploying an ASP.NET Core web API to a cloud environment. To ensure a smooth setup, they need to correctly configure the API project before adding controllers. What is the first step?

[ ]Deploy an empty API to the cloud and configure middleware later

[ ]Configure Program.cs to define services, middleware, and application settings

[ ]Define all API routes in appsettings.json before implementing business logic

[ ]Create a Startup.cs file to manually manage dependency injection

1 point

### 3.

Question 3

An API developer is implementing routing in an ASP.NET Core application and wants to ensure URLs are mapped correctly to the appropriate controller actions. Which statement about ASP.NET Core routing is correct?

[ ]Routing in ASP.NET Core maps HTTP requests to specific endpoints based on route templates and patterns

[ ]Routing must always be manually defined in Program.cs

[ ]Routing in ASP.NET Core is only configured using attribute routing

[ ]Routing in ASP.NET Core does not support parameters in the URL

1 point

### 4.

Question 4

A startup is choosing ASP.NET Core for its API development. They want a flexible solution where they can add features as needed. How does ASP.NET Core’s architecture help?

[ ]It prevents developers from using third-party libraries

[ ]It limits applications to a single deployment model

[ ]It supports modular development, allowing features to be added incrementally

[ ]It requires all features to be included at the start of development

1 point

### 5.

Question 5

A development team is implementing unit tests for their ASP.NET Core web API. They need a way to replace real service implementations with mock services during testing. How does dependency injection support this requirement?

[ ]It automatically generates test cases for service components

[ ]It ensures services do not change between development and production environments

[ ]It prevents circular dependencies between application services

[ ]It allows mock services to be injected into components, making testing more modular and maintainable

1 point

### 6.

Question 6

A company is developing a multi-tenant ASP.NET Core application. Some services, like logging, need to be shared across the entire application, while others, like user sessions, should only last for a single request. How should the team configure their dependency injection lifetimes?

[ ]Use Singleton for user session management and Transient for caching data

[ ]Use Transient for shared services, Singleton for request-based services, and Scoped for database access

[ ]Singleton is best for shared services like logging, Scoped is ideal for per-request services like database contexts, and Transient is useful for stateless, lightweight operations such as formatting utilities

[ ]Use Scoped for long-running background services and Singleton for per-request dependencies

1 point

### 7.

Question 7

An e-commerce company is developing a web API in ASP.NET Core. They need to ensure that unexpected errors, such as database failures or invalid API requests, are handled consistently across all endpoints without exposing sensitive information. What is the best approach for managing errors globally?

[ ]Store all exceptions in a static list to manually review errors later

[ ]Allow unhandled exceptions to be displayed in the API response to assist with debugging

[ ]Implement middleware to catch unhandled exceptions and return structured error responses

[ ]Require each controller action to include a try-catch block for exception handling

1 point

### 8.

Question 8

An API team wants to ensure proper logging practices in their ASP.NET Core application. Which of the following represents a best practice for logging?

[ ]Print all log messages to the console without categorization

[ ]Store all logs directly in a database without using log levels

[ ]Disable logging in production environments to improve performance

[ ]Use structured logging with built-in logging providers for consistency

1 point

### 9.

Question 9

A development team is deploying an ASP.NET Core web API to a cloud environment. They need to configure different logging levels for development and production to ensure efficient monitoring while minimizing unnecessary logs in production. Where should they define the logging level settings?

[ ]Manually specify log levels in every controller’s constructor

[ ]Use inline comments in API methods to control logging output

[ ]In the appsettings.json file under the Logging section

[ ]Configure logging levels using a database table that stores log settings

1 point

### 10.

Question 10

A company is troubleshooting an ASP.NET Core API where authentication is not working as expected. What could be the issue with middleware ordering?

[ ]Middleware only affects application startup, not request handling

[ ]Authentication middleware must be placed before authorization middleware to function correctly

[ ]Middleware executes randomly, so order does not matter

[ ]Middleware must be added after defining API endpoints

1 point


### 1.

Question 1

A small business is developing an API to support its growing e-commerce platform. They want a cost-effective framework that can handle increasing traffic without requiring expensive licensing fees. Why is ASP.NET Core a suitable choice?

[ ]It includes built-in caching and database scaling without additional configuration
[ ]It guarantees 99.99% uptime with automatic failover
[x]It is free, open-source, and designed for high-performance applications

That’s correct! ASP.NET Core is free, open-source, and optimized for handling high-traffic applications efficiently, making it a cost-effective choice for growing businesses.
[ ]It requires a subscription-based license for advanced API features

---

### 2.

Question 2

A company is deploying an ASP.NET Core web API to a cloud environment. To ensure a smooth setup, they need to correctly configure the API project before adding controllers. What is the first step?

[ ]Deploy an empty API to the cloud and configure middleware later
[x]Configure Program.cs to define services, middleware, and application settings 

That’s correct! The Program.cs file is responsible for setting up services, middleware, and the request pipeline, which is essential before adding controllers.
[ ]Define all API routes in appsettings.json before implementing business logic
[ ]Create a Startup.cs file to manually manage dependency injection

---

### 3.

Question 3

An API developer is implementing routing in an ASP.NET Core application and wants to ensure URLs are mapped correctly to the appropriate controller actions. Which statement about ASP.NET Core routing is correct?

[x]Routing in ASP.NET Core maps HTTP requests to specific endpoints based on route templates and patterns

That’s correct! Routing defines how HTTP requests are directed to specific controller actions using defined templates.
[ ]Routing must always be manually defined in Program.cs
[ ]Routing in ASP.NET Core is only configured using attribute routing
[ ]Routing in ASP.NET Core does not support parameters in the URL

---

### 4.

Question 4

A startup is choosing ASP.NET Core for its API development. They want a flexible solution where they can add features as needed. How does ASP.NET Core’s architecture help?

[ ]It prevents developers from using third-party libraries
[ ]It limits applications to a single deployment model
[x]It supports modular development, allowing features to be added incrementally

That’s correct! ASP.NET Core’s modular design lets developers add features as needed, making the framework more flexible and scalable.
[ ]It requires all features to be included at the start of development

---

### 5.

Question 5

A development team is implementing unit tests for their ASP.NET Core web API. They need a way to replace real service implementations with mock services during testing. How does dependency injection support this requirement?

[ ]It automatically generates test cases for service components
[ ]It ensures services do not change between development and production environments
[ ]It prevents circular dependencies between application services
[x]It allows mock services to be injected into components, making testing more modular and maintainable

That’s correct! Dependency injection enables developers to replace actual service implementations with mock objects, improving testability.

---

### 6.

Question 6

A company is developing a multi-tenant ASP.NET Core application. Some services, like logging, need to be shared across the entire application, while others, like user sessions, should only last for a single request. How should the team configure their dependency injection lifetimes?

[ ]Use Singleton for user session management and Transient for caching data
[ ]Use Transient for shared services, Singleton for request-based services, and Scoped for database access
[x]Singleton is best for shared services like logging, Scoped is ideal for per-request services like database contexts, and Transient is useful for stateless, lightweight operations such as formatting utilities

That’s correct! Singleton services persist across the app’s lifetime, Scoped services exist per request, and Transient services are created each time they are needed, making them useful for lightweight stateless operations.
[ ]Use Scoped for long-running background services and Singleton for per-request dependencies

---

### 7.

Question 7

An e-commerce company is developing a web API in ASP.NET Core. They need to ensure that unexpected errors, such as database failures or invalid API requests, are handled consistently across all endpoints without exposing sensitive information. What is the best approach for managing errors globally?

[ ]Store all exceptions in a static list to manually review errors later
[ ]Allow unhandled exceptions to be displayed in the API response to assist with debugging
[x]Implement middleware to catch unhandled exceptions and return structured error responses

That’s correct! Middleware can globally handle exceptions, ensuring a consistent response format while preventing sensitive data exposure.
[ ]Require each controller action to include a try-catch block for exception handling

---

### 8.

Question 8

An API team wants to ensure proper logging practices in their ASP.NET Core application. Which of the following represents a best practice for logging?

[ ]Print all log messages to the console without categorization
[ ]Store all logs directly in a database without using log levels
[ ]Disable logging in production environments to improve performance
[x]Use structured logging with built-in logging providers for consistency

That’s correct! Structured logging with built-in providers ensures better tracking and debugging.

---

### 9.

Question 9

A development team is deploying an ASP.NET Core web API to a cloud environment. They need to configure different logging levels for development and production to ensure efficient monitoring while minimizing unnecessary logs in production. Where should they define the logging level settings?

[ ]Manually specify log levels in every controller’s constructor
[ ]Use inline comments in API methods to control logging output
[x]In the appsettings.json file under the Logging section

That’s correct! The appsettings.json file allows developers to configure log levels for different environments, such as development and production.
[ ]Configure logging levels using a database table that stores log settings

---

### 10.

Question 10

A company is troubleshooting an ASP.NET Core API where authentication is not working as expected. What could be the issue with middleware ordering?

[ ]Middleware only affects application startup, not request handling
[x]Authentication middleware must be placed before authorization middleware to function correctly

That’s correct! Authentication middleware must execute before authorization to ensure the user is authenticated before checking permissions.
[ ]Middleware executes randomly, so order does not matter
[ ]Middleware must be added after defining API endpoints
