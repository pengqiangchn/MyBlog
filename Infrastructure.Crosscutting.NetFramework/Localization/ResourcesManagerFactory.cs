
using Infrastructure.Crosscutting.Localization;

namespace Infrastructure.Crosscutting.NetFramework.Localization
{
    public class ResourcesManagerFactory : ILocalizationFactory
    {
        public ILocalization Create()
        {
            return new ResourcesManager();
        }
    }
}
