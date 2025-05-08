namespace PureCloud.Client.Tokens;

public interface ITokenStore
{
    ValueTask<string> GetAsync(TokenType type);

    ValueTask<bool> SetAsync(TokenType type, string value);

    ValueTask<bool> RemoveAsync(TokenType type);

    ValueTask<bool> RemoveAllAsync();
}
