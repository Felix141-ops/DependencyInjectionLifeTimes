namespace DependencyInjectionLifeTimes.Dependencies
{
    public class SingletonGuidService:ISingletonGuidService
    {
        private readonly Guid Id;
        public SingletonGuidService()
        {
            Id = new Guid();
        }
        public string GetGuid()
        {
            return Id.ToString();
        }
    }
}
