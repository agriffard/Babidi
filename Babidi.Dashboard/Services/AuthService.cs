namespace Babidi.Dashboard.Services;

public class AuthService
{
    public bool IsAuthenticated { get; private set; } = true;

    public Task<bool> LoginAsync(string email, string password)
    {
        if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
        {
            return Task.FromResult(false);
        }

        IsAuthenticated = true;
        return Task.FromResult(true);
    }

    public Task LogoutAsync()
    {
        IsAuthenticated = false;
        return Task.CompletedTask;
    }
}
