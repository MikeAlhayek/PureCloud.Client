using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CampaignSequence
/// </summary>

public partial class CampaignSequence : IEquatable<CampaignSequence>
{
    /// <summary>
    /// The current status of the CampaignSequence. A CampaignSequence can be turned 'on' or 'off'.
    /// </summary>
    /// <value>The current status of the CampaignSequence. A CampaignSequence can be turned 'on' or 'off'.</value>
    
    public enum StatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum On for "on"
        /// </summary>
        [EnumMember(Value = "on")]
        On,

        /// <summary>
        /// Enum Off for "off"
        /// </summary>
        [EnumMember(Value = "off")]
        Off,

        /// <summary>
        /// Enum Complete for "complete"
        /// </summary>
        [EnumMember(Value = "complete")]
        Complete
    }
    /// <summary>
    /// The current status of the CampaignSequence. A CampaignSequence can be turned 'on' or 'off'.
    /// </summary>
    /// <value>The current status of the CampaignSequence. A CampaignSequence can be turned 'on' or 'off'.</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="CampaignSequence" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CampaignSequence() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CampaignSequence" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
    /// <param name="Campaigns">The ordered list of Campaigns that this CampaignSequence will run. (required).</param>
    /// <param name="Status">The current status of the CampaignSequence. A CampaignSequence can be turned &#39;on&#39; or &#39;off&#39;. (required).</param>
    /// <param name="Repeat">Indicates if a sequence should repeat from the beginning after the last campaign completes. Default is false..</param>
    public CampaignSequence(string Name = null, int? Version = null, List<DomainEntityRef> Campaigns = null, StatusEnum? Status = null, bool? Repeat = null)
    {
        this.Name = Name;
        this.Version = Version;
        this.Campaigns = Campaigns;
        this.Status = Status;
        this.Repeat = Repeat;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; private set; }



    /// <summary>
    /// Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; private set; }



    /// <summary>
    /// Required for updates, must match the version number of the most recent update
    /// </summary>
    /// <value>Required for updates, must match the version number of the most recent update</value>
    [JsonPropertyName("version")]
    public int? Version { get; set; }



    /// <summary>
    /// The ordered list of Campaigns that this CampaignSequence will run.
    /// </summary>
    /// <value>The ordered list of Campaigns that this CampaignSequence will run.</value>
    [JsonPropertyName("campaigns")]
    public List<DomainEntityRef> Campaigns { get; set; }



    /// <summary>
    /// A zero-based index indicating which Campaign this CampaignSequence is currently on.
    /// </summary>
    /// <value>A zero-based index indicating which Campaign this CampaignSequence is currently on.</value>
    [JsonPropertyName("currentCampaign")]
    public int? CurrentCampaign { get; private set; }





    /// <summary>
    /// A message indicating if and why a CampaignSequence has stopped unexpectedly.
    /// </summary>
    /// <value>A message indicating if and why a CampaignSequence has stopped unexpectedly.</value>
    [JsonPropertyName("stopMessage")]
    public string StopMessage { get; private set; }



    /// <summary>
    /// Indicates if a sequence should repeat from the beginning after the last campaign completes. Default is false.
    /// </summary>
    /// <value>Indicates if a sequence should repeat from the beginning after the last campaign completes. Default is false.</value>
    [JsonPropertyName("repeat")]
    public bool? Repeat { get; set; }



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
        sb.Append("class CampaignSequence {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  Campaigns: ").Append(Campaigns).Append("\n");
        sb.Append("  CurrentCampaign: ").Append(CurrentCampaign).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  StopMessage: ").Append(StopMessage).Append("\n");
        sb.Append("  Repeat: ").Append(Repeat).Append("\n");
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
        return Equals(obj as CampaignSequence);
    }

    /// <summary>
    /// Returns true if CampaignSequence instances are equal
    /// </summary>
    /// <param name="other">Instance of CampaignSequence to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CampaignSequence other)
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
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                Campaigns == other.Campaigns ||
                Campaigns != null &&
                Campaigns.SequenceEqual(other.Campaigns)
            ) &&
            (
                CurrentCampaign == other.CurrentCampaign ||
                CurrentCampaign != null &&
                CurrentCampaign.Equals(other.CurrentCampaign)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                StopMessage == other.StopMessage ||
                StopMessage != null &&
                StopMessage.Equals(other.StopMessage)
            ) &&
            (
                Repeat == other.Repeat ||
                Repeat != null &&
                Repeat.Equals(other.Repeat)
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

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (Campaigns != null)
            {
                hash = hash * 59 + Campaigns.GetHashCode();
            }

            if (CurrentCampaign != null)
            {
                hash = hash * 59 + CurrentCampaign.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (StopMessage != null)
            {
                hash = hash * 59 + StopMessage.GetHashCode();
            }

            if (Repeat != null)
            {
                hash = hash * 59 + Repeat.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
