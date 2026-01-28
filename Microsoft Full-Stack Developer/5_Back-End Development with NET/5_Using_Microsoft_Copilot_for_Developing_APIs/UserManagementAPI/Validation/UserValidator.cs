static class UserValidator
{
    public static string? ValidateCreate(CreateUserRequest request, IUserRepository repo)
    {
        if (string.IsNullOrWhiteSpace(request.FirstName))
        {
            return "FirstName is required.";
        }

        if (string.IsNullOrWhiteSpace(request.LastName))
        {
            return "LastName is required.";
        }

        if (string.IsNullOrWhiteSpace(request.Email))
        {
            return "Email is required.";
        }

        if (!IsEmailValid(request.Email))
        {
            return "Email is not valid.";
        }

        if (repo.EmailInUse(request.Email))
        {
            return "Email is already in use.";
        }

        return null;
    }

    public static string? ValidateUpdate(UpdateUserRequest request, IUserRepository repo, Guid userId)
    {
        if (request.FirstName is null
            && request.LastName is null
            && request.Email is null
            && request.Department is null
            && request.IsActive is null)
        {
            return "At least one field must be provided.";
        }

        if (request.FirstName is not null && string.IsNullOrWhiteSpace(request.FirstName))
        {
            return "FirstName cannot be empty.";
        }

        if (request.LastName is not null && string.IsNullOrWhiteSpace(request.LastName))
        {
            return "LastName cannot be empty.";
        }

        if (request.Department is not null && string.IsNullOrWhiteSpace(request.Department))
        {
            return "Department cannot be empty.";
        }

        if (request.Email is not null)
        {
            if (string.IsNullOrWhiteSpace(request.Email))
            {
                return "Email cannot be empty.";
            }

            if (!IsEmailValid(request.Email))
            {
                return "Email is not valid.";
            }

            if (repo.EmailInUse(request.Email, userId))
            {
                return "Email is already in use.";
            }
        }

        return null;
    }

    private static bool IsEmailValid(string email)
    {
        var at = email.IndexOf('@');
        if (at <= 0 || at != email.LastIndexOf('@'))
        {
            return false;
        }

        var dot = email.LastIndexOf('.');
        return dot > at + 1 && dot < email.Length - 1;
    }
}
