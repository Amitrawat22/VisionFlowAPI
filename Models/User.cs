

namespace VisionFlowAPI.Models
{
    public class User
{
    public int Id { get; set; }
    public string Username { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string PasswordHash { get; set; } = null!;
    public string Role { get; set; } = "User"; // "Admin" / "User"

    // Relations
    public List<Video> Videos { get; set; } = [];
}

}