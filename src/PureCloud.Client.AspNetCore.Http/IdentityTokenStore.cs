using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using PureCloud.Client.Tokens;

namespace PureCloud.Client.AspNetCore.Http;

public class IdentityTokenStore<TUser> : ITokenStore
    where TUser : class
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly UserManager<TUser> _userManager;
    private readonly SignInManager<TUser> _signInManager;

    public IdentityTokenStore(
        IHttpContextAccessor httpContextAccessor,
        UserManager<TUser> userManager,
        SignInManager<TUser> signInManager)
    {
        _httpContextAccessor = httpContextAccessor;
        _userManager = userManager;
        _signInManager = signInManager;
    }

    public ValueTask<string> GetAsync(TokenType type)
    {
        var user = _httpContextAccessor.HttpContext.User;

        if (user is null || !user.Identity.IsAuthenticated)
        {
            return default;
        }

        var claimType = GetClaimType(type);

        var claim = user.Claims.FirstOrDefault(x => x.Type == claimType);

        if (claim is not null)
        {
            return ValueTask.FromResult(claim.Value);
        }

        return default;
    }

    public async ValueTask<bool> RemoveAsync(TokenType type)
    {
        var user = _httpContextAccessor.HttpContext.User;

        if (user is null || !user.Identity.IsAuthenticated || user.Identity is not ClaimsIdentity identity)
        {
            return false;
        }

        var claimType = GetClaimType(type);

        var claims = identity.Claims.Where(x => x.Type == claimType);

        if (claims.Any())
        {
            var currentUser = await _userManager.GetUserAsync(user);

            if (currentUser is null)
            {
                return false;
            }

            await _userManager.RemoveClaimsAsync(currentUser, claims);

            await _signInManager.RefreshSignInAsync(currentUser);

            return true;
        }

        return false;
    }

    public async ValueTask<bool> RemoveAllAsync()
    {
        var user = _httpContextAccessor.HttpContext.User;

        if (user is null || !user.Identity.IsAuthenticated || user.Identity is not ClaimsIdentity identity)
        {
            return false;
        }

        var currentUser = await _userManager.GetUserAsync(user);

        if (currentUser is null)
        {
            return false;
        }

        var wasRemoved = false;

        foreach (var type in Enum.GetValues<TokenType>())
        {
            var claimType = GetClaimType(type);

            var claims = identity.Claims.Where(x => x.Type == claimType);

            if (claims.Any())
            {
                wasRemoved = true;
                await _userManager.RemoveClaimsAsync(currentUser, claims);
            }
        }

        if (wasRemoved)
        {
            await _signInManager.RefreshSignInAsync(currentUser);
        }

        return wasRemoved;
    }

    public async ValueTask<bool> SetAsync(TokenType type, string value)
    {
        ArgumentException.ThrowIfNullOrEmpty(value);

        var user = _httpContextAccessor.HttpContext.User;

        if (user is null || !user.Identity.IsAuthenticated || user.Identity is not ClaimsIdentity identity)
        {
            return false;
        }

        var currentUser = await _userManager.GetUserAsync(user);

        if (currentUser is null)
        {
            return false;
        }

        var claimType = GetClaimType(type);

        var claims = identity.Claims.Where(x => x.Type == claimType);

        if (claims.Any())
        {
            await _userManager.RemoveClaimsAsync(currentUser, claims);
        }

        await _userManager.AddClaimAsync(currentUser, GetClaim(type, value));

        await _signInManager.RefreshSignInAsync(currentUser);

        return true;
    }

    private static Claim GetClaim(TokenType type, string value)
    {
        return type switch
        {
            TokenType.AccessToken => new Claim("access_token", value),
            TokenType.RefreshToken => new Claim("refresh_token", value),
            _ => new Claim(type.ToString(), value),
        };
    }

    private static string GetClaimType(TokenType type)
    {
        return type switch
        {
            TokenType.AccessToken => "access_token",
            TokenType.RefreshToken => "refresh_token",
            _ => type.ToString(),
        };
    }
}
