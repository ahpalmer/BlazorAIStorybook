using BlazorAIStorybook.Models;

namespace BlazorAIStorybook.Services
{
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
}
