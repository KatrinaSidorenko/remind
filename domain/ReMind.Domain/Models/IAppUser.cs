namespace ReMind.Domain.Models;

public interface IAppUser : IBaseEntity
{
    public string UserName { get; set; }
    public string ChatId { get; set; }
    public string RemindScheduleId { get; set; }
}
