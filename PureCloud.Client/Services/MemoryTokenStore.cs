using PureCloud.Client.Extensions;

namespace PureCloud.Client.Services;

public class MemoryTokenStore : ITokenStore
{
    private AuthTokenInfo _tokens;

    public ValueTask<AuthTokenInfo> GetAsync()
    {
        return ValueTask.FromResult(_tokens);
    }

    public ValueTask<bool> SetAsync(AuthTokenInfo info)
    {
        ArgumentNullException.ThrowIfNull(info);

        _tokens = info;

        return ValueTask.FromResult(true);
    }

    public ValueTask<bool> RemoveAsync()
    {
        _tokens = null;

        return ValueTask.FromResult(true);
    }
}
