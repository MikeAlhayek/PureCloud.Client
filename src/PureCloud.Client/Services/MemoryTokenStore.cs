using System.Collections.Concurrent;
using PureCloud.Client.Tokens;

namespace PureCloud.Client.Services;

public class MemoryTokenStore : ITokenStore
{
    private readonly ConcurrentDictionary<TokenType, string> _tokens = [];

    public ValueTask<string> GetAsync(TokenType type)
    {
        if (_tokens.TryGetValue(type, out var token))
        {
            return ValueTask.FromResult(token);
        }

        return default;
    }

    public ValueTask<bool> SetAsync(TokenType type, string value)
    {
        ArgumentException.ThrowIfNullOrEmpty(value);

        _tokens.AddOrUpdate(type, value, (k, existingValue) => existingValue = value);

        return ValueTask.FromResult(true);
    }

    public ValueTask<bool> RemoveAsync(TokenType type)
    {
        return ValueTask.FromResult(_tokens.TryRemove(type, out _));
    }

    public ValueTask<bool> RemoveAllAsync()
    {
        var hasValues = !_tokens.IsEmpty;

        _tokens.Clear();

        return ValueTask.FromResult(hasValues);
    }
}
