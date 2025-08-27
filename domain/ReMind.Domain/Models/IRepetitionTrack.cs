namespace ReMind.Domain.Models;

public interface IRepetitionTrack : IBaseEntity
{
    public string StudyMaterialId { get; set; }
    public DateTime RepetitionDateTime { get; set; }

    // todo: add status?
}
