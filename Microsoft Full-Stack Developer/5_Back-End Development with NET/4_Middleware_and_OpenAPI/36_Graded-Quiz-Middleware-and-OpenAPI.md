
### 1.

**Question 1**
Imagine you are implementing middleware for an ASP.NET Core application. How should you structure it for a seamless request-response cycle?

[ ]Allow middleware to skip requests that don’t meet certain criteria
[ ]Use middleware exclusively for handling exceptions and errors
[x]Chain middleware components in the order they are added so each one can process and pass requests or responses
[ ]Place critical middleware at random points in the pipeline for faster processing

---

### 2.

**Question 2**
While evaluating an ASP.NET Core application, how does middleware improve modularity in the design?

[ ]Middleware centralizes all logic into a single configuration file to simplify maintenance
[ ]Middleware requires every component to depend on the previous one, reducing flexibility
[ ]Middleware is designed to operate only on data-related tasks, limiting modularity
[x]Middleware allows developers to break down tasks into discrete components, making the pipeline flexible and maintainable

---

### 3.

**Question 3**
What is the key difference between using built-in middleware and developing custom middleware in ASP.NET Core?

[ ]Built-in middleware requires manual registration, while custom middleware is automatically included
[ ]Built-in middleware is always faster than custom middleware
[x]Built-in middleware addresses generic tasks, whereas custom middleware allows developers to implement specific behaviors
[ ]Built-in middleware replaces the need for routing, while custom middleware handles errors

---

### 4.

**Question 4**
How would you design custom middleware to log the time taken to process an HTTP request in an ASP.NET Core application?

[ ]Use built-in middleware to handle all logging needs automatically
[ ]Implement a middleware component that skips logging if the request is already authenticated
[x]Create a middleware component that records the start time, processes the request, then calculates and logs the duration
[ ]Add a logging library to your project instead of creating custom middleware

---

### 5.

**Question 5**
Why is integrating OpenAPI (Swagger) beneficial in an ASP.NET Core application?

[ ]It replaces the need for routing middleware in ASP.NET Core applications
[ ]It eliminates the need for manual debugging of middleware components
[x]It improves API documentation and testing, making APIs easier to use and maintain
[ ]It automatically optimizes API performance without additional code

---

### 6.

**Question 6**
What approach should you take to generate API clients using Swagger in ASP.NET Core?

[ ]Write a custom middleware component to dynamically generate client libraries
[x]Use tools provided by Swagger to automatically generate client libraries from the OpenAPI specification
[ ]Use Swagger exclusively for API documentation and avoid client generation
[ ]Manually write all API client libraries based on the endpoint documentation

---

### 7.

**Question 7**
You are tasked with improving the performance of an ASP.NET Core application. How would you identify bottlenecks in the middleware pipeline?

[ ]Prioritize custom middleware over built-in middleware for all functionality
[ ]Skip processing certain requests to reduce overall pipeline execution time
[x]Evaluate the time each middleware component takes to process requests and focus on optimizing slower components
[ ]Reduce the number of middleware components in the pipeline to eliminate delays

---

### 8.

**Question 8**
A team is generating an API client using Swagger but only wants to include user-related endpoints. How can they ensure only the required endpoints are generated?

[x]Adjust the OpenAPI specification to define only the necessary endpoints
[ ]Add middleware to block unwanted endpoints during client generation
[ ]Generate a full API client and manually edit the resulting code
[ ]Use a separate Swagger configuration file to dynamically filter endpoints

---

### 9.

**Question 9**
What is a best practice for securing middleware in an ASP.NET Core application?

[ ]Use only authorization middleware and skip authentication middleware
[ ]Use custom middleware for security tasks instead of built-in middleware
[x]Add authentication and authorization middleware at the start of the pipeline to protect resources
[ ]Allow all requests to pass through middleware before applying security policies

---

### 10.

**Question 10**
How can you determine whether a custom middleware component is functioning effectively?

[ ]Ensure the middleware skips processing certain requests to save time
[x]Measure its processing time and ensure it integrates seamlessly with other pipeline components
[ ]Avoid profiling middleware performance during production to minimize overhead
[ ]Test only its standalone functionality without considering pipeline interactions
