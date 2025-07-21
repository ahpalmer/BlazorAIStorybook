using BlazorAIStorybook.Core.Models;

namespace BlazorAIStorybook.Core.Services;

public class HeroProfileService
{
    private HeroProfile? _currentHero;

    public HeroProfile? CurrentHero
    {
        get => _currentHero;
        set
        {
            _currentHero = value;
            NotifyStateChanged();
        }
    }

    public event Action? OnChange;

    private void NotifyStateChanged() => OnChange?.Invoke();
}
