namespace ReMind.Domain.Models;

public interface IStudyMaterial : IBaseEntity
{
    public string AppUserId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime CreatedAt { get; set; }
}
