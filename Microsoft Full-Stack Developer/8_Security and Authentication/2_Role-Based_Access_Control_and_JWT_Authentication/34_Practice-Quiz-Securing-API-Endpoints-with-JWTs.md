
## 🧠 Practice Quiz: Securing API Endpoints with JWTs

### 1. Soru 1

**Question 1:** What is the primary purpose of securing API endpoints using JWTs?

* [ ] To enhance compatibility with third-party APIs
* [X] To validate requests and ensure controlled access to sensitive data

JWTs validate the authenticity of requests and control access to sensitive data.

* [ ] To prevent unauthorized users from modifying API request formats
* [ ] To generate user activity logs for auditing purposes

---

### 2. Soru 2

**Question 2:** What is the role of middleware in securing API endpoints with JWTs in ASP.NET Core?

* [ ] It defines roles and claims for token issuance
* [ ] It encrypts sensitive data in the payload of the token
* [X] It validates JWTs in incoming requests to ensure authenticity and expiration

  Middleware in ASP.NET Core validates token authenticity and expiration to enforce secure access.
* [ ] It generates new tokens for user sessions

---

### 3. Soru 3

**Question 3:** A company’s API has two routes: /admin-dashboard (Admin-only access) and /user-profile (accessible to all authenticated users). What role does role-based access control (RBAC) play in securing these routes?

* [X] It restricts access based on roles and permissions specified in token claims

Role-based access control ensures only Admin users can access the /admin-dashboard route, while the /user-profile route is open to authenticated users.

* [ ] It automatically extends token expiration for active users
* [ ] It logs unauthorized access attempts for future audits
* [ ] It validates the structure of JWTs before access is granted

---

### 4. Soru 4

**Question 4:** What is the first step in securing API endpoints using JWTs in ASP.NET Core?

* [X] Validating the token’s signature to check for tampering

Validating the token’s signature ensures its authenticity and that it has not been tampered with.

* [ ] Configuring role-based policies in the application
* [ ] Using middleware to enforce access restrictions
* [ ] Encrypting the token payload for added security

---

### 5. Soru 5

**Question 5:** A financial API requires secure access to endpoints /accounts and /transactions. How can JWT authentication and role-based access control (RBAC) be used to meet this requirement in ASP.NET Core?

* [X] Use middleware to validate JWTs, and configure RBAC policies to restrict access based on roles specified in token claims

Middleware enforces JWT validation, and RBAC policies ensure only users with appropriate roles can access the endpoints.

* [ ] Configure middleware to generate tokens dynamically based on user actions
* [ ] Create role-based policies that bypass JWT validation for certain endpoints
* [ ] Encrypt token payloads to hide sensitive data from unauthorized users
