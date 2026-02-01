
## 🧾 Graded Quiz: Role-Based Access Control and JWT Authentication

### 1. Soru 1

* [X] Role assignments that align with predefined responsibilities

RBAC enforces the principle of least privilege by limiting access based on roles.

* [ ] Dynamic permissions assigned in real time based on user activity
* [ ] Directly linking user IDs to permissions for tighter control
* [ ] Unique permission sets for each user to enhance security

---

### 2. Soru 2

* [ ] The Algorithm Field
* [X] The Payload

The Payload holds claims like roles and permissions.

* [ ] The Signature
* [ ] The Header

---

### 3. Soru 3

* [ ] Use session management to store validated tokens
* [ ] Assign tokens dynamically based on user activity
* [X] Configure TokenValidationParameters with IssuerSigningKey and ValidAudience

TokenValidationParameters ensure the middleware validates token authenticity.

* [ ] Define role-based policies in the application database

---

### 4. Soru 4

* [ ] Claims are hashed for additional security
* [ ] Tokens are encrypted to prevent tampering
* [X] Middleware validates the token’s signature and expiration on each request

Middleware ensures that only requests with valid tokens are processed.

* [ ] User roles are assigned during token validation

---

### 5. Soru 5

* [ ] Use insecure algorithms to improve processing speed
* [ ] Avoid using signing keys to simplify token management
* [X] Use strong, complex signing keys stored securely in environment variables

Strong keys and secure storage reduce the risk of compromise.

* [ ] Share signing keys across all applications to streamline configuration

---

### 6. Soru 6

* [ ] They allow expired tokens to be reused temporarily
* [ ] They bypass expiration times for long-term access
* [X] They issue new access tokens without requiring reauthentication

Refresh tokens balance security and convenience.

* [ ] They store user credentials for session validation

---

### 7. Soru 7

* [ ] Enable token encryption for secure storage
* [ ] Skip expiration validation for trusted users
* [X] Use JwtBearer middleware to validate the token’s signature, issuer, and expiration

JwtBearer middleware enforces secure token validation.

* [ ] Use hardcoded keys to simplify development

---

### 8. Soru 8

* [ ] An algorithm field in the JWT header
* [ ] Encryption of the token’s payload
* [X] Validation parameters, such as IssuerSigningKey and ValidAudience

These parameters ensure only valid tokens are processed.

* [ ] A claims-based policy applied to API routes

---

### 9. Soru 9

* [ ] Decode the payload to validate permissions
* [ ] Check if the token includes user claims
* [ ] Confirm that the token is encrypted
* [X] Verify the token’s signature

Signature validation ensures the token was issued by a trusted source.

---

### 10. Soru 10

* [ ] Embed sensitive information in the token to streamline processing
* [ ] Allow tokens to persist indefinitely for user convenience
* [ ] Use a shorter signing key to speed up token generation
* [X] Include only necessary claims in the token payload

Limiting claims reduces token size and improves system performance.
