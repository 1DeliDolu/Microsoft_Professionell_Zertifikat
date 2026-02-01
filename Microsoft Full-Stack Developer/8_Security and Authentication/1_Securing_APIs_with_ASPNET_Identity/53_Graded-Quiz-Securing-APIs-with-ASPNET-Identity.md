
### 1. Question 1

* [ ] Encrypt user session cookies to protect sensitive information.
* [ ] Perform manual database updates to assign roles.
* [ ] Validate user passwords using client-side scripts for security.
* [X] **Use ASP.NET Identity to manage user authentication, authorization, and role assignments.**

---

### 2. Question 2

* [ ] Encrypt the password using a symmetric key.
* [ ] Validate the password against complexity rules.
* [X] **Hash the password before storing it in the database to prevent exposure of plain-text passwords.**
* [ ] Store the password in a secured session.

---

### 3. Question 3

* [ ] Assign the "Admin" role through a middleware-based authentication scheme.
* [ ] Use claims-based policies instead of roles for restricting access to the dashboard.
* [X] **Use RoleManager to create the "Admin" role and assign it to the appropriate users, ensuring role-based authorization.**
* [ ] Store admin credentials directly in a configuration file for faster access.

---

### 4. Question 4

* [ ] Require users to reset their password after every login attempt.
* [ ] Use claims to store authentication factors in the database.
* [ ] Enable email notifications for failed login attempts.
* [X] **Set up multi-factor authentication to require a one-time code in addition to a password.**

---

### 5. Question 5

* [ ] Use roles to assign department-based permissions.
* [X] **Add claims to represent user-specific attributes and configure claims-based authorization policies.**
* [ ] Store user attributes in a database table without using claims.
* [ ] Create session variables to store department information.

---

### 6. Question 6

* [ ] Bind tokens to user sessions for better validation.
* [ ] Encrypt tokens with a symmetric key before sending them to clients.
* [X] **Use JSON Web Tokens (JWT) to encode user identity and permissions securely.**
* [ ] Store tokens in session cookies for client access.

---

### 7. Question 7

* [ ] Use cookies to store Facebook credentials for authentication.
* [X] **Obtain API keys from Facebook and configure them in the application’s authentication settings.**
* [ ] Write middleware to manage Facebook user sessions.
* [ ] Assign claims to Facebook users during the login process.

---

### 8. Question 8

* [ ] Use session cookies to store email confirmation tokens.
* [X] **Implement email confirmation to validate the email address before account activation.**
* [ ] Encrypt email addresses for storage in the user database.
* [ ] Automatically assign users a temporary email until confirmation.

---

### 9. Question 9

* [X] **Verify the credentials against the stored password hash and create a session upon success.**
* [ ] Compare the plain-text password directly with the database entry.
* [ ] Encrypt the credentials and store them temporarily in memory.
* [ ] Use claims to validate the user’s identity during login.

---

### 10. Question 10

* [X] **OAuth 2.0, which allows secure integration with external authentication providers.**
* [ ] Configure session variables to store Google authentication tokens.
* [ ] Use cookies to manage Google’s user sessions
* [ ] Implement OpenSSL to verify Google user credentials.
