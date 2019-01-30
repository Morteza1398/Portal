using System.Collections.Generic;

namespace EnekasEdalat.Portal.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
