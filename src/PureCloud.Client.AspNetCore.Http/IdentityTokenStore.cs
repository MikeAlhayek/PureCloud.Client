using System.Security.Claims;
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

    private SemaphoreSlim _semaphore = new SemaphoreSlim(1);

    private TUser _user;


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

        await EnsureUserLoadedAsync(principal);

        if (_user is null)
        {
            return null;
        }

        return await _userManager.GetAuthenticationTokenAsync(_user, GenesysConstants.ProviderName, tokenType.GetDescription());
    }

    public async ValueTask<bool> RemoveAllAsync()
    {
        var principal = _httpContextAccessor.HttpContext?.User;

        if (principal?.Identity is null || !principal.Identity.IsAuthenticated)
        {
            return false;
        }

        await EnsureUserLoadedAsync(principal);

        if (_user is null)
        {
            return false;
        }

        var succeeded = false;

        foreach (var tokenType in Enum.GetValues<TokenType>())
        {
            var tokenName = tokenType.GetDescription();

            var result = await _userManager.RemoveAuthenticationTokenAsync(_user, GenesysConstants.ProviderName, tokenName);

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

        await EnsureUserLoadedAsync(principal);

        if (_user is null)
        {
            return false;
        }

        var result = await _userManager.RemoveAuthenticationTokenAsync(_user, GenesysConstants.ProviderName, tokenType.GetDescription());

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

        await EnsureUserLoadedAsync(principal);

        if (_user is null)
        {
            return false;
        }

        var result = await _userManager.SetAuthenticationTokenAsync(_user, GenesysConstants.ProviderName, tokenType.GetDescription(), value);

        return result.Succeeded;
    }

    private async Task EnsureUserLoadedAsync(ClaimsPrincipal principal)
    {
        if (_user is null)
        {
            await _semaphore.WaitAsync();

            try
            {
                _user ??= await _userManager.GetUserAsync(principal);
            }
            finally
            {
                _semaphore.Release();
            }
        }
    }
}
