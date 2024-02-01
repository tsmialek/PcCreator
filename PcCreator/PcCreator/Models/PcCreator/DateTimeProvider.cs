namespace PcCreator.Models.PcCreator
{
    public interface IDateTimeProvider
    {
        DateTime GetCurrentDateTime();
    }

    public class CurrentDateTimeProvider : IDateTimeProvider
    {
        public DateTime GetCurrentDateTime()
        {
            return DateTime.Now;
        }
    }
}
