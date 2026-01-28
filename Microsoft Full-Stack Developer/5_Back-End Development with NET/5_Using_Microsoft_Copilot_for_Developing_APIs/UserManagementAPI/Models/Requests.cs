record CreateUserRequest(string FirstName, string LastName, string Email, string? Department);

record UpdateUserRequest(string? FirstName, string? LastName, string? Email, string? Department, bool? IsActive);
