using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using PureCloud.Client.Extensions;
using PureCloud.Client.Tokens;

namespace PureCloud.Client.AspNetCore.Http;

public class IdentityTokenStore<TUser> : ITokenStore
    where TUser : class
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly UserManager<TUser> _userManager;

    public IdentityTokenStore(
        IHttpContextAccessor httpContextAccessor,
        UserManager<TUser> userManager)
    {
        _httpContextAccessor = httpContextAccessor;
        _userManager = userManager;
    }

    public async ValueTask<string> GetAsync(TokenType tokenType)
    {
        var principal = _httpContextAccessor.HttpContext?.User;

        if (principal?.Identity is null || !principal.Identity.IsAuthenticated)
        {
            return null;
        }

        var user = await _userManager.GetUserAsync(principal);

        if (user is null)
        {
            return null;
        }

        return await _userManager.GetAuthenticationTokenAsync(user, GenesysConstants.ProviderName, tokenType.GetDescription());
    }

    public async ValueTask<bool> RemoveAllAsync()
    {
        var principal = _httpContextAccessor.HttpContext?.User;

        if (principal?.Identity is null || !principal.Identity.IsAuthenticated)
        {
            return false;
        }

        var user = await _userManager.GetUserAsync(principal);

        if (user is null)
        {
            return false;
        }

        var succeeded = false;

        foreach (var tokenType in Enum.GetValues<TokenType>())
        {
            var tokenName = tokenType.GetDescription();

            var result = await _userManager.RemoveAuthenticationTokenAsync(user, GenesysConstants.ProviderName, tokenName);

            if (result.Succeeded)
            {
                succeeded = true;
            }
        }

        return succeeded;
    }

    public async ValueTask<bool> RemoveAsync(TokenType tokenType)
    {
        var principal = _httpContextAccessor.HttpContext?.User;

        if (principal?.Identity is null || !principal.Identity.IsAuthenticated)
        {
            return false;
        }

        var user = await _userManager.GetUserAsync(principal);

        if (user is null)
        {
            return false;
        }

        var result = await _userManager.RemoveAuthenticationTokenAsync(user, GenesysConstants.ProviderName, tokenType.GetDescription());

        return result.Succeeded;
    }

    public async ValueTask<bool> SetAsync(TokenType tokenType, string value)
    {
        ArgumentException.ThrowIfNullOrEmpty(value);

        var principal = _httpContextAccessor.HttpContext?.User;

        if (principal?.Identity is null || !principal.Identity.IsAuthenticated)
        {
            return false;
        }

        var user = await _userManager.GetUserAsync(principal);

        if (user is null)
        {
            return false;
        }

        var result = await _userManager.SetAuthenticationTokenAsync(user, GenesysConstants.ProviderName, tokenType.GetDescription(), value);

        return result.Succeeded;
    }
}
