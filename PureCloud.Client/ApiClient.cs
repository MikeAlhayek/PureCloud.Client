using System.Collections;
using System.Diagnostics;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using Microsoft.Extensions.Logging;
using RestSharp;

namespace PureCloud.Client;

/// <summary>
/// API client is mainly responsible for making the HTTP call to the API backend.
/// </summary>
public class ApiClient
{
    private static readonly JsonSerializerOptions _serializerOptions = new JsonSerializerOptions
    {
        TypeInfoResolver = null, // Set this only if you are using source generators or custom resolvers
        IncludeFields = false,
        DefaultIgnoreCondition = JsonIgnoreCondition.Never // Closest to MetadataPropertyHandling.Ignore

    };

    static ApiClient()
    {
        _serializerOptions.Converters.Add(new JsonStringEnumConverter());
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ApiClient" /> class
    /// with default configuration and base path (https://api.mypurecloud.com).
    /// </summary>
    public ApiClient()
    {
        // Use TLS 1.2
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

        Configuration = Configuration.Default;

        ClientOptions = new ClientRestOptions();
        ClientOptions.BaseUrl = new Uri("https://api.mypurecloud.com");
        RetryConfig = DEFAULT_RETRY_CONFIG;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ApiClient" /> class
    /// with default base path (https://api.mypurecloud.com).
    /// </summary>
    /// <param name="config">An instance of Configuration.</param>
    public ApiClient(Configuration config = null)
    {
        // Use TLS 1.2
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

        if (config == null)
        {
            Configuration = Configuration.Default;
        }
        else
        {
            Configuration = config;
        }

        ClientOptions = new ClientRestOptions
        {
            BaseUrl = new Uri("https://api.mypurecloud.com")
        };

        RetryConfig = DEFAULT_RETRY_CONFIG;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ApiClient" /> class
    /// with default configuration.
    /// </summary>
    /// <param name="basePath">The base path.</param>
    public ApiClient(string basePath = "https://api.mypurecloud.com")
    {
        // Use TLS 1.2
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

        if (string.IsNullOrEmpty(basePath))
        {
            throw new ArgumentException("basePath cannot be empty");
        }

        ClientOptions = new ClientRestOptions();
        ClientOptions.BaseUrl = new Uri(basePath);

        RetryConfig = DEFAULT_RETRY_CONFIG;
        Configuration = Configuration.Default;
    }

    /// <summary>
    /// Gets or sets the Configuration.
    /// </summary>
    /// <value>An instance of the Configuration.</value>
    public Configuration Configuration { get; set; }

    /// <summary>
    /// Gets or sets the RestClient.
    /// </summary>
    /// <value>An instance of the RestClient</value>
    private RestClient _restClient { get; set; }

    private RetryConfiguration _retryConfig;

    ///<Summary>
    /// Gets or Sets the Retry Configuration
    ///</Summary>
    public RetryConfiguration RetryConfig
    {
        get
        {
            return _retryConfig;
        }
        set
        {
            _retryConfig = value;
        }
    }

    private static readonly RetryConfiguration DEFAULT_RETRY_CONFIG = new();

    private GatewayConfiguration gatewayConfig;
    ///<Summary>
    /// Gets or Sets the Gateway Configuration
    ///</Summary>
    public GatewayConfiguration GatewayConfig
    {
        get
        {
            return gatewayConfig;
        }
        set
        {
            if (value != null)
            {
                gatewayConfig = value;
            }
            else
            {
                // Reset
                gatewayConfig = null;
            }
        }
    }

    ///<Summary>
    /// Gets the Login or the API Uri based on Configuration and Gateway COnfiguration
    ///</Summary>
    public Uri GetConfUri(string pathType, Uri baseUri)
    {
        if (pathType.Equals("login"))
        {
            if (GatewayConfig == null || string.IsNullOrEmpty(GatewayConfig.Host))
            {
                var regex = new Regex(@"://(api)\.");
                var authUrl = regex.Replace(baseUri.ToString(), "://login.");
                return new Uri(authUrl);
            }
            else
            {
                string confUrl = GatewayConfig.Protocol + "://" + GatewayConfig.Host;
                if (GatewayConfig.Port > 0)
                {
                    confUrl = confUrl + ":" + GatewayConfig.Port.ToString();
                }

                if (!string.IsNullOrEmpty(GatewayConfig.PathParamsLogin))
                {
                    if (GatewayConfig.PathParamsLogin.StartsWith("/"))
                    {
                        confUrl = confUrl + GatewayConfig.PathParamsLogin;
                    }
                    else
                    {
                        confUrl = confUrl + "/" + GatewayConfig.PathParamsLogin;
                    }
                }
                return new Uri(confUrl);
            }
        }
        else
        {
            if (GatewayConfig == null || string.IsNullOrEmpty(GatewayConfig.Host))
            {
                return baseUri;
            }
            else
            {
                string confUrl = GatewayConfig.Protocol + "://" + GatewayConfig.Host;
                if (GatewayConfig.Port > 0)
                {
                    confUrl = confUrl + ":" + GatewayConfig.Port.ToString();
                }

                if (!string.IsNullOrEmpty(GatewayConfig.PathParamsApi))
                {
                    if (GatewayConfig.PathParamsApi.StartsWith("/"))
                    {
                        confUrl = confUrl + GatewayConfig.PathParamsApi;
                    }
                    else
                    {
                        confUrl = confUrl + "/" + GatewayConfig.PathParamsApi;
                    }
                }
                return new Uri(confUrl);
            }
        }
    }

    ///<Summary>
    /// Set Gateway Configuration and credentials
    ///</Summary>
    public void SetGateway(string host,
        string protocol,
        int port,
        string pathParamsLogin,
        string pathParamsApi,
        string username,
        string password)
    {
        GatewayConfig = new GatewayConfiguration(host, protocol, port, pathParamsLogin, pathParamsApi, username, password);
    }

    ///<Summary>
    /// Set Gateway Configuration
    ///</Summary>
    public void SetGateway(string host,
        string protocol,
        int port,
        string pathParamsLogin,
        string pathParamsApi)
    {
        GatewayConfig = new GatewayConfiguration(host, protocol, port, pathParamsLogin, pathParamsApi);
    }


    // These fields are only applicable to the Code Authorization OAuth flow:
    ///<Summary>
    /// Defines if Code Authorization is used
    ///</Summary>
    public bool UsingCodeAuth { get; set; }
    ///<Summary>
    /// OAuth Client Id
    ///</Summary>
    public string ClientId { get; set; }
    ///<Summary>
    /// OUuth Client Secret
    ///</Summary>
    public string ClientSecret { get; set; }

    // Creates and sets up a RestRequest prior to a call.
    private RestRequest PrepareRequest(
        string path, RestSharp.Method method, List<Tuple<string, string>> queryParams, object postBody,
        Dictionary<string, string> headerParams, Dictionary<string, string> formParams,
        Dictionary<string, FileParameter> fileParams, Dictionary<string, string> pathParams,
        string contentType)
    {
        var request = new RestRequest(path, method);

        // add path parameter, if any
        foreach (var param in pathParams)
        {
            request.AddParameter(param.Key, param.Value, ParameterType.UrlSegment);
        }

        // add header parameter, if any
        foreach (var param in headerParams)
        {
            request.AddHeader(param.Key, param.Value);
        }

        // add query parameter, if any
        foreach (var param in queryParams)
        {
            request.AddQueryParameter(param.Item1, param.Item2);
        }

        // add form parameter, if any
        foreach (var param in formParams)
        {
            request.AddParameter(param.Key, param.Value);
        }

        // add file parameter, if any
        foreach (var param in fileParams)
        {
            request.AddFile(param.Value.Name, param.Value.GetFile, param.Value.FileName, param.Value.ContentType);
        }

        if (postBody != null) // http body (model or byte[]) parameter
        {
            if (postBody.GetType() == typeof(string))
            {
                request.AddParameter("application/json", postBody, ParameterType.RequestBody);
            }
            else if (postBody.GetType() == typeof(byte[]))
            {
                request.AddParameter(contentType, postBody, ParameterType.RequestBody);
            }
        }

        return request;
    }

    private void HandleExpiredAccessToken()
    {
        if (Monitor.TryEnter(Configuration, 0))
        {
            try
            {
                Extensions.AuthExtensions.PostToken(this, ClientId, ClientSecret, authorizationCode: Configuration.AuthTokenInfo.RefreshToken, isRefreshRequest: true);
            }
            catch (Exception e)
            {
                throw new ApiException(500, e.Message);
            }
            finally
            {
                Monitor.Exit(Configuration);
            }
        }
        else
        {
            // Abort with error if we have waited the configured time and refresh still isn't complete
            if (!Monitor.TryEnter(Configuration, TimeSpan.FromSeconds(Configuration.RefreshTokenWaitTime)))
            {
                throw new ApiException(500, $"Token refresh took longer than {Configuration.RefreshTokenWaitTime} seconds");
            }
            else
            {
                Monitor.Exit(Configuration);
            }
        }
    }

    /// <summary>
    /// Makes the HTTP request (Sync).
    /// </summary>
    /// <param name="path">URL path.</param>
    /// <param name="method">HTTP method.</param>
    /// <param name="queryParams">Query parameters.</param>
    /// <param name="postBody">HTTP body (POST request).</param>
    /// <param name="headerParams">Header parameters.</param>
    /// <param name="formParams">Form parameters.</param>
    /// <param name="fileParams">File parameters.</param>
    /// <param name="pathParams">Path parameters.</param>
    /// <param name="contentType">Content Type of the request</param>
    /// <returns>Object</returns>
    public object CallApi(
        string path, RestSharp.Method method, List<Tuple<string, string>> queryParams, object postBody,
        Dictionary<string, string> headerParams, Dictionary<string, string> formParams,
        Dictionary<string, FileParameter> fileParams, Dictionary<string, string> pathParams,
        string contentType)
    {
        var request = PrepareRequest(
            path, method, queryParams, postBody, headerParams, formParams, fileParams,
            pathParams, contentType);

        // Set SDK version
        request.AddHeader("purecloud-sdk", "231.1.0");

        Retry retry = new Retry(RetryConfig);
        RestResponse response;


        var options = new RestClientOptions(GetConfUri("api", ClientOptions.BaseUrl)) { };

        if (ClientOptions.HttpMessageHandler != null)
        {
            options = new RestClientOptions(GetConfUri("api", ClientOptions.BaseUrl))
            {
                ConfigureMessageHandler = _ => ClientOptions.HttpMessageHandler
            };

        }

        if (Configuration.UserAgent != null)
        {
            options.UserAgent = Configuration.UserAgent;
        }

        if (Configuration.Timeout > 0)
        {
            options.Timeout = TimeSpan.FromMilliseconds(Configuration.Timeout);
        }

        if (ClientOptions.Proxy != null)
        {
            options.Proxy = ClientOptions.Proxy;
        }

        _restClient = new RestClient(options);

        var fullUrl = _restClient.BuildUri(request);
        string url = fullUrl == null ? path : fullUrl.ToString();
        do
        {
            response = _restClient.Execute(request);
            Configuration.Logger.LogDebug(method.ToString(), url, postBody, (int)response.StatusCode, headerParams);
            Configuration.Logger.LogDebug(method.ToString(), url, postBody, (int)response.StatusCode, headerParams, response.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>());

        } while (retry.ShouldRetry(response));

        if (UsingCodeAuth && Configuration.ShouldRefreshAccessToken)
        {
            int statusCode = (int)response.StatusCode;
            if (statusCode == 401)
            {
                HandleExpiredAccessToken();
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
                return CallApi(path, method, queryParams, postBody, headerParams, formParams, fileParams, pathParams, contentType);
            }
        }

        if ((int)response.StatusCode < 200 || (int)response.StatusCode >= 300)
        {
            Configuration.Logger.LogError(method.ToString(), url, postBody, response.Content, (int)response.StatusCode, headerParams, response.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>());
        }

        return (object)response;
    }
    /// <summary>
    /// Makes the asynchronous HTTP request.
    /// </summary>
    /// <param name="path">URL path.</param>
    /// <param name="method">HTTP method.</param>
    /// <param name="queryParams">Query parameters.</param>
    /// <param name="postBody">HTTP body (POST request).</param>
    /// <param name="headerParams">Header parameters.</param>
    /// <param name="formParams">Form parameters.</param>
    /// <param name="fileParams">File parameters.</param>
    /// <param name="pathParams">Path parameters.</param>
    /// <param name="contentType">Content type.</param>
    /// <returns>The Task instance.</returns>
    public async Task<object> CallApiAsync(
        string path, RestSharp.Method method, List<Tuple<string, string>> queryParams, object postBody,
        Dictionary<string, string> headerParams, Dictionary<string, string> formParams,
        Dictionary<string, FileParameter> fileParams, Dictionary<string, string> pathParams,
        string contentType)
    {
        var request = PrepareRequest(
            path, method, queryParams, postBody, headerParams, formParams, fileParams,
            pathParams, contentType);

        Retry retry = new Retry(RetryConfig);
        RestResponse response;

        var options = new RestClientOptions(GetConfUri("api", ClientOptions.BaseUrl)) { };

        if (ClientOptions.HttpMessageHandler != null)
        {
            options = new RestClientOptions(GetConfUri("api", ClientOptions.BaseUrl))
            {
                ConfigureMessageHandler = _ => ClientOptions.HttpMessageHandler
            };

        }

        if (Configuration.UserAgent != null)
        {
            options.UserAgent = Configuration.UserAgent;
        }

        if (ClientOptions.Proxy != null)
        {
            options.Proxy = ClientOptions.Proxy;
        }

        if (Configuration.Timeout > 0)
        {
            options.Timeout = TimeSpan.FromMilliseconds(Configuration.Timeout);
        }

        _restClient = new RestClient(options);

        var fullUrl = _restClient.BuildUri(request);
        string url = fullUrl == null ? path : fullUrl.ToString();
        do
        {
            response = await _restClient.ExecuteAsync(request);
            Configuration.Logger.LogDebug(method.ToString(), url, postBody, (int)response.StatusCode, headerParams);
            Configuration.Logger.LogTrace(method.ToString(), url, postBody, (int)response.StatusCode, headerParams, response.Headers?
                                                         .GroupBy(header => header?.Name)
                                                         .Select(header => new
                                                         {
                                                             Name = header?.FirstOrDefault()?.Name,
                                                             Value = header.Select(x => x?.Value)?.ToList()
                                                         }).ToDictionary(header => header?.Name?.ToString(), header => string.Join(", ", header?.Value?.ToArray()))
                                                    ?? new Dictionary<string, string>());
        } while (retry.ShouldRetry(response));

        if (UsingCodeAuth && Configuration.ShouldRefreshAccessToken)
        {
            int statusCode = (int)response.StatusCode;
            if (statusCode == 401)
            {
                HandleExpiredAccessToken();
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
                return await CallApiAsync(path, method, queryParams, postBody, headerParams, formParams, fileParams, pathParams, contentType);
            }
        }

        return (object)response;
    }

    /// <summary>
    /// Escape string (url-encoded).
    /// </summary>
    /// <param name="str">String to be escaped.</param>
    /// <returns>Escaped string.</returns>
    public string EscapeString(string str)
    {
        return UrlEncode(str);
    }

    /// <summary>
    /// Create FileParameter based on Stream.
    /// </summary>
    /// <param name="name">Parameter name.</param>
    /// <param name="stream">Input stream.</param>
    /// <returns>FileParameter.</returns>
    public FileParameter ParameterToFile(string name, Stream stream)
    {
        if (stream is FileStream)
        {
            return FileParameter.Create(name, ReadAsBytes(stream), Path.GetFileName(((FileStream)stream).Name));
        }
        else
        {
            return FileParameter.Create(name, ReadAsBytes(stream), "no_file_name_provided");
        }
    }

    /// <summary>
    /// If parameter is DateTime, output in a formatted string (default ISO 8601), customizable with Configuration.DateTime.
    /// If parameter is a list, join the list with ",".
    /// Otherwise just return the string.
    /// </summary>
    /// <param name="obj">The parameter (header, path, query, form).</param>
    /// <returns>Formatted string.</returns>
    public string ParameterToString(object obj)
    {
        if (obj is DateTime)
        {
            // Return a formatted date string - Can be customized with Configuration.DateTimeFormat
            // Defaults to an ISO 8601, using the known as a Round-trip date/time pattern ("o")
            // https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8
            // For example: 2009-06-15T13:45:30.0000000
            return ((DateTime)obj).ToString(Configuration.DateTimeFormat);
        }
        else if (obj is DateTimeOffset)
        {
            // Return a formatted date string - Can be customized with Configuration.DateTimeFormat
            // Defaults to an ISO 8601, using the known as a Round-trip date/time pattern ("o")
            // https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8
            // For example: 2009-06-15T13:45:30.0000000
            return ((DateTimeOffset)obj).ToString(Configuration.DateTimeFormat);
        }
        else if (obj is IList)
        {
            var flattenedString = new StringBuilder();
            foreach (var param in (IList)obj)
            {
                if (flattenedString.Length > 0)
                {
                    flattenedString.Append(",");
                }

                flattenedString.Append(param);
            }
            return flattenedString.ToString();
        }
        else if (obj is bool)
        {
            return Convert.ToString(obj).ToLower();
        }
        else
        {
            return Convert.ToString(obj);
        }
    }

    /// <summary>
    /// Creates a restclient with a base path string input
    /// </summary>
    /// <returns>Return changed from RestClient to Void . Since no purpose to expose underlying RestClient to Consumer and 
    ///  design changed to One Restclient per API</returns>
    public void setBasePath(string basePath)
    {
        if (string.IsNullOrEmpty(basePath))
        {
            throw new ArgumentException("basePath cannot be empty");
        }

        ClientOptions.BaseUrl = new Uri(basePath);


    }
    /// <summary>
    /// Creates a restclient with a PureCloudRegionHost string input
    /// </summary>
    /// <returns>Return changed from RestClient to Void . Since no purpose to expose underlying RestClient to Consumer and 
    ///  design changed to One Restclient per API</returns>
    public void setBasePath(PureCloudRegionHosts region)
    {
        setBasePath(region.GetDescription());
    }

    /// <summary>
    /// Deserialize the JSON string into a proper object.
    /// </summary>
    /// <param name="response">The HTTP response.</param>
    /// <param name="type">Object type.</param>
    /// <returns>Object representation of the JSON string.</returns>
    public object Deserialize(RestResponse response, Type type)
    {
        IReadOnlyCollection<RestSharp.HeaderParameter> headers = response.Headers;
        if (type == typeof(byte[])) // return byte array
        {
            return response.RawBytes;
        }

        if (type == typeof(Stream))
        {
            if (headers != null)
            {
                var filePath = string.IsNullOrEmpty(Configuration.TempFolderPath)
                    ? Path.GetTempPath()
                    : Configuration.TempFolderPath;
                var regex = new Regex(@"Content-Disposition=.*filename=['""]?([^'""\s]+)['""]?$");
                foreach (var header in headers)
                {
                    var match = regex.Match(header.ToString());
                    if (match.Success)
                    {
                        string fileName = filePath + SanitizeFilename(match.Groups[1].Value.Replace("\"", "").Replace("'", ""));
                        File.WriteAllBytes(fileName, response.RawBytes);
                        return new FileStream(fileName, FileMode.Open);
                    }
                }
            }
            var stream = new MemoryStream(response.RawBytes);
            return stream;
        }

        if (type.Name.StartsWith("System.Nullable`1[[System.DateTime")) // return a datetime object
        {
            return DateTime.Parse(response.Content, null, System.Globalization.DateTimeStyles.RoundtripKind);
        }

        if (type == typeof(string) || type.Name.StartsWith("System.Nullable")) // return primitive type
        {
            return ConvertType(response.Content, type);
        }

        // at this point, it must be a model (json)
        try
        {
            return JsonSerializer.Deserialize(response.Content, type, _serializerOptions);
        }
        catch (Exception e)
        {
            throw new ApiException(500, e.Message);
        }
    }

    /// <summary>
    /// Serialize an input (model) into JSON string
    /// </summary>
    /// <param name="obj">Object.</param>
    /// <returns>JSON string.</returns>
    public string Serialize(object obj)
    {
        try
        {
            if (obj != null)
            {
                return obj is string str
                    ? str
                    : JsonSerializer.Serialize(obj, _serializerOptions);
            }
            else
            {
                return null;
            }
        }
        catch (Exception e)
        {
            throw new ApiException(500, e.Message);
        }
    }

    /// <summary>
    /// Select the Content-Type header's value from the given content-type array:
    /// if JSON exists in the given array, use it;
    /// otherwise use the first one defined in 'consumes'
    /// </summary>
    /// <param name="contentTypes">The Content-Type array to select from.</param>
    /// <returns>The Content-Type header to use.</returns>
    public string SelectHeaderContentType(string[] contentTypes)
    {
        if (contentTypes.Length == 0)
        {
            return null;
        }

        if (contentTypes.Contains("application/json", StringComparer.OrdinalIgnoreCase))
        {
            return "application/json";
        }

        return contentTypes[0]; // use the first content type specified in 'consumes'
    }

    /// <summary>
    /// Select the Accept header's value from the given accepts array:
    /// if JSON exists in the given array, use it;
    /// otherwise use all of them (joining into a string)
    /// </summary>
    /// <param name="accepts">The accepts array to select from.</param>
    /// <returns>The Accept header to use.</returns>
    public string SelectHeaderAccept(string[] accepts)
    {
        if (accepts.Length == 0)
        {
            return null;
        }

        if (accepts.Contains("application/json", StringComparer.OrdinalIgnoreCase))
        {
            return "application/json";
        }

        return string.Join(",", accepts);
    }

    /// <summary>
    /// Encode string in base64 format.
    /// </summary>
    /// <param name="text">String to be encoded.</param>
    /// <returns>Encoded string.</returns>
    public static string Base64Encode(string text)
    {
        return System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(text));
    }

    /// <summary>
    /// Dynamically cast the object into target type.
    /// Ref: http://stackoverflow.com/questions/4925718/c-dynamic-runtime-cast
    /// </summary>
    /// <param name="source">Object to be casted</param>
    /// <param name="dest">Target type</param>
    /// <returns>Casted object</returns>
    public static dynamic ConvertType(dynamic source, Type dest)
    {
        return Convert.ChangeType(source, dest);
    }

    /// <summary>
    /// Convert stream to byte array
    /// Credit/Ref: http://stackoverflow.com/a/221941/677735
    /// </summary>
    /// <param name="input">Input stream to be converted</param>
    /// <returns>Byte array</returns>
    public static byte[] ReadAsBytes(Stream input)
    {
        byte[] buffer = new byte[16 * 1024];
        using (MemoryStream ms = new MemoryStream())
        {
            int read;
            while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                ms.Write(buffer, 0, read);
            }
            return ms.ToArray();
        }
    }

    /// <summary>
    /// URL encode a string
    /// Credit/Ref: https://github.com/restsharp/RestSharp/blob/master/RestSharp/Extensions/StringExtensions.cs#L50
    /// </summary>
    /// <param name="input">String to be URL encoded</param>
    /// <returns>Byte array</returns>
    public static string UrlEncode(string input)
    {
        const int maxLength = 32766;

        if (input == null)
        {
            throw new ArgumentNullException("input");
        }

        if (input.Length <= maxLength)
        {
            return Uri.EscapeDataString(input);
        }

        StringBuilder sb = new StringBuilder(input.Length * 2);
        int index = 0;

        while (index < input.Length)
        {
            int length = Math.Min(input.Length - index, maxLength);
            string subString = input.Substring(index, length);

            sb.Append(Uri.EscapeDataString(subString));
            index += subString.Length;
        }

        return sb.ToString();
    }

    /// <summary>
    /// Sanitize filename by removing the path
    /// </summary>
    /// <param name="filename">Filename</param>
    /// <returns>Filename</returns>
    public static string SanitizeFilename(string filename)
    {
        Match match = Regex.Match(filename, @".*[/\\](.*)$");

        if (match.Success)
        {
            return match.Groups[1].Value;
        }
        else
        {
            return filename;
        }
    }

    ///<Summary>
    /// Retry Configuration class
    ///</Summary>
    public class RetryConfiguration
    {
        private long backoffIntervalMs = 300000L;
        private long retryAfterDefaultMs = 3000L;
        private int maxRetryTimeSec = 0;
        private int retryMax = 5;

        ///<Summary>
        /// BackOff Interval (Ms)
        ///</Summary>
        public long BackOffIntervalMs
        {
            get
            {
                return backoffIntervalMs;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("BackOffIntervalMs should be a positive integer");
                }
                backoffIntervalMs = value;
            }
        }

        ///<Summary>
        /// RetryAfter Default (Ms)
        ///</Summary>
        public long RetryAfterDefaultMs
        {
            get
            {
                return retryAfterDefaultMs;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("RetryAfterDefaultMs should be a positive integer");
                }
                retryAfterDefaultMs = value;
            }
        }

        ///<Summary>
        /// Max RetryTime (Sec)
        ///</Summary>
        public int MaxRetryTimeSec
        {
            get
            {
                return maxRetryTimeSec;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("MaxRetryTimeSec should be a positive integer");
                }
                maxRetryTimeSec = value;
            }
        }

        ///<Summary>
        /// Retry Max
        ///</Summary>
        public int RetryMax
        {
            get
            {
                return retryMax;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("RetryMax should be a positive integer");
                }
                retryMax = value;
            }
        }
    }

    ///<Summary>
    /// Gateway Configuration class
    ///</Summary>
    public class GatewayConfiguration
    {

        // Gateway Host
        private string host = null;

        // Gateway Protocol
        private string protocol = "https";

        // Gateway Port
        private int port = -1;

        // Gateway Path Param for Login
        private string pathParamsLogin = "";

        // Gateway Path Param for API
        private string pathParamsApi = "";

        // Gateway Username (future)
        private string username = null;

        // Gateway Password (future)
        private string password = null;

        ///<Summary>
        /// GatewayConfiguration default constructor
        ///</Summary>
        public GatewayConfiguration()
        {
            protocol = "https";
            port = -1;
            pathParamsLogin = "";
            pathParamsApi = "";
        }

        ///<Summary>
        /// GatewayConfiguration constructor with configuration and credentials
        ///</Summary>
        public GatewayConfiguration(string host,
            string protocol,
            int port,
            string pathParamsLogin,
            string pathParamsApi,
            string username,
            string password)
        {
            Host = host;
            Protocol = protocol;
            Port = port;
            PathParamsLogin = pathParamsLogin;
            PathParamsApi = pathParamsApi;
            Username = username;
            Password = password;
        }

        ///<Summary>
        /// GatewayConfiguration constructor with configuration
        ///</Summary>
        public GatewayConfiguration(string host,
            string protocol,
            int port,
            string pathParamsLogin,
            string pathParamsApi)
        {
            Host = host;
            Protocol = protocol;
            Port = port;
            PathParamsLogin = pathParamsLogin;
            PathParamsApi = pathParamsApi;
        }

        ///<Summary>
        /// Gateway Host
        ///</Summary>
        public string Host
        {
            get
            {
                return host;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    host = value;
                }
            }
        }

        ///<Summary>
        /// Gateway Protocol
        ///</Summary>
        public string Protocol
        {
            get
            {
                return protocol;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    protocol = value;
                }
                else
                {
                    protocol = "https";
                }
            }
        }

        ///<Summary>
        /// Gateway Port
        ///</Summary>
        public int Port
        {
            get
            {
                return port;
            }
            set
            {
                if (value > -1)
                {
                    port = value;
                }
                else
                {
                    port = -1;
                }
            }
        }

        ///<Summary>
        /// Gateway Path Params for Login
        ///</Summary>
        public string PathParamsLogin
        {
            get
            {
                return pathParamsLogin;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    pathParamsLogin = value;
                    if (pathParamsLogin.EndsWith("/"))
                    {
                        pathParamsLogin = pathParamsLogin.Substring(0, pathParamsLogin.Length - 1);
                    }
                }
                else
                {
                    pathParamsLogin = "";
                }
            }
        }

        ///<Summary>
        /// Gateway Path Params for Api
        ///</Summary>
        public string PathParamsApi
        {
            get
            {
                return pathParamsApi;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    pathParamsApi = value;
                    if (pathParamsApi.EndsWith("/"))
                    {
                        pathParamsApi = pathParamsApi.Substring(0, pathParamsApi.Length - 1);
                    }
                }
                else
                {
                    pathParamsApi = "";
                }
            }
        }

        ///<Summary>
        /// Username
        ///</Summary>
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    username = value;
                }
            }
        }

        ///<Summary>
        /// Password
        ///</Summary>
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    password = value;
                }
            }
        }
    }

    ///<Summary>
    /// ClientOptions
    ///</Summary>
    public ClientRestOptions ClientOptions { get; set; }
    ///<Summary>
    /// ClientRestOptions class
    ///</Summary>
    public class ClientRestOptions
    {
        ///<Summary>
        /// Base Url
        ///</Summary>
        public Uri BaseUrl { get; set; }
        private System.Net.IWebProxy proxy;
        private HttpMessageHandler httpMessageHandler;

        ///<Summary>
        /// Gets or Sets the HttpMessageHandler
        ///</Summary>
        public HttpMessageHandler HttpMessageHandler
        {
            get
            {
                return httpMessageHandler;
            }
            set
            {
                httpMessageHandler = value;
            }
        }

        ///<Summary>
        /// Gets or Sets the Proxy
        ///</Summary>
        public System.Net.IWebProxy Proxy
        {
            get
            {
                return proxy;
            }
            set
            {
                proxy = value;
            }
        }

    }

    private class Retry
    {
        private readonly long backoffIntervalMs;
        private readonly long retryAfterDefaultMs;
        private readonly int maxRetryTimeSec;
        private readonly int maxRetriesBeforeBackoff = 5;
        private int retryCountBeforeBackOff = 0;
        private readonly int retryMax = 5;
        private int retryCount;
        private long retryAfterMs;
        private readonly Stopwatch stopwatch;
        private readonly long defaultMaxRetry = 180000;

        private readonly List<int> statusCodes = new List<int>() { 429, 502, 503, 504 };

        public Retry(RetryConfiguration retryConfiguration)
        {
            backoffIntervalMs = retryConfiguration.BackOffIntervalMs;
            retryAfterDefaultMs = retryConfiguration.RetryAfterDefaultMs;
            maxRetryTimeSec = retryConfiguration.MaxRetryTimeSec;
            retryMax = retryConfiguration.RetryMax;
            stopwatch = Stopwatch.StartNew();
        }

        /// <summary>
        /// Check if retryable
        /// </summary>
        /// <param name="response">RestResponse</param>
        /// <returns>bool</returns>
        public bool ShouldRetry(RestResponse response)
        {
            if (stopwatch.ElapsedMilliseconds < maxRetryTimeSec * 1000L && statusCodes.Contains((int)response.StatusCode) && retryCount <= retryMax)
            {
                var retryAfterHeader = response.Headers
 .Select(header => new
 {
     Name = header?.Name,
     Value = header?.Value,
 })
 .FirstOrDefault(header => header.Name.ToString().Equals("Retry-After"));

                if (retryAfterHeader != null && int.TryParse(retryAfterHeader.Value.ToString(), out int retryAfterSec))
                {
                    retryAfterMs = retryAfterSec * 1000;
                }
                else
                {
                    retryAfterMs = retryAfterDefaultMs;
                }
                //If status code is 429 then wait until retry-after time and retry. OR If status code is retryable then for the first 5 times: wait until retry-after time and retry.
                if ((int)response.StatusCode == 429 || retryCountBeforeBackOff++ < maxRetriesBeforeBackoff)
                {
                    // Some APIs started sending in daily max limit breach with 429 and retry-after that can be anywhere from few minutes to hours. It is not a pausible option
                    // to retry in such scenarios. For DotNet SDK this retry Max time is set to 3 Minutes.
                    if (retryAfterMs > defaultMaxRetry)
                    {
                        return false;
                    }
                    retryCount++;
                    return waitBeforeRetry(retryAfterMs);
                }

                //If status code is 50x then wait for every 3 Sec and retry until 5 minutes then after wait for every 9 Sec and retry until next 5 minutes afterwards wait for every 27 Sec and retry.
                retryCount++;
                return waitBeforeRetry(getWaitTimeExp(Math.Min(3, Math.Floor(stopwatch.ElapsedMilliseconds / backoffIntervalMs * 1.0) + 1)));
            }
            stopwatch.Stop();
            return false;
        }

        private bool waitBeforeRetry(long retryAfterMs)
        {
            try
            {
                Thread.Sleep((int)retryAfterMs);
            }
            catch (ThreadInterruptedException)
            {
                Thread.CurrentThread.Interrupt();
            }
            return true;
        }

        private long getWaitTimeExp(double bucketCount)
        {
            return (long)Math.Pow(3, bucketCount) * 1000L;
        }
    }
}
