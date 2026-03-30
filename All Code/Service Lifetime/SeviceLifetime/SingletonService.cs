namespace Service_Lifetime.SeviceLifetime
{
    public class SingletonService : IMyService
    {
        private readonly Guid _guid;

        public SingletonService()
        {
            _guid = Guid.NewGuid();
        }

        public Guid GetId() => _guid;
    }
}
