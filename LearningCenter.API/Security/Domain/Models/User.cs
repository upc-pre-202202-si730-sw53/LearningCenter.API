using System.Text.Json.Serialization;

namespace LearningCenter.API.Security.Domain.Models;

public class User
{
    public string Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Username { get; set; }
    
    [JsonIgnore]
    public string PasswordHash { get; set; }
}