namespace Service_Lifetime.SeviceLifetime
{
    public class TransientService : IMyService
    {
        private readonly Guid _id;

        public TransientService()
        {
            this._id = Guid.NewGuid();
        }

        public Guid GetId() => _id;
       
        //public Guid Id { get; } = Guid.NewGuid();
    }
}
