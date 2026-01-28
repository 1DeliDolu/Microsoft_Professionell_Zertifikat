using System.Collections.Concurrent;

sealed class InMemoryUserRepository : IUserRepository
{
    private readonly ConcurrentDictionary<Guid, User> _users = new();
    private static readonly StringComparer EmailComparer = StringComparer.OrdinalIgnoreCase;

    public InMemoryUserRepository()
    {
        var now = DateTimeOffset.UtcNow;
        var seed1 = new User(Guid.NewGuid(), "Ada", "Lovelace", "ada.lovelace@techhive.local", "Engineering", true, now, now);
        var seed2 = new User(Guid.NewGuid(), "Grace", "Hopper", "grace.hopper@techhive.local", "IT", true, now, now);
        _users.TryAdd(seed1.Id, seed1);
        _users.TryAdd(seed2.Id, seed2);
    }

    public IEnumerable<User> GetAll(int skip, int take) => _users.Values
        .OrderBy(u => u.LastName)
        .ThenBy(u => u.FirstName)
        .Skip(skip)
        .Take(take);

    public int Count => _users.Count;

    public User? GetById(Guid id) => _users.TryGetValue(id, out var user) ? user : null;

    public User Add(CreateUserRequest request)
    {
        var now = DateTimeOffset.UtcNow;
        var user = new User(
            Guid.NewGuid(),
            request.FirstName.Trim(),
            request.LastName.Trim(),
            request.Email.Trim(),
            NormalizeNullable(request.Department),
            true,
            now,
            now);

        _users[user.Id] = user;
        return user;
    }

    public bool Update(Guid id, UpdateUserRequest request, out User? updated)
    {
        updated = null;

        if (!_users.TryGetValue(id, out var existing))
        {
            return false;
        }

        var now = DateTimeOffset.UtcNow;
        var user = existing with
        {
            FirstName = request.FirstName is null ? existing.FirstName : request.FirstName.Trim(),
            LastName = request.LastName is null ? existing.LastName : request.LastName.Trim(),
            Email = request.Email is null ? existing.Email : request.Email.Trim(),
            Department = request.Department is null ? existing.Department : NormalizeNullable(request.Department),
            IsActive = request.IsActive ?? existing.IsActive,
            UpdatedAt = now
        };

        _users[id] = user;
        updated = user;
        return true;
    }

    public bool Delete(Guid id) => _users.TryRemove(id, out _);

    public bool EmailInUse(string email, Guid? ignoreUserId = null)
    {
        var normalized = email.Trim();
        return _users.Values.Any(user => EmailComparer.Equals(user.Email, normalized)
            && (!ignoreUserId.HasValue || user.Id != ignoreUserId.Value));
    }

    private static string? NormalizeNullable(string? value)
    {
        if (value is null)
        {
            return null;
        }

        var trimmed = value.Trim();
        return trimmed.Length == 0 ? null : trimmed;
    }
}
