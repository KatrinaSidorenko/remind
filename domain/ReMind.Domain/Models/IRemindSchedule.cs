namespace ReMind.Domain.Models;

public interface IRemindSchedule : IBaseEntity
{
    public string AppUserId { get; set; }
    public TimeSpan RemindTime { get; set; }
    public string TimeZone { get; set; } // todo: how to manage timezones?
}
