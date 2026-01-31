
### 1) Question 1

A full-stack e-commerce application has inconsistent behavior, such as losing cart items during navigation. How can state management solve this issue?

* [X] By ensuring application state is tracked and synchronized across user interactions
* [ ] By handling only static data updates for all users.
* [ ] By storing all session data on the client-side only.
* [ ] By resetting the application’s global state after each request.

---

### 2) Question 2

A shopping cart application stores cart items temporarily during navigation but loses them upon browser refresh. Which storage mechanism should be used?

* [X] Implement local storage to persist cart data across browser sessions
* [ ] Store cart data in cookies to automatically synchronize with the server.
* [ ] Use caching mechanisms to retain data temporarily during refresh.
* [ ] Use session storage to keep cart data only during navigation.

---

### 3) Question 3

A web application frequently experiences errors where users lose progress during form submissions. Which state management technique prevents this issue?

* [ ] Cache all user data to minimize server load.
* [ ] Implement local storage to persist data across sessions.
* [ ] Store all form data permanently in a database after each step.
* [X] Use session state to retain user data temporarily during the session

---

### 4) Question 4

During high traffic, a news app experiences delays in retrieving frequently viewed articles. How can caching resolve this issue?

* [ ] Save articles in the client’s session storage for quicker access.
* [X] Store frequently accessed articles in memory for faster retrieval
* [ ] Use cookies to store article content for offline use.
* [ ] Synchronize data requests across multiple servers.

---

### 5) Question 5

What role does SignalR play in enabling real-time communication in web applications?

* [X] It simplifies client-server communication by managing transport protocols and ensuring compatibility
* [ ] It reduces the need for server-side processing in real-time apps.
* [ ] It compresses all real-time data for faster transmission.
* [ ] It replaces WebSockets entirely in real-time applications.

---

### 6) Question 6

A large web application faces challenges maintaining code as new features are added. How can separation of concerns resolve this?

* [X] By organizing application logic into distinct modules such as state management, UI, and backend
* [ ] By using global state for all application components.
* [ ] By consolidating all logic into a single, centralized state handler.
* [ ] By relying on caching to handle redundant operations.

---

### 7) Question 7

How does performance optimization improve state management in web applications?

* [ ] By encrypting state data to ensure secure storage.
* [ ] By using stateless sessions for improved reliability.
* [ ] By centralizing state across all components.
* [X] By minimizing redundant updates and caching frequently used data for faster access

---

### 8) Question 8

A real-time collaboration tool experiences inconsistencies when multiple users edit the same document. How does synchronization resolve this?

* [ ] By storing all changes in local storage for offline editing.
* [ ] By saving all updates directly to the database in real time.
* [X] By ensuring updates are shared instantly across clients, maintaining consistency
* [ ] By relying on cookies to track edits across users.

---

### 9) Question 9

What is the role of conflict resolution in shared state management?

* [X] It prevents overlapping updates by detecting and resolving inconsistencies
* [ ] It caches conflicting updates for future processing.
* [ ] It synchronizes all updates through client-side storage.
* [ ] It encrypts data for secure transmission.

---

### 10) Question 10

Why is testing state updates critical in client-server synchronization?

* [X] To verify that state changes propagate accurately and efficiently across all components
* [ ] To eliminate the need for conflict resolution mechanisms.
* [ ] To encrypt all updates for secure transmission.
* [ ] To automate all state updates without validation.
