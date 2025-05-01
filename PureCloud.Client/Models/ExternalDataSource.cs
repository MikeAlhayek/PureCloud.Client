using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Describes a link to a record in an external system that contributed data to a Relate record
/// </summary>
[DataContract]
public partial class ExternalDataSource : IEquatable<ExternalDataSource>
{
    /// <summary>
    /// The platform that was the source of the data.  Example: a CRM like SALESFORCE.
    /// </summary>
    /// <value>The platform that was the source of the data.  Example: a CRM like SALESFORCE.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PlatformEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Salesforce for "SALESFORCE"
        /// </summary>
        [EnumMember(Value = "SALESFORCE")]
        Salesforce
    }
    /// <summary>
    /// The platform that was the source of the data.  Example: a CRM like SALESFORCE.
    /// </summary>
    /// <value>The platform that was the source of the data.  Example: a CRM like SALESFORCE.</value>
    [DataMember(Name = "platform", EmitDefaultValue = false)]
    public PlatformEnum? Platform { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ExternalDataSource" /> class.
    /// </summary>
    /// <param name="Platform">The platform that was the source of the data.  Example: a CRM like SALESFORCE..</param>
    /// <param name="Url">An URL that links to the source record that contributed data to the associated entity..</param>
    public ExternalDataSource(PlatformEnum? Platform = null, string Url = null)
    {
        this.Platform = Platform;
        this.Url = Url;

    }





    /// <summary>
    /// An URL that links to the source record that contributed data to the associated entity.
    /// </summary>
    /// <value>An URL that links to the source record that contributed data to the associated entity.</value>
    [DataMember(Name = "url", EmitDefaultValue = false)]
    public string Url { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ExternalDataSource {\n");

        sb.Append("  Platform: ").Append(Platform).Append("\n");
        sb.Append("  Url: ").Append(Url).Append("\n");
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
        return Equals(obj as ExternalDataSource);
    }

    /// <summary>
    /// Returns true if ExternalDataSource instances are equal
    /// </summary>
    /// <param name="other">Instance of ExternalDataSource to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ExternalDataSource other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Platform == other.Platform ||
                Platform != null &&
                Platform.Equals(other.Platform)
            ) &&
            (
                Url == other.Url ||
                Url != null &&
                Url.Equals(other.Url)
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
            if (Platform != null)
            {
                hash = hash * 59 + Platform.GetHashCode();
            }

            if (Url != null)
            {
                hash = hash * 59 + Url.GetHashCode();
            }

            return hash;
        }
    }
}
