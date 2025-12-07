namespace VisionFlowAPI.Models
{
   public class ProcessingJob
{
    public int Id { get; set; }
    public int VideoId { get; set; }
    public string HangfireJobId { get; set; } = null!;
    public string Status { get; set; } = "Queued";
    public string? ErrorMessage { get; set; }
}

}