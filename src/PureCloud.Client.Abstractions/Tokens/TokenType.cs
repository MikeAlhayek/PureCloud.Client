using System.ComponentModel;

namespace PureCloud.Client.Tokens;

public enum TokenType
{
    [Description("access_token")]
    AccessToken,

    [Description("refresh_token")]
    RefreshToken,
}
