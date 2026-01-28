### **Activity 3: Implementing and Managing Middleware with Microsoft Copilot**

# Activity Introduction

Generative AI tools like Microsoft Copilot can help you implement and manage middleware in your back-end projects.

In this activity, you will use Copilot to create middleware for logging, authentication, and error handling and configure the middleware pipeline. This project will give you practice working with middleware, from implementation to management. Copilot can help with every step of this process.

This is the last of three activities in which you will develop and code a back-end API project. The final output will be a working API project that you can use to demonstrate your understanding of back-end development.

Before you start this activity, make sure you have completed the previous two activities in this module, "[p](https://www.coursera.org/learn/back-end-development-with-dotnet/assignment-submission/LJCC1/activity-writing-and-enhancing-api-code-with-copilot)romt.md" and [p](https://www.coursera.org/learn/back-end-development-with-dotnet/assignment-submission/JLFJp/activity-debugging-api-code-with-copilot)romt2.md"

# Activity Instructions

## Step 1: Review the scenario

To begin, review the following scenario:

To comply with corporate policies, **TechHive Solutions** requires middleware in the **User Management API** to:

* Log all incoming requests and outgoing responses for auditing purposes.
* Enforce standardized error handling across all endpoints.
* Secure API endpoints using token-based authentication.

Your task is implementing these middleware components using **Microsoft Copilot** and configuring the middleware pipeline for optimal performance.

## Step 2: Implement logging middleware

Next, start implementing middleware into your project that you’ve worked on in the previous activities.

* Use Copilot to write middleware that logs:
  * HTTP method (e.g., GET, POST).
  * Request path.
  * Response status code.
* Example Copilot prompt:*“Generate middleware to log HTTP requests and responses in ASP.NET Core.”*

## Step 3: Implement error-handling middleware

Then, create the next piece of middleware.

* Use Copilot to create middleware that:
  * Catches unhandled exceptions.
  * Return consistent error responses in JSON format (e.g., { "error": "Internal server error." }).

## Step 4: Implement authentication middleware

Next, create another middleware.

* Use Copilot to write middleware that:
  * Validates tokens from incoming requests.
  * Allows access only to users with valid tokens.
  * Returns a 401 Unauthorized response for invalid tokens.

## Step 5: Configure the middleware pipeline

With your middleware in place, make sure the middleware is configured correctly.

* Use Copilot to ensure middleware is configured in the correct order:
  * Error-handling middleware first.
  * Authentication middleware next.
  * Logging middleware last.

## Step 6: Test middleware functionality

Finally, test the code to complete this project phase.

* Test the middleware by sending various requests (e.g., valid/invalid tokens, triggering exceptions).
* Validate that logs are accurate and errors are handled consistently.

## Step 7: Save your work

By the end of this exercise, you should have middleware for logging, error handling, and authentication integrated into the User Management API and a middleware pipeline optimized for performance and security. When completed, save your work. You will submit this code project for review.
