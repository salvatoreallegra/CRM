namespace CRM.Api
{
    public class DateTimeProvider
    {
        public Guid Id { get; } = Guid.NewGuid();
        public DateTime Now => DateTime.Now;

    }
}
