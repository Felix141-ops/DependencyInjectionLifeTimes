using System.Runtime.CompilerServices;

namespace DependencyInjectionLifeTimes.Dependencies
{
    public class ScopedGuidService : IScopedGuidService
    {
        private readonly Guid Id;
        public ScopedGuidService()
        {
            Id = new Guid();
        }
        public string GetGuid()
        {
            return Id.ToString();
        }
    }
}
