
### 1. Question 1

What is the primary benefit of asynchronous programming in modern web applications?

* [ ] It enables all threads to run on separate processors
* [X] It ensures responsiveness by running tasks in the background without blocking the main thread
* [ ] It reduces the time required to process large datasets
* [ ] It ensures that tasks complete in a specific order

---

### 2. Question 2

When managing asynchronous API calls in Blazor, what is a best practice for handling loading states?

* [ ] Redirecting users to a new page while waiting for data
* [ ] Automatically retrying failed requests without user notification
* [X] Displaying a loading indicator while waiting for API responses
* [ ] Disabling all UI components during the process

---

### 3. Question 3

A developer wants to ensure that a Blazor application remains responsive while waiting for data from an API. Which keyword should the developer use to pause execution until the API call is complete without blocking the main thread?

* [ ] resolve
* [X] await
* [ ] suspend
* [ ] complete

---

### 4. Question 4

When implementing asynchronous API calls in a Blazor application, what is a best practice to ensure smooth UI updates during data loading?

* [ ] Always disable all UI components until the API call completes.
* [ ] Use synchronous API calls to reduce complexity.
* [X] Use the isLoading flag to conditionally display a loading indicator while the data is being fetched.
* [ ] Display the raw API response immediately while the data is processed in the background.
