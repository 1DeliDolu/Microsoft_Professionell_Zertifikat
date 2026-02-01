
### 1. Soru 1

**Question 1:** Describe the complete process of implementing JWT authentication in an ASP.NET Core application, starting from user login to securing API routes.

* [ ] Define security policies, log requests, and handle API rate limiting.
* [ ] Use OAuth 2.0 protocols exclusively for all authentication flows.
* [ ] Install third-party packages, manage sessions, and encrypt tokens.
* [X] Configure environment variables, set up middleware, issue tokens, and validate tokens on API routes.

---

### 2. Soru 2

**Question 2:** You are tasked with setting up JWT middleware in an ASP.NET Core application. What should you configure to validate tokens?

* [ ] The OnModelCreating method to enforce security constraints.
* [X] TokenValidationParameters, including IssuerSigningKey, ValidIssuer, and ValidAudience.
* [ ] TokenHandler to generate user tokens dynamically.
* [ ] ClaimsPrincipal with role-specific claims.

---

### 3. Soru 3

**Question 3:** After successful authentication, which process ensures that the user's token is valid for future requests?

* [ ] Session management using cookies.
* [ ] Claims validation in the user controller.
* [ ] Role-based policies enforced in the database.
* [X] Token validation by the middleware.

---

### 4. Soru 4

**Question 4:** A developer reports that the OnModelCreating method does not seem to enhance security. What is the most likely cause?

* [ ] The .env file was not loaded.
* [X] They did not configure unique constraints on sensitive fields like email.
* [ ] The JWT middleware is not configured properly.
* [ ] Token expiration settings were not defined.
