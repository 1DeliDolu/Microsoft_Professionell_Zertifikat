
## 📝 Practice Quiz: Managing User Roles and Claims in ASP.NET Identity

### 1) Question 1

What is the first step when implementing roles and claims management in an ASP.NET application?

* [ ] Assign claims to users using the UserManager class
* [ ] Add claims directly to the AspNetUserClaims table
* [X] Use RoleManager to create roles like "Admin" or "User"
* [ ] Configure authentication schemes in the middleware

---

### 2) Question 2

How do you assign a role to a user in ASP.NET Identity?

* [ ] Use IdentityDbContext to add a role
* [ ] Use RoleManager to assign roles
* [X] Use UserManager.AddToRoleAsync method
* [ ] Use ClaimsPrincipal to grant role-based access

---

### 3) Question 3

What does claims-based authorization evaluate to grant access?

* [ ] Application configuration settings
* [ ] Middleware authentication tokens
* [X] User-specific claims stored in the AspNetUserClaims table
* [ ] Roles assigned to users through RoleManager

---

### 4) Question 4

A developer is tasked with ensuring that users in the "Admin" role and with a department claim of "IT" are properly assigned these attributes in the system, so the application can later verify their access permissions. What steps should the developer follow to assign roles and claims to users using ASP.NET Identity?

* [ ] Add the "Admin" role directly to the AspNetRoles table and configure claims in the application's middleware.
* [ ] Use IdentityDbContext to configure both roles and claims.
* [X] Create the "Admin" role using RoleManager, assign the role to users with AddToRoleAsync, and add the department claim with AddClaimAsync.
* [ ] Configure a claims-based policy and add it to the authentication middleware.

---

### 5) Question 5

A company needs to allow editors to update articles while restricting admin-only access to manage user accounts. How should they implement this?

* [ ] Assign claims to users with UserManager.AddClaimAsync and enforce restrictions using claims-based authorization policies.
* [ ] Configure access directly in the application’s middleware.
* [ ] Update the AspNetRoles and AspNetUserClaims tables directly.
* [X] Create "Editor" and "Admin" roles using RoleManager, assign roles to users with AddToRoleAsync, and configure authorization policies based on roles.
