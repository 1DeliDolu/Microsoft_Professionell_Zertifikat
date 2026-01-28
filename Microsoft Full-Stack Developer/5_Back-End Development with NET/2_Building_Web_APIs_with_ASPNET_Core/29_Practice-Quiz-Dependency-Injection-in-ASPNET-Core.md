### 1.

Question 1

You are working on a large-scale web application that has many interconnected components, such as user authentication, payment processing, and notification services. One of your team members suggests using dependency injection to improve the application design. What is the primary purpose of dependency injection in ASP.NET Core?

[ ]To achieve loose coupling between components by providing dependencies externally

[ ]To simplify database connections within application components

[ ]To ensure components manage their own dependencies internally

[ ]To guarantee that all components are thread-safe by default

### 2.

Question 2

You are developing a service that logs critical events in your ASP.NET Core application. The service should only maintain one shared instance for consistency throughout the application's lifetime. When implementing dependency injection in ASP.NET Core, which method ensures that a single instance of a service is shared throughout the application's lifetime?

[ ]AddSingleton

[ ]AddScoped

[ ]AddServiceInstance

[ ]AddTransient

### 3.

Question 3

You are writing unit tests for a payment processing component in an ASP.NET Core application. The component depends on an external payment gateway service. To isolate the component and make testing faster and more reliable, you decide to use mock services.How does dependency injection simplify unit testing in ASP.NET Core?

[ ]It ensures all dependencies are automatically verified during the test

[ ]It allows components to use mock services, ensuring tests can be performed in isolation

[ ]It removes the need for test configurations

[ ]It replaces the need for integration tests by focusing solely on unit tests

### 4.

Question 4

Imagine you are tasked with building a logging service for an ASP.NET Core application. The service should generate a unique identifier for each request to help trace user activity across the system. Which service lifetime should you use to ensure a unique service instance for each request?

[ ]AddRequestSpecific

[ ]AddTransient

[ ]AddScoped

[ ]AddSingleton



### 1.

**Question 1**

You are working on a large-scale web application that has many interconnected components, such as user authentication, payment processing, and notification services. One of your team members suggests using dependency injection to improve the application design. What is the primary purpose of dependency injection in ASP.NET Core?

[x] To achieve loose coupling between components by providing dependencies externally

That’s correct! Dependency injection promotes loose coupling by ensuring components focus on their core logic rather than managing dependencies internally, making the code more maintainable and testable.
[ ] To simplify database connections within application components
[ ] To ensure components manage their own dependencies internally
[ ] To guarantee that all components are thread-safe by default

---

### 2.

**Question 2**

You are developing a service that logs critical events in your ASP.NET Core application. The service should only maintain one shared instance for consistency throughout the application's lifetime. When implementing dependency injection in ASP.NET Core, which method ensures that a single instance of a service is shared throughout the application's lifetime?

[x] AddSingleton

That’s correct! AddSingleton ensures that only one instance of the service is created and reused throughout the application's lifecycle, making it ideal for logging services.
[ ] AddScoped
[ ] AddServiceInstance
[ ] AddTransient

---

### 3.

**Question 3**

You are writing unit tests for a payment processing component in an ASP.NET Core application. The component depends on an external payment gateway service. To isolate the component and make testing faster and more reliable, you decide to use mock services. How does dependency injection simplify unit testing in ASP.NET Core?

[ ] It ensures all dependencies are automatically verified during the test
[x] It allows components to use mock services, ensuring tests can be performed in isolation

That’s correct! Dependency injection enables components to use mock services, allowing tests to focus solely on the component being tested without relying on external systems.
[ ] It removes the need for test configurations
[ ] It replaces the need for integration tests by focusing solely on unit tests

---

### 4.

**Question 4**

Imagine you are tasked with building a logging service for an ASP.NET Core application. The service should generate a unique identifier for each request to help trace user activity across the system. Which service lifetime should you use to ensure a unique service instance for each request?

[ ] AddRequestSpecific
[ ] AddTransient
[x] AddScoped

That’s correct! AddScoped creates a new service instance for each request, making it ideal for generating unique identifiers per request.
[ ] AddSingleton
