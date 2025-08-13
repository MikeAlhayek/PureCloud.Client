using System.Collections;
using System.Collections.Specialized;
using System.Text;
using System.Web;

namespace PureCloud.Client.Http;

public static class UriHelper
{
    private const string ISO8601_DATETIME_FORMAT = "o";

    public static string GetUri(string uri, NameValueCollection parameters)
    {
        var builder = new UriBuilder(uri);
        var query = HttpUtility.ParseQueryString(builder.Query);

        if (parameters is not null)
        {
            foreach (var key in parameters.AllKeys)
            {
                query.Add(key, parameters[key]);
            }
        }

        builder.Query = query.ToString();
        return builder.Uri.ToString();
    }

    public static string ParameterToString(object obj)
    {
        if (obj is DateTime)
        {
            // Return a formatted date string - Can be customized with Configuration.DateTimeFormat
            // Defaults to an ISO 8601, using the known as a Round-trip date/time pattern ("o")
            // https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8
            // For example: 2009-06-15T13:45:30.0000000
            return ((DateTime)obj).ToString(ISO8601_DATETIME_FORMAT);
        }

        if (obj is DateTimeOffset)
        {
            // Return a formatted date string - Can be customized with Configuration.DateTimeFormat
            // Defaults to an ISO 8601, using the known as a Round-trip date/time pattern ("o")
            // https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8
            // For example: 2009-06-15T13:45:30.0000000
            return ((DateTimeOffset)obj).ToString(ISO8601_DATETIME_FORMAT);
        }

        if (obj is IEnumerable collection)
        {
            var flattenedString = new StringBuilder();
            foreach (var param in collection)
            {
                if (flattenedString.Length > 0)
                {
                    flattenedString.Append(',');
                }

                flattenedString.Append(param);
            }
            return flattenedString.ToString();
        }

        if (obj is bool)
        {
            return Convert.ToString(obj).ToLowerInvariant();
        }

        return Convert.ToString(obj);
    }
}
