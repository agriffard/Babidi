using Microsoft.JSInterop;

namespace Babidi.Dashboard.Services;

public class ThemeService(IJSRuntime jsRuntime)
{
    private const string DefaultTheme = "light";

    public bool IsDarkMode { get; private set; }

    public async Task InitializeAsync()
    {
        var storedTheme = await jsRuntime.InvokeAsync<string?>("themeManager.getTheme");
        IsDarkMode = string.Equals(storedTheme, "dark", StringComparison.OrdinalIgnoreCase);
        await ApplyAsync();
    }

    public async Task ToggleAsync()
    {
        IsDarkMode = !IsDarkMode;
        await ApplyAsync();
    }

    private Task ApplyAsync()
    {
        var theme = IsDarkMode ? "dark" : DefaultTheme;
        return jsRuntime.InvokeVoidAsync("themeManager.applyTheme", theme).AsTask();
    }
}
