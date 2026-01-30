
### 1. Question 1

What is the process of data mapping in Blazor primarily used for?

* [ ] Ensuring type safety across API calls
* [ ] Formatting data for direct UI rendering without processing
* [ ] Optimizing network transmission of JSON data
* [X] Converting JSON into .NET objects with properties

That’s correct! Data mapping transforms raw JSON into structured .NET objects, making it usable by the application. Refer to the video Processing JSON Responses in Blazor for more information.

---

### 2. Question 2

What key benefit does state management provide when handling dynamic API data in Blazor applications?

* [ ] Encrypting API data for secure storage
* [ ] Reducing memory usage during API calls
* [X] Ensuring consistent handling of data across component updates

That’s correct! State management ensures that API data remains consistent and accessible across different component updates.

* [ ] Preloading all API data at application startup

---

### 3. Question 3

Why must the JSON structure match the data model in Blazor applications?

* [X] To successfully deserialize JSON data into .NET objects

That’s correct! JSON structure must align with the data model to enable successful deserialization and processing of API responses.

* [ ] To improve the performance of API calls
* [ ] To simplify rendering the front-end interface
* [ ] To eliminate the need for exception handling

---

### 4. Question 4

A Blazor application frequently fetches data from an API. Users report that clicking the “Fetch Data” button multiple times causes data inconsistencies. How can dynamic state management resolve this issue?

* [X] Use a CancellationTokenSource to cancel previous API calls when a new request is initiated

That’s correct! A CancellationTokenSource ensures that only the most recent API request is completed, preventing data inconsistencies caused by overlapping requests.

* [ ] Increase the API timeout duration to handle multiple simultaneous requests
* [ ] Encrypt API responses to prevent data tampering
* [ ] Preload all possible API data during application initialization
