using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ServiceNowSourceRequest
/// </summary>

public partial class ServiceNowSourceRequest : IEquatable<ServiceNowSourceRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ServiceNowSourceRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ServiceNowSourceRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ServiceNowSourceRequest" /> class.
    /// </summary>
    /// <param name="Name">The name of the integration source. (required).</param>
    /// <param name="IntegrationId">The integration associated with the source..</param>
    /// <param name="SchedulePeriod">The schedule period of the source in hours. Must be at least 6 and at most 48 hours..</param>
    /// <param name="Settings">The settings of the source..</param>
    public ServiceNowSourceRequest(string Name = null, string IntegrationId = null, int? SchedulePeriod = null, ServiceNowSettings Settings = null)
    {
        this.Name = Name;
        this.IntegrationId = IntegrationId;
        this.SchedulePeriod = SchedulePeriod;
        this.Settings = Settings;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The name of the integration source.
    /// </summary>
    /// <value>The name of the integration source.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The integration associated with the source.
    /// </summary>
    /// <value>The integration associated with the source.</value>
    [JsonPropertyName("integrationId")]
    public string IntegrationId { get; set; }



    /// <summary>
    /// The schedule period of the source in hours. Must be at least 6 and at most 48 hours.
    /// </summary>
    /// <value>The schedule period of the source in hours. Must be at least 6 and at most 48 hours.</value>
    [JsonPropertyName("schedulePeriod")]
    public int? SchedulePeriod { get; set; }



    /// <summary>
    /// The settings of the source.
    /// </summary>
    /// <value>The settings of the source.</value>
    [JsonPropertyName("settings")]
    public ServiceNowSettings Settings { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ServiceNowSourceRequest {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  IntegrationId: ").Append(IntegrationId).Append("\n");
        sb.Append("  SchedulePeriod: ").Append(SchedulePeriod).Append("\n");
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
        return Equals(obj as ServiceNowSourceRequest);
    }

    /// <summary>
    /// Returns true if ServiceNowSourceRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of ServiceNowSourceRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ServiceNowSourceRequest other)
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
                IntegrationId == other.IntegrationId ||
                IntegrationId != null &&
                IntegrationId.Equals(other.IntegrationId)
            ) &&
            (
                SchedulePeriod == other.SchedulePeriod ||
                SchedulePeriod != null &&
                SchedulePeriod.Equals(other.SchedulePeriod)
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

            if (IntegrationId != null)
            {
                hash = hash * 59 + IntegrationId.GetHashCode();
            }

            if (SchedulePeriod != null)
            {
                hash = hash * 59 + SchedulePeriod.GetHashCode();
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
