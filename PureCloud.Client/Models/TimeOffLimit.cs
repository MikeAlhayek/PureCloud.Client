using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TimeOffLimit
/// </summary>
[DataContract]
public partial class TimeOffLimit : IEquatable<TimeOffLimit>
{
    /// <summary>
    /// Granularity choice for the time off limit
    /// </summary>
    /// <value>Granularity choice for the time off limit</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum GranularityEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Daily for "Daily"
        /// </summary>
        [EnumMember(Value = "Daily")]
        Daily
    }
    /// <summary>
    /// Granularity choice for the time off limit
    /// </summary>
    /// <value>Granularity choice for the time off limit</value>
    [DataMember(Name = "granularity", EmitDefaultValue = false)]
    public GranularityEnum? Granularity { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="TimeOffLimit" /> class.
    /// </summary>
    /// <param name="Granularity">Granularity choice for the time off limit.</param>
    /// <param name="DefaultLimitMinutes">The default time off limit value in minutes per granularity interval.</param>
    /// <param name="Metadata">Version metadata for the time off limit.</param>
    public TimeOffLimit(GranularityEnum? Granularity = null, int? DefaultLimitMinutes = null, WfmVersionedEntityMetadata Metadata = null)
    {
        this.Granularity = Granularity;
        this.DefaultLimitMinutes = DefaultLimitMinutes;
        this.Metadata = Metadata;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }





    /// <summary>
    /// The default time off limit value in minutes per granularity interval
    /// </summary>
    /// <value>The default time off limit value in minutes per granularity interval</value>
    [DataMember(Name = "defaultLimitMinutes", EmitDefaultValue = false)]
    public int? DefaultLimitMinutes { get; set; }



    /// <summary>
    /// Version metadata for the time off limit
    /// </summary>
    /// <value>Version metadata for the time off limit</value>
    [DataMember(Name = "metadata", EmitDefaultValue = false)]
    public WfmVersionedEntityMetadata Metadata { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TimeOffLimit {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Granularity: ").Append(Granularity).Append("\n");
        sb.Append("  DefaultLimitMinutes: ").Append(DefaultLimitMinutes).Append("\n");
        sb.Append("  Metadata: ").Append(Metadata).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as TimeOffLimit);
    }

    /// <summary>
    /// Returns true if TimeOffLimit instances are equal
    /// </summary>
    /// <param name="other">Instance of TimeOffLimit to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TimeOffLimit other)
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
                Granularity == other.Granularity ||
                Granularity != null &&
                Granularity.Equals(other.Granularity)
            ) &&
            (
                DefaultLimitMinutes == other.DefaultLimitMinutes ||
                DefaultLimitMinutes != null &&
                DefaultLimitMinutes.Equals(other.DefaultLimitMinutes)
            ) &&
            (
                Metadata == other.Metadata ||
                Metadata != null &&
                Metadata.Equals(other.Metadata)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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

            if (Granularity != null)
            {
                hash = hash * 59 + Granularity.GetHashCode();
            }

            if (DefaultLimitMinutes != null)
            {
                hash = hash * 59 + DefaultLimitMinutes.GetHashCode();
            }

            if (Metadata != null)
            {
                hash = hash * 59 + Metadata.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
