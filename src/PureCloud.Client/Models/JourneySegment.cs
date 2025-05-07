using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// JourneySegment
/// </summary>

public partial class JourneySegment : IEquatable<JourneySegment>
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
    /// Initializes a new instance of the <see cref="JourneySegment" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected JourneySegment() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneySegment" /> class.
    /// </summary>
    /// <param name="Id">The ID of the segment. (required).</param>
    /// <param name="IsActive">Whether or not the segment is active. (required).</param>
    /// <param name="DisplayName">The display name of the segment. (required).</param>
    /// <param name="Version">The version of the segment. (required).</param>
    /// <param name="Description">A description of the segment..</param>
    /// <param name="Color">The hexadecimal color value of the segment. (required).</param>
    /// <param name="Scope">The target entity that a segment applies to. (required).</param>
    /// <param name="ShouldDisplayToAgent">Whether or not the segment should be displayed to agent/supervisor users. (required).</param>
    /// <param name="Context">The context of the segment. (required).</param>
    /// <param name="Journey">The pattern of rules defining the segment. (required).</param>
    /// <param name="ExternalSegment">Details of an entity corresponding to this segment in an external system..</param>
    /// <param name="AssignmentExpirationDays">Time, in days, from when the segment is assigned until it is automatically unassigned..</param>
    /// <param name="CreatedDate">Timestamp indicating when the segment was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    /// <param name="ModifiedDate">Timestamp indicating when the segment was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    public JourneySegment(string Id = null, bool? IsActive = null, string DisplayName = null, int? Version = null, string Description = null, string Color = null, ScopeEnum? Scope = null, bool? ShouldDisplayToAgent = null, Context Context = null, Journey Journey = null, ExternalSegment ExternalSegment = null, int? AssignmentExpirationDays = null, DateTime? CreatedDate = null, DateTime? ModifiedDate = null)
    {
        this.Id = Id;
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
        this.CreatedDate = CreatedDate;
        this.ModifiedDate = ModifiedDate;

    }



    /// <summary>
    /// The ID of the segment.
    /// </summary>
    /// <value>The ID of the segment.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



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
    public Context Context { get; set; }



    /// <summary>
    /// The pattern of rules defining the segment.
    /// </summary>
    /// <value>The pattern of rules defining the segment.</value>
    [JsonPropertyName("journey")]
    public Journey Journey { get; set; }



    /// <summary>
    /// Details of an entity corresponding to this segment in an external system.
    /// </summary>
    /// <value>Details of an entity corresponding to this segment in an external system.</value>
    [JsonPropertyName("externalSegment")]
    public ExternalSegment ExternalSegment { get; set; }



    /// <summary>
    /// Time, in days, from when the segment is assigned until it is automatically unassigned.
    /// </summary>
    /// <value>Time, in days, from when the segment is assigned until it is automatically unassigned.</value>
    [JsonPropertyName("assignmentExpirationDays")]
    public int? AssignmentExpirationDays { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }



    /// <summary>
    /// Timestamp indicating when the segment was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp indicating when the segment was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("createdDate")]
    public DateTime? CreatedDate { get; set; }



    /// <summary>
    /// Timestamp indicating when the segment was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp indicating when the segment was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("modifiedDate")]
    public DateTime? ModifiedDate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneySegment {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
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
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
        sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
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
        return Equals(obj as JourneySegment);
    }

    /// <summary>
    /// Returns true if JourneySegment instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneySegment to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneySegment other)
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
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
            ) &&
            (
                CreatedDate == other.CreatedDate ||
                CreatedDate != null &&
                CreatedDate.Equals(other.CreatedDate)
            ) &&
            (
                ModifiedDate == other.ModifiedDate ||
                ModifiedDate != null &&
                ModifiedDate.Equals(other.ModifiedDate)
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

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            if (CreatedDate != null)
            {
                hash = hash * 59 + CreatedDate.GetHashCode();
            }

            if (ModifiedDate != null)
            {
                hash = hash * 59 + ModifiedDate.GetHashCode();
            }

            return hash;
        }
    }
}
