namespace CRM.Api
{
    public class CustomerService
    {
        private readonly DateTimeProvider _provider;

        public CustomerService(DateTimeProvider provider)
        {
            _provider = provider;
        }

        public object GetServerTime()
        {
            return new
            {
                _provider.Id,
                _provider.Now
            };
        }
    }
}
