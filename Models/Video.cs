namespace VisionFlowAPI.Models
{public class Video
{
    public int Id { get; set; }
    public string FileName { get; set; } = null!;
    public string FileUrl { get; set; } = null!; // R2 URL
    public long FileSize { get; set; }
    public DateTime UploadedAt { get; set; } = DateTime.UtcNow;

    // Foreign keys
    public int UserId { get; set; }
    public User User { get; set; } = null!;

    // Analysis
    public VideoAnalysis? Analysis { get; set; }
}

}