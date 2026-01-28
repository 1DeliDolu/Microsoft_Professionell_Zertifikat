interface IUserRepository
{
    IEnumerable<User> GetAll(int skip, int take);
    int Count { get; }
    User? GetById(Guid id);
    User Add(CreateUserRequest request);
    bool Update(Guid id, UpdateUserRequest request, out User? updated);
    bool Delete(Guid id);
    bool EmailInUse(string email, Guid? ignoreUserId = null);
}
