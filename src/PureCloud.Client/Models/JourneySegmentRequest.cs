using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// JourneySegmentRequest
/// </summary>

public partial class JourneySegmentRequest : IEquatable<JourneySegmentRequest>
{
    /// <summary>
    /// The target entity that a segment applies to.
    /// </summary>
    /// <value>The target entity that a segment applies to.</value>
    
    public enum ScopeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Session for "Session"
        /// </summary>
        [EnumMember(Value = "Session")]
        Session,

        /// <summary>
        /// Enum Customer for "Customer"
        /// </summary>
        [EnumMember(Value = "Customer")]
        Customer
    }
    /// <summary>
    /// The target entity that a segment applies to.
    /// </summary>
    /// <value>The target entity that a segment applies to.</value>
    [JsonPropertyName("scope")]
    public ScopeEnum? Scope { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="JourneySegmentRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected JourneySegmentRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneySegmentRequest" /> class.
    /// </summary>
    /// <param name="IsActive">Whether or not the segment is active..</param>
    /// <param name="DisplayName">The display name of the segment. (required).</param>
    /// <param name="Version">The version of the segment..</param>
    /// <param name="Description">A description of the segment..</param>
    /// <param name="Color">The hexadecimal color value of the segment. (required).</param>
    /// <param name="Scope">The target entity that a segment applies to..</param>
    /// <param name="ShouldDisplayToAgent">Whether or not the segment should be displayed to agent/supervisor users..</param>
    /// <param name="Context">The context of the segment. (required).</param>
    /// <param name="Journey">The pattern of rules defining the segment. (required).</param>
    /// <param name="ExternalSegment">Details of an entity corresponding to this segment in an external system..</param>
    /// <param name="AssignmentExpirationDays">Time, in days, from when the segment is assigned until it is automatically unassigned..</param>
    public JourneySegmentRequest(bool? IsActive = null, string DisplayName = null, int? Version = null, string Description = null, string Color = null, ScopeEnum? Scope = null, bool? ShouldDisplayToAgent = null, RequestContext Context = null, RequestJourney Journey = null, RequestExternalSegment ExternalSegment = null, int? AssignmentExpirationDays = null)
    {
        this.IsActive = IsActive;
        this.DisplayName = DisplayName;
        this.Version = Version;
        this.Description = Description;
        this.Color = Color;
        this.Scope = Scope;
        this.ShouldDisplayToAgent = ShouldDisplayToAgent;
        this.Context = Context;
        this.Journey = Journey;
        this.ExternalSegment = ExternalSegment;
        this.AssignmentExpirationDays = AssignmentExpirationDays;

    }



    /// <summary>
    /// Whether or not the segment is active.
    /// </summary>
    /// <value>Whether or not the segment is active.</value>
    [JsonPropertyName("isActive")]
    public bool? IsActive { get; set; }



    /// <summary>
    /// The display name of the segment.
    /// </summary>
    /// <value>The display name of the segment.</value>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }



    /// <summary>
    /// The version of the segment.
    /// </summary>
    /// <value>The version of the segment.</value>
    [JsonPropertyName("version")]
    public int? Version { get; set; }



    /// <summary>
    /// A description of the segment.
    /// </summary>
    /// <value>A description of the segment.</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// The hexadecimal color value of the segment.
    /// </summary>
    /// <value>The hexadecimal color value of the segment.</value>
    [JsonPropertyName("color")]
    public string Color { get; set; }





    /// <summary>
    /// Whether or not the segment should be displayed to agent/supervisor users.
    /// </summary>
    /// <value>Whether or not the segment should be displayed to agent/supervisor users.</value>
    [JsonPropertyName("shouldDisplayToAgent")]
    public bool? ShouldDisplayToAgent { get; set; }



    /// <summary>
    /// The context of the segment.
    /// </summary>
    /// <value>The context of the segment.</value>
    [JsonPropertyName("context")]
    public RequestContext Context { get; set; }



    /// <summary>
    /// The pattern of rules defining the segment.
    /// </summary>
    /// <value>The pattern of rules defining the segment.</value>
    [JsonPropertyName("journey")]
    public RequestJourney Journey { get; set; }



    /// <summary>
    /// Details of an entity corresponding to this segment in an external system.
    /// </summary>
    /// <value>Details of an entity corresponding to this segment in an external system.</value>
    [JsonPropertyName("externalSegment")]
    public RequestExternalSegment ExternalSegment { get; set; }



    /// <summary>
    /// Time, in days, from when the segment is assigned until it is automatically unassigned.
    /// </summary>
    /// <value>Time, in days, from when the segment is assigned until it is automatically unassigned.</value>
    [JsonPropertyName("assignmentExpirationDays")]
    public int? AssignmentExpirationDays { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneySegmentRequest {\n");

        sb.Append("  IsActive: ").Append(IsActive).Append("\n");
        sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Color: ").Append(Color).Append("\n");
        sb.Append("  Scope: ").Append(Scope).Append("\n");
        sb.Append("  ShouldDisplayToAgent: ").Append(ShouldDisplayToAgent).Append("\n");
        sb.Append("  Context: ").Append(Context).Append("\n");
        sb.Append("  Journey: ").Append(Journey).Append("\n");
        sb.Append("  ExternalSegment: ").Append(ExternalSegment).Append("\n");
        sb.Append("  AssignmentExpirationDays: ").Append(AssignmentExpirationDays).Append("\n");
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
        return Equals(obj as JourneySegmentRequest);
    }

    /// <summary>
    /// Returns true if JourneySegmentRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneySegmentRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneySegmentRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                IsActive == other.IsActive ||
                IsActive != null &&
                IsActive.Equals(other.IsActive)
            ) &&
            (
                DisplayName == other.DisplayName ||
                DisplayName != null &&
                DisplayName.Equals(other.DisplayName)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                Color == other.Color ||
                Color != null &&
                Color.Equals(other.Color)
            ) &&
            (
                Scope == other.Scope ||
                Scope != null &&
                Scope.Equals(other.Scope)
            ) &&
            (
                ShouldDisplayToAgent == other.ShouldDisplayToAgent ||
                ShouldDisplayToAgent != null &&
                ShouldDisplayToAgent.Equals(other.ShouldDisplayToAgent)
            ) &&
            (
                Context == other.Context ||
                Context != null &&
                Context.Equals(other.Context)
            ) &&
            (
                Journey == other.Journey ||
                Journey != null &&
                Journey.Equals(other.Journey)
            ) &&
            (
                ExternalSegment == other.ExternalSegment ||
                ExternalSegment != null &&
                ExternalSegment.Equals(other.ExternalSegment)
            ) &&
            (
                AssignmentExpirationDays == other.AssignmentExpirationDays ||
                AssignmentExpirationDays != null &&
                AssignmentExpirationDays.Equals(other.AssignmentExpirationDays)
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
            if (IsActive != null)
            {
                hash = hash * 59 + IsActive.GetHashCode();
            }

            if (DisplayName != null)
            {
                hash = hash * 59 + DisplayName.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Color != null)
            {
                hash = hash * 59 + Color.GetHashCode();
            }

            if (Scope != null)
            {
                hash = hash * 59 + Scope.GetHashCode();
            }

            if (ShouldDisplayToAgent != null)
            {
                hash = hash * 59 + ShouldDisplayToAgent.GetHashCode();
            }

            if (Context != null)
            {
                hash = hash * 59 + Context.GetHashCode();
            }

            if (Journey != null)
            {
                hash = hash * 59 + Journey.GetHashCode();
            }

            if (ExternalSegment != null)
            {
                hash = hash * 59 + ExternalSegment.GetHashCode();
            }

            if (AssignmentExpirationDays != null)
            {
                hash = hash * 59 + AssignmentExpirationDays.GetHashCode();
            }

            return hash;
        }
    }
}
