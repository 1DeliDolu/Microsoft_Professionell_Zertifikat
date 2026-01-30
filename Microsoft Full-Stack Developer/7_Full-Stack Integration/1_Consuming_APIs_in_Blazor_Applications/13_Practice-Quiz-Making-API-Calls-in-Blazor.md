
### 1. Soru 1

What is the first step in making a GET request in Blazor using HTTPClient?

* [ ] Adding CORS configuration to the front-end application
* [ ] Using dependency injection to configure API security
* [X] **Initializing HTTPClient in the application**
* [ ] Creating an API schema for validation

---

### 2. Soru 2

What is the purpose of fallback strategies when handling API errors in Blazor applications?

* [ ] To replace try-catch blocks for better error handling
* [X] **To ensure users see meaningful content or placeholders when API data is unavailable**
* [ ] To retry failed API calls after a network interruption
* [ ] To bypass authentication when an API fails

---

### 3. Soru 3

You are building a Blazor app to display weather data retrieved from a public API. Which of the following steps should you take to ensure the data is dynamically displayed and errors are gracefully handled?

* [ ] Serialize the API response into JSON objects and inject them directly into Blazor components
* [ ] Configure CORS settings in the app to handle failed requests
* [X] **Make a GET request, bind the response to Blazor components, and wrap the API call in a try-catch block**
* [ ] Use static methods to process all API responses for efficiency
