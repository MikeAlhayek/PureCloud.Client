using System.Collections.Concurrent;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using PureCloud.Client.Tokens;

namespace PureCloud.Client.AspNetCore.Http;

public class InMemoryTokenStore : ITokenStore
{
    private readonly ConcurrentDictionary<string, ConcurrentDictionary<TokenType, string>> _tokens = [];

    private readonly IHttpContextAccessor _httpContextAccessor;

    public InMemoryTokenStore(
        IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public ValueTask<string> GetAsync(TokenType type)
    {
        var user = _httpContextAccessor.HttpContext.User;

        if (user is null || !user.Identity.IsAuthenticated)
        {
            return default;
        }

        if (_tokens.TryGetValue(user.Identity.Name, out var tokens) && tokens.TryGetValue(type, out var token))
        {
            return ValueTask.FromResult(token);
        }

        return default;
    }

    public ValueTask<bool> RemoveAsync(TokenType type)
    {
        var user = _httpContextAccessor.HttpContext.User;

        if (user is null || !user.Identity.IsAuthenticated || user.Identity is not ClaimsIdentity identity)
        {
            return ValueTask.FromResult(false);
        }

        if (_tokens.TryGetValue(user.Identity.Name, out var tokens))
        {
            return ValueTask.FromResult(tokens.TryRemove(type, out var _));
        }

        return ValueTask.FromResult(false);
    }

    public ValueTask<bool> RemoveAllAsync()
    {
        var user = _httpContextAccessor.HttpContext.User;

        if (user is null || !user.Identity.IsAuthenticated || user.Identity is not ClaimsIdentity identity)
        {
            return ValueTask.FromResult(false);
        }

        return ValueTask.FromResult(_tokens.TryRemove(user.Identity.Name, out _));
    }

    public ValueTask<bool> SetAsync(TokenType type, string value)
    {
        ArgumentException.ThrowIfNullOrEmpty(value);

        var user = _httpContextAccessor.HttpContext.User;

        if (user is null || !user.Identity.IsAuthenticated || user.Identity is not ClaimsIdentity identity)
        {
            return ValueTask.FromResult(false);
        }

        _tokens.AddOrUpdate(
            user.Identity.Name,
            key => new ConcurrentDictionary<TokenType, string>
            {
                [type] = value
            },
            (key, existingToken) =>
            {
                existingToken.AddOrUpdate(type, value, (_, _) => value);

                return existingToken;
            });

        return ValueTask.FromResult(true);
    }
}
