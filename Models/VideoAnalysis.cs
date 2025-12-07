namespace VisionFlowAPI.Models
{
    public class VideoAnalysis
    {
        public int Id { get; set; }

        // FK
        public int VideoId { get; set; }
        public Video Video { get; set; } = null!;

        public string Status { get; set; } = "Pending"; 
        // Pending, Processing, Completed, Failed

        // Store results as JSON
        public string ResultsJson { get; set; } = "{}";

        public DateTime StartedAt { get; set; } = DateTime.UtcNow;
        public DateTime? CompletedAt { get; set; }
    }

}