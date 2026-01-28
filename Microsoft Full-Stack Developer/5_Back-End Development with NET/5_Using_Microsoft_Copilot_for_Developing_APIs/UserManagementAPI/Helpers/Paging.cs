record PagingOptions(int Skip, int Take);

record PagedResponse<T>(IReadOnlyList<T> Items, int Total, int Skip, int Take);

static class Paging
{
    public const int DefaultTake = 50;
    public const int MaxTake = 200;

    public static PagingOptions Normalize(int? skip, int? take, out string? error)
    {
        var normalizedSkip = skip ?? 0;
        var normalizedTake = take ?? DefaultTake;

        if (normalizedSkip < 0)
        {
            error = "Skip must be 0 or greater.";
            return new PagingOptions(0, DefaultTake);
        }

        if (normalizedTake <= 0)
        {
            error = "Take must be greater than 0.";
            return new PagingOptions(normalizedSkip, DefaultTake);
        }

        if (normalizedTake > MaxTake)
        {
            error = $"Take cannot exceed {MaxTake}.";
            return new PagingOptions(normalizedSkip, MaxTake);
        }

        error = null;
        return new PagingOptions(normalizedSkip, normalizedTake);
    }
}
