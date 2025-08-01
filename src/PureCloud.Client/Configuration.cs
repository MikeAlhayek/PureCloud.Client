using Microsoft.Extensions.Logging;
using PureCloud.Client.Extensions;
using PureCloud.Client.Tokens;

namespace PureCloud.Client;

/// <summary>
/// Represents a set of configuration settings
/// </summary>
public class Configuration
{
    /// <summary>
    /// Initializes a new instance of the Configuration class with different settings
    /// </summary>
    /// <param name="apiClient">Api client</param>
    /// <param name="defaultHeader">Dictionary of default HTTP header</param>
    /// <param name="username">Username</param>
    /// <param name="password">Password</param>
    /// <param name="accessToken">accessToken</param>
    /// <param name="apiKey">Dictionary of API key</param>
    /// <param name="apiKeyPrefix">Dictionary of API key prefix</param>
    /// <param name="tempFolderPath">Temp folder path</param>
    /// <param name="dateTimeFormat">DateTime format string</param>
    /// <param name="timeout">HTTP connection timeout (in milliseconds)</param>
    /// <param name="shouldRefreshAccessToken">ShouldRefreshAccessToken</param>
    /// <param name="refreshTokenWaitTime">Refresh token wait time in seconds</param>
    /// <param name="userAgent">HTTP user agent</param>
    /// <param name="configFilePath">Config file path</param>
    /// <param name="autoReloadConfig">AutoReloadConfig</param>
    /// <param name="useDefaultApiClient">Use Default ApiClient</param>
    public Configuration(ApiClient apiClient = null,
                         Dictionary<string, string> defaultHeader = null,
                         string username = null,
                         string password = null,
                         string accessToken = null,
                         Dictionary<string, string> apiKey = null,
                         Dictionary<string, string> apiKeyPrefix = null,
                         string tempFolderPath = null,
                         string dateTimeFormat = null,
                         int timeout = 100000,
                         bool shouldRefreshAccessToken = true,
                         int refreshTokenWaitTime = 10,
                         string userAgent = "PureCloudEnvironment SDK/dotnet",
                         bool useDefaultApiClient = true
                        )
    {
        if (useDefaultApiClient == true)
        {
            SetApiClientUsingDefault(apiClient);
        }
        else
        {
            SetApiClient(apiClient);
        }

        Username = username;
        Password = password;
        AuthTokenInfo = new AuthTokenInfo();
        AccessToken = accessToken;
        UserAgent = userAgent;

        if (defaultHeader != null)
        {
            DefaultHeader = defaultHeader;
        }

        if (apiKey != null)
        {
            ApiKey = apiKey;
        }

        if (apiKeyPrefix != null)
        {
            ApiKeyPrefix = apiKeyPrefix;
        }

        TempFolderPath = tempFolderPath;
        DateTimeFormat = dateTimeFormat;
        Timeout = timeout;
        ShouldRefreshAccessToken = shouldRefreshAccessToken;
        RefreshTokenWaitTime = refreshTokenWaitTime;
    }

    /// <summary>
    /// Initializes a new instance of the Configuration class.
    /// </summary>
    /// <param name="apiClient">Api client.</param>
    public Configuration(ApiClient apiClient)
    {
        SetApiClientUsingDefault(apiClient);
    }

    /// <summary>
    /// Version of the package.
    /// </summary>
    /// <value>Version of the package.</value>
    public const string Version = "1.0.0";

    /// <summary>
    /// Gets or sets the default Configuration.
    /// </summary>
    /// <value>Configuration.</value>
    public static Configuration Default = new();

    /// <summary>
    /// Gets or sets the HTTP timeout (milliseconds) of ApiClient. Default to 100000 milliseconds.
    /// </summary>
    /// <value>Timeout.</value>
    public int Timeout { get; set; }

    /// <summary>
    /// Gets or sets the default API client for making HTTP calls.
    /// </summary>
    /// <value>The API client.</value>
    public ApiClient ApiClient;

    /// <summary>
    /// Set the ApiClient using Default or ApiClient instance.
    /// </summary>
    /// <param name="apiClient">An instance of ApiClient.</param>
    /// <returns></returns>
    public void SetApiClientUsingDefault(ApiClient apiClient = null)
    {
        AuthTokenInfo = new AuthTokenInfo();
        if (apiClient == null)
        {
            if (Default != null && Default.ApiClient == null)
            {
                Default.ApiClient = new ApiClient(this);
            }

            ApiClient = Default != null ? Default.ApiClient : new ApiClient(this);
        }
        else
        {
            if (Default != null && Default.ApiClient == null)
            {
                Default.ApiClient = apiClient;
            }

            ApiClient = apiClient;
        }
    }

    /// <summary>
    /// Set or create the ApiClient.
    /// </summary>
    /// <param name="apiClient">An instance of ApiClient.</param>
    /// <returns></returns>
    public void SetApiClient(ApiClient apiClient = null)
    {
        AuthTokenInfo = new AuthTokenInfo();
        if (apiClient == null)
        {
            ApiClient = new ApiClient(this);
        }
        else
        {
            ApiClient = apiClient;
            ApiClient.Configuration = this;
        }
    }

    private Dictionary<string, string> _defaultHeaderMap = new Dictionary<string, string>();

    /// <summary>
    /// Gets or sets the default header.
    /// </summary>
    public Dictionary<string, string> DefaultHeader
    {
        get { return _defaultHeaderMap; }

        set
        {
            _defaultHeaderMap = value;
        }
    }

    /// <summary>
    /// Add default header.
    /// </summary>
    /// <param name="key">Header field name.</param>
    /// <param name="value">Header field value.</param>
    /// <returns></returns>
    public void AddDefaultHeader(string key, string value)
    {
        _defaultHeaderMap.Add(key, value);
    }

    /// <summary>
    /// Gets or sets the HTTP user agent.
    /// </summary>
    /// <value>Http user agent.</value>
    public string UserAgent { get; set; }

    /// <summary>
    /// Gets or sets the username (HTTP basic authentication).
    /// </summary>
    /// <value>The username.</value>
    public string Username { get; set; }

    /// <summary>
    /// Gets or sets the password (HTTP basic authentication).
    /// </summary>
    /// <value>The password.</value>
    public string Password { get; set; }

    /// <summary>
    /// Gets or sets the AuthTokenInfo for OAuth2 authentication.
    /// </summary>
    /// <value>The access token.</value>
    public AuthTokenInfo AuthTokenInfo { get; set; }

    /// <summary>
    /// Gets or sets the access token for OAuth2 authentication.
    /// </summary>
    /// <value>The access token.</value>
    public string AccessToken
    {
        get
        {
            return AuthTokenInfo.AccessToken;
        }

        set
        {
            AuthTokenInfo.AccessToken = value;
        }
    }

    /// <summary>
    /// Gets or sets the flag to indicate whether the access token should be refreshed transparently when using the Code Authorization flow.
    /// </summary>
    /// <value>The access token transparent refresh flag.</value>
    public bool ShouldRefreshAccessToken { get; set; }

    /// <summary>
    /// The amount of time other threads will wait for a thread to request a new access token when it expires.
    /// </summary>
    /// <value>The access token transparent refresh flag.</value>
    public int RefreshTokenWaitTime { get; set; }

    /// <summary>
    /// Gets or sets the API key based on the authentication name.
    /// </summary>
    /// <value>The API key.</value>
    public Dictionary<string, string> ApiKey = new Dictionary<string, string>();

    /// <summary>
    /// Gets or sets the prefix (e.g. Token) of the API key based on the authentication name.
    /// </summary>
    /// <value>The prefix of the API key.</value>
    public Dictionary<string, string> ApiKeyPrefix = new Dictionary<string, string>();

    /// <summary>
    /// Get the API key with prefix.
    /// </summary>
    /// <param name="apiKeyIdentifier">API key identifier (authentication scheme).</param>
    /// <returns>API key with prefix.</returns>
    public string GetApiKeyWithPrefix(string apiKeyIdentifier)
    {
        ApiKey.TryGetValue(apiKeyIdentifier, out var apiKeyValue);
        if (ApiKeyPrefix.TryGetValue(apiKeyIdentifier, out var apiKeyPrefix))
        {
            return apiKeyPrefix + " " + apiKeyValue;
        }
        else
        {
            return apiKeyValue;
        }
    }

    private string _tempFolderPath = Path.GetTempPath();

    /// <summary>
    /// Gets or sets the temporary folder path to store the files downloaded from the server.
    /// </summary>
    /// <value>Folder path.</value>
    public string TempFolderPath
    {
        get { return _tempFolderPath; }

        set
        {
            if (string.IsNullOrEmpty(value))
            {
                _tempFolderPath = value;
                return;
            }

            // create the directory if it does not exist
            if (!Directory.Exists(value))
            {
                Directory.CreateDirectory(value);
            }

            // check if the path contains directory separator at the end
            if (value[value.Length - 1] == Path.DirectorySeparatorChar)
            {
                _tempFolderPath = value;
            }
            else
            {
                _tempFolderPath = value + Path.DirectorySeparatorChar;
            }
        }
    }

    private const string ISO8601_DATETIME_FORMAT = "o";

    private string _dateTimeFormat = ISO8601_DATETIME_FORMAT;

    /// <summary>
    /// Gets or sets the the date time format used when serializing in the ApiClient
    /// By default, it's set to ISO 8601 - "o", for others see:
    /// https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx
    /// and https://msdn.microsoft.com/en-us/library/8kb3ddd4(v=vs.110).aspx
    /// No validation is done to ensure that the string you're providing is valid
    /// </summary>
    /// <value>The DateTimeFormat string</value>
    public string DateTimeFormat
    {
        get
        {
            return _dateTimeFormat;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                // Never allow a blank or null string, go back to the default
                _dateTimeFormat = ISO8601_DATETIME_FORMAT;
                return;
            }

            // Caution, no validation when you choose date time format other than ISO 8601
            // Take a look at the above links
            _dateTimeFormat = value;
        }
    }

    /// <summary>
    /// Gets or sets the Logger.
    /// </summary>
    /// <value>Instance of Logger.</value>
    public ILogger Logger { get; set; }
}
