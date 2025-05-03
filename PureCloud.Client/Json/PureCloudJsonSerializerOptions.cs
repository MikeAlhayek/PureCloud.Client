using System.Text.Json;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Json;

public class PureCloudJsonSerializerOptions
{
    public JsonSerializerOptions JsonSerializerOptions { get; }

    public PureCloudJsonSerializerOptions()
    {
        JsonSerializerOptions = new JsonSerializerOptions()
        {
            TypeInfoResolver = null, // Set this only if you are using source generators or custom resolvers
            IncludeFields = false,
            DefaultIgnoreCondition = JsonIgnoreCondition.Never, // Closest to MetadataPropertyHandling.Ignore
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            Converters =
            {
                new JsonStringEnumConverter(),
                new JsonStringEnumMemberConverterFactory(),
            }
        };
    }
}
