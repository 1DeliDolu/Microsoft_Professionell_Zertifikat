
## 🧠 Practice Quiz: Best Practices for Implementing JWT Authentication

### 1. Soru 1

**Question 1:** Which of the following practices helps ensure secure and maintainable management of JWT signing keys?

* [ ] Embedding the secret key directly in the application’s source code
* [ ] Using a short, simple secret key for improved performance
* [ ] Sharing the secret key via email for convenience
* [X] Storing the secret key in environment variables

Storing secret keys in environment variables isolates them from the application code, improving both security and maintainability.

---

### 2. Soru 2

**Question 2:** What is an effective way to optimize JWT authentication for secure and maintainable performance in an ASP.NET Core application?

* [ ] Extending token expiration time to reduce re-authentication requests
* [ ] Using an insecure algorithm for faster token generation
* [X] Reducing token size by including only essential claims

Minimizing token size improves performance and reduces exposure by limiting the data included in JWT claims.

* [ ] Storing JWTs directly in the application code for easy retrieval

---

### 3. Soru 3

**Question 3:** A developer needs to configure JWT authentication in an ASP.NET Core application to secure API endpoints. Which of the following configurations ensures proper implementation?

* [ ] Sending JWTs over HTTP to reduce deployment complexity
* [ ] Ignoring token expiration for trusted users to simplify access
* [ ] Using hardcoded keys in the application for faster access
* [X] Configuring JwtBearer middleware to validate the token’s signature, issuer, and expiration

JwtBearer middleware validation ensures that tokens are verified for integrity, claims, and lifetime, which is critical for secure authentication.

---

### 4. Soru 4

**Question 4:** A developer is building an e-commerce application in ASP.NET Core and wants to ensure long-lasting user sessions without compromising security. What is the most secure solution?

* [ ] Embedding sensitive user data directly in JWT claims
* [ ] Storing refresh tokens in local storage for easier access
* [X] Using refresh tokens stored in HTTP-only cookies

Refresh tokens allow session longevity and are protected against XSS attacks when stored in HTTP-only cookies.

* [ ] Allowing access tokens to persist indefinitely to avoid re-authentication
