using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Action function settings.
/// </summary>

public partial class Function : IEquatable<Function>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="Function" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Function() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Function" /> class.
    /// </summary>
    /// <param name="Description">Description of the function. Limit 255 characters. (required).</param>
    /// <param name="Handler">Handler entry point into zip file to execute function. Should be path within upload function package to the invocation module without language extension, followed by a period and then exported invocation method name. e.g. &#39;src/index.handler&#39; (required).</param>
    /// <param name="Runtime">Runtime required for execution. Valid runtimes change over time as versions are deprecated. Use /api/v2/integrations/actions/functions/runtimes for current list. (required).</param>
    /// <param name="TimeoutSeconds">Execution timeout to apply to function. Value is in seconds. Range allowed 1 to 15. Default value 15 seconds..</param>
    public Function(string Description = null, string Handler = null, string Runtime = null, int? TimeoutSeconds = null)
    {
        this.Description = Description;
        this.Handler = Handler;
        this.Runtime = Runtime;
        this.TimeoutSeconds = TimeoutSeconds;

    }



    /// <summary>
    /// Function identifier.
    /// </summary>
    /// <value>Function identifier.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// Function name. This is automatically created based on the Action Id.
    /// </summary>
    /// <value>Function name. This is automatically created based on the Action Id.</value>
    [JsonPropertyName("name")]
    public string Name { get; private set; }



    /// <summary>
    /// Description of the function. Limit 255 characters.
    /// </summary>
    /// <value>Description of the function. Limit 255 characters.</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// Date and time function was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date and time function was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; private set; }



    /// <summary>
    /// Zip file identifier.
    /// </summary>
    /// <value>Zip file identifier.</value>
    [JsonPropertyName("zipId")]
    public string ZipId { get; private set; }



    /// <summary>
    /// Handler entry point into zip file to execute function. Should be path within upload function package to the invocation module without language extension, followed by a period and then exported invocation method name. e.g. &#39;src/index.handler&#39;
    /// </summary>
    /// <value>Handler entry point into zip file to execute function. Should be path within upload function package to the invocation module without language extension, followed by a period and then exported invocation method name. e.g. &#39;src/index.handler&#39;</value>
    [JsonPropertyName("handler")]
    public string Handler { get; set; }



    /// <summary>
    /// Runtime required for execution. Valid runtimes change over time as versions are deprecated. Use /api/v2/integrations/actions/functions/runtimes for current list.
    /// </summary>
    /// <value>Runtime required for execution. Valid runtimes change over time as versions are deprecated. Use /api/v2/integrations/actions/functions/runtimes for current list.</value>
    [JsonPropertyName("runtime")]
    public string Runtime { get; set; }



    /// <summary>
    /// Execution timeout to apply to function. Value is in seconds. Range allowed 1 to 15. Default value 15 seconds.
    /// </summary>
    /// <value>Execution timeout to apply to function. Value is in seconds. Range allowed 1 to 15. Default value 15 seconds.</value>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Function {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  ZipId: ").Append(ZipId).Append("\n");
        sb.Append("  Handler: ").Append(Handler).Append("\n");
        sb.Append("  Runtime: ").Append(Runtime).Append("\n");
        sb.Append("  TimeoutSeconds: ").Append(TimeoutSeconds).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as Function);
    }

    /// <summary>
    /// Returns true if Function instances are equal
    /// </summary>
    /// <param name="other">Instance of Function to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Function other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                ZipId == other.ZipId ||
                ZipId != null &&
                ZipId.Equals(other.ZipId)
            ) &&
            (
                Handler == other.Handler ||
                Handler != null &&
                Handler.Equals(other.Handler)
            ) &&
            (
                Runtime == other.Runtime ||
                Runtime != null &&
                Runtime.Equals(other.Runtime)
            ) &&
            (
                TimeoutSeconds == other.TimeoutSeconds ||
                TimeoutSeconds != null &&
                TimeoutSeconds.Equals(other.TimeoutSeconds)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (ZipId != null)
            {
                hash = hash * 59 + ZipId.GetHashCode();
            }

            if (Handler != null)
            {
                hash = hash * 59 + Handler.GetHashCode();
            }

            if (Runtime != null)
            {
                hash = hash * 59 + Runtime.GetHashCode();
            }

            if (TimeoutSeconds != null)
            {
                hash = hash * 59 + TimeoutSeconds.GetHashCode();
            }

            return hash;
        }
    }
}
