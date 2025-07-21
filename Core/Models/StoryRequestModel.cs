using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BlazorAIStorybook.Core.Models;

public class StoryRequestModel
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }
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