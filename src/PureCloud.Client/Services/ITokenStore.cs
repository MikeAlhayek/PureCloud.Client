using PureCloud.Client.Extensions;

namespace PureCloud.Client.Services;

public interface ITokenStore
{
    ValueTask<AuthTokenInfo> GetAsync();

    ValueTask<bool> SetAsync(AuthTokenInfo info);

    ValueTask<bool> RemoveAsync();
}
