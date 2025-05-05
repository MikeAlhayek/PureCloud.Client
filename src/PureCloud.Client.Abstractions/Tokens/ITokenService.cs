namespace PureCloud.Client.Tokens;

public interface ITokenService
{
    ValueTask<string> GetAccessTokenAsync();

    ValueTask<string> GetRefreshTokenAsync();

    ValueTask<string> RefreshTokenAsync();
}
