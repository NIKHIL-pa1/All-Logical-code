namespace Service_Lifetime.SeviceLifetime
{
    public class ScopedService : IMyService
    {
        private readonly Guid _Id;

        public ScopedService()
        {
            _Id = Guid.NewGuid();
        }

        public Guid GetId() => _Id;
    }
}
