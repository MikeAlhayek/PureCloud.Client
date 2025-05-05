namespace PureCloud.Client.Services;

public interface ITokenService
{
    ValueTask<string> GetAccessTokenAsync();

    ValueTask<string> GetRefreshTokenAsync();

    ValueTask<string> RefreshTokenAsync();
}
