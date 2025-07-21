namespace BlazorAIStorybook.Core.Models;

public class HeroProfile
{
    private string _heroName;
    private string _hairColor;
    private string _eyeColor;

    public string? HeroName { get; set; }
    public string? HairColor { get; set; }
    public string? EyeColor { get; set; }

    public HeroProfile(string heroName,
        string hairColor,
        string eyeColor)
    {
        _heroName = heroName;
        _hairColor = hairColor;
        _eyeColor = eyeColor;
    }
}
