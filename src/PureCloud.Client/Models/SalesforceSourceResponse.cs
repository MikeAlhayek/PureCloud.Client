using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SalesforceSourceResponse
/// </summary>

public partial class SalesforceSourceResponse : IEquatable<SalesforceSourceResponse>
{
    /// <summary>
    /// The source type.
    /// </summary>
    /// <value>The source type.</value>
    
    public enum TypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Salesforce for "Salesforce"
        /// </summary>
        [EnumMember(Value = "Salesforce")]
        Salesforce,

        /// <summary>
        /// Enum Servicenow for "ServiceNow"
        /// </summary>
        [EnumMember(Value = "ServiceNow")]
        Servicenow
    }
    /// <summary>
    /// The source type.
    /// </summary>
    /// <value>The source type.</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="SalesforceSourceResponse" /> class.
    /// </summary>
    /// <param name="Name">Name of the source..</param>
    /// <param name="DateCreated">Source creation date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DateModified">Source last modification date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Type">The source type..</param>
    /// <param name="Integration">The reference to the integration associated with the source..</param>
    /// <param name="SchedulePeriod">The schedule period of the source in hours..</param>
    /// <param name="LastSync">Additional information about the last synchronization of the source..</param>
    /// <param name="Settings">The settings of the source..</param>
    public SalesforceSourceResponse(string Name = null, DateTime? DateCreated = null, DateTime? DateModified = null, TypeEnum? Type = null, KnowledgeIntegrationReference Integration = null, int? SchedulePeriod = null, SourceLastSync LastSync = null, SalesforceSettings Settings = null)
    {
        this.Name = Name;
        this.DateCreated = DateCreated;
        this.DateModified = DateModified;
        this.Type = Type;
        this.Integration = Integration;
        this.SchedulePeriod = SchedulePeriod;
        this.LastSync = LastSync;
        this.Settings = Settings;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// Name of the source.
    /// </summary>
    /// <value>Name of the source.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Source creation date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Source creation date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Source last modification date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Source last modification date-time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }





    /// <summary>
    /// The reference to the integration associated with the source.
    /// </summary>
    /// <value>The reference to the integration associated with the source.</value>
    [JsonPropertyName("integration")]
    public KnowledgeIntegrationReference Integration { get; set; }



    /// <summary>
    /// The schedule period of the source in hours.
    /// </summary>
    /// <value>The schedule period of the source in hours.</value>
    [JsonPropertyName("schedulePeriod")]
    public int? SchedulePeriod { get; set; }



    /// <summary>
    /// Additional information about the last synchronization of the source.
    /// </summary>
    /// <value>Additional information about the last synchronization of the source.</value>
    [JsonPropertyName("lastSync")]
    public SourceLastSync LastSync { get; set; }



    /// <summary>
    /// The settings of the source.
    /// </summary>
    /// <value>The settings of the source.</value>
    [JsonPropertyName("settings")]
    public SalesforceSettings Settings { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SalesforceSourceResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Integration: ").Append(Integration).Append("\n");
        sb.Append("  SchedulePeriod: ").Append(SchedulePeriod).Append("\n");
        sb.Append("  LastSync: ").Append(LastSync).Append("\n");
        sb.Append("  Settings: ").Append(Settings).Append("\n");
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
        return Equals(obj as SalesforceSourceResponse);
    }

    /// <summary>
    /// Returns true if SalesforceSourceResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of SalesforceSourceResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SalesforceSourceResponse other)
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
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Integration == other.Integration ||
                Integration != null &&
                Integration.Equals(other.Integration)
            ) &&
            (
                SchedulePeriod == other.SchedulePeriod ||
                SchedulePeriod != null &&
                SchedulePeriod.Equals(other.SchedulePeriod)
            ) &&
            (
                LastSync == other.LastSync ||
                LastSync != null &&
                LastSync.Equals(other.LastSync)
            ) &&
            (
                Settings == other.Settings ||
                Settings != null &&
                Settings.Equals(other.Settings)
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

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Integration != null)
            {
                hash = hash * 59 + Integration.GetHashCode();
            }

            if (SchedulePeriod != null)
            {
                hash = hash * 59 + SchedulePeriod.GetHashCode();
            }

            if (LastSync != null)
            {
                hash = hash * 59 + LastSync.GetHashCode();
            }

            if (Settings != null)
            {
                hash = hash * 59 + Settings.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
