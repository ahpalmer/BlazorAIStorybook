using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BlazorAIStorybook.Core.Models;

public class StoryRequestModel
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [Required(ErrorMessage = "Every hero needs a name.")]
    [StringLength(40, ErrorMessage = "That name is a little too long for one page.")]
    public string? ChildName { get; set; }

    [Required(ErrorMessage = "How old is our hero?")]
    [Range(1, 12, ErrorMessage = "Pick an age between 1 and 12.")]
    public int? ChildAge { get; set; }

    [Required(ErrorMessage = "Choose the pronouns for the story.")]
    public string? Pronouns { get; set; }

    public List<string> FavoriteAnimals { get; set; } = new();
    public List<string> FavoriteColors { get; set; } = new();
    public string? FavoriteActivity { get; set; }

    [StringLength(120)]
    public string? StoryLesson { get; set; }

    public List<string> SpecialFriendsOrFamily { get; set; } = new();
    public string? PreferredSetting { get; set; }
    public string? AvoidInStory { get; set; }
}