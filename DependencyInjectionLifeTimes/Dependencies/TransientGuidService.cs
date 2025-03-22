namespace DependencyInjectionLifeTimes.Dependencies
{
    public class TransientGuidService:ITransientGuidService
    {
        private readonly Guid Id;
        public TransientGuidService()
        {
            Id = new Guid();
        }
        public string GetGuid()
        {
            return Id.ToString();
        }
    }
}
