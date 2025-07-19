namespace BlazorAIStorybook.Models;

public class StoryRequestModel
{
    public string? ChildName { get; set; }
    public int? ChildAge { get; set; }
    public string? Pronouns { get; set; }
    public List<string> FavoriteAnimals { get; set; } = new();
    public List<string> FavoriteColors { get; set; } = new();
    public string? FavoriteActivity { get; set; }
    public string? StoryLesson { get; set; }
    public List<string> SpecialFriendsOrFamily { get; set; } = new();
    public string? PreferredSetting { get; set; }
    public string? AvoidInStory { get; set; }
}