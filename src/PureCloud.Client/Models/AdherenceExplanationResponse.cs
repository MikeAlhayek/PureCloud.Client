using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AdherenceExplanationResponse
/// </summary>

public partial class AdherenceExplanationResponse : IEquatable<AdherenceExplanationResponse>
{
    /// <summary>
    /// The type of the adherence explanation
    /// </summary>
    /// <value>The type of the adherence explanation</value>
    
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
        /// Enum Late for "Late"
        /// </summary>
        [EnumMember(Value = "Late")]
        Late
    }
    /// <summary>
    /// The status of the adherence explanation
    /// </summary>
    /// <value>The status of the adherence explanation</value>
    
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
        /// Enum Pending for "Pending"
        /// </summary>
        [EnumMember(Value = "Pending")]
        Pending,

        /// <summary>
        /// Enum Approved for "Approved"
        /// </summary>
        [EnumMember(Value = "Approved")]
        Approved,

        /// <summary>
        /// Enum Denied for "Denied"
        /// </summary>
        [EnumMember(Value = "Denied")]
        Denied
    }
    /// <summary>
    /// The type of the adherence explanation
    /// </summary>
    /// <value>The type of the adherence explanation</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// The status of the adherence explanation
    /// </summary>
    /// <value>The status of the adherence explanation</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="AdherenceExplanationResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AdherenceExplanationResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AdherenceExplanationResponse" /> class.
    /// </summary>
    /// <param name="Agent">The agent to whom this adherence explanation applies (required).</param>
    /// <param name="ManagementUnit">The management unit to which the agent belonged at the time the adherence explanation was submitted (required).</param>
    /// <param name="BusinessUnit">The business unit to which the agent belonged at the time the adherence explanation was submitted (required).</param>
    /// <param name="Type">The type of the adherence explanation (required).</param>
    /// <param name="Status">The status of the adherence explanation (required).</param>
    /// <param name="StartDate">The start timestamp of the adherence explanation in ISO-8601 format (required).</param>
    /// <param name="LengthMinutes">The length of the adherence explanation in minutes (required).</param>
    /// <param name="Notes">Notes about the adherence explanation.</param>
    /// <param name="ReviewedBy">The user who reviewed the adherence explanation, if applicable. The id may be &#39;System&#39; if it was an automated process.</param>
    /// <param name="ReviewedDate">The timestamp for when the adherence explanation was reviewed, if applicable. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public AdherenceExplanationResponse(UserReference Agent = null, ManagementUnitReference ManagementUnit = null, BusinessUnitReference BusinessUnit = null, TypeEnum? Type = null, StatusEnum? Status = null, DateTime? StartDate = null, int? LengthMinutes = null, string Notes = null, UserReference ReviewedBy = null, DateTime? ReviewedDate = null)
    {
        this.Agent = Agent;
        this.ManagementUnit = ManagementUnit;
        this.BusinessUnit = BusinessUnit;
        this.Type = Type;
        this.Status = Status;
        this.StartDate = StartDate;
        this.LengthMinutes = LengthMinutes;
        this.Notes = Notes;
        this.ReviewedBy = ReviewedBy;
        this.ReviewedDate = ReviewedDate;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The agent to whom this adherence explanation applies
    /// </summary>
    /// <value>The agent to whom this adherence explanation applies</value>
    [JsonPropertyName("agent")]
    public UserReference Agent { get; set; }



    /// <summary>
    /// The management unit to which the agent belonged at the time the adherence explanation was submitted
    /// </summary>
    /// <value>The management unit to which the agent belonged at the time the adherence explanation was submitted</value>
    [JsonPropertyName("managementUnit")]
    public ManagementUnitReference ManagementUnit { get; set; }



    /// <summary>
    /// The business unit to which the agent belonged at the time the adherence explanation was submitted
    /// </summary>
    /// <value>The business unit to which the agent belonged at the time the adherence explanation was submitted</value>
    [JsonPropertyName("businessUnit")]
    public BusinessUnitReference BusinessUnit { get; set; }







    /// <summary>
    /// The start timestamp of the adherence explanation in ISO-8601 format
    /// </summary>
    /// <value>The start timestamp of the adherence explanation in ISO-8601 format</value>
    [JsonPropertyName("startDate")]
    public DateTime? StartDate { get; set; }



    /// <summary>
    /// The length of the adherence explanation in minutes
    /// </summary>
    /// <value>The length of the adherence explanation in minutes</value>
    [JsonPropertyName("lengthMinutes")]
    public int? LengthMinutes { get; set; }



    /// <summary>
    /// Notes about the adherence explanation
    /// </summary>
    /// <value>Notes about the adherence explanation</value>
    [JsonPropertyName("notes")]
    public string Notes { get; set; }



    /// <summary>
    /// The user who reviewed the adherence explanation, if applicable. The id may be &#39;System&#39; if it was an automated process
    /// </summary>
    /// <value>The user who reviewed the adherence explanation, if applicable. The id may be &#39;System&#39; if it was an automated process</value>
    [JsonPropertyName("reviewedBy")]
    public UserReference ReviewedBy { get; set; }



    /// <summary>
    /// The timestamp for when the adherence explanation was reviewed, if applicable. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp for when the adherence explanation was reviewed, if applicable. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("reviewedDate")]
    public DateTime? ReviewedDate { get; set; }



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
        sb.Append("class AdherenceExplanationResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Agent: ").Append(Agent).Append("\n");
        sb.Append("  ManagementUnit: ").Append(ManagementUnit).Append("\n");
        sb.Append("  BusinessUnit: ").Append(BusinessUnit).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  StartDate: ").Append(StartDate).Append("\n");
        sb.Append("  LengthMinutes: ").Append(LengthMinutes).Append("\n");
        sb.Append("  Notes: ").Append(Notes).Append("\n");
        sb.Append("  ReviewedBy: ").Append(ReviewedBy).Append("\n");
        sb.Append("  ReviewedDate: ").Append(ReviewedDate).Append("\n");
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
        return Equals(obj as AdherenceExplanationResponse);
    }

    /// <summary>
    /// Returns true if AdherenceExplanationResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of AdherenceExplanationResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AdherenceExplanationResponse other)
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
                Agent == other.Agent ||
                Agent != null &&
                Agent.Equals(other.Agent)
            ) &&
            (
                ManagementUnit == other.ManagementUnit ||
                ManagementUnit != null &&
                ManagementUnit.Equals(other.ManagementUnit)
            ) &&
            (
                BusinessUnit == other.BusinessUnit ||
                BusinessUnit != null &&
                BusinessUnit.Equals(other.BusinessUnit)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                StartDate == other.StartDate ||
                StartDate != null &&
                StartDate.Equals(other.StartDate)
            ) &&
            (
                LengthMinutes == other.LengthMinutes ||
                LengthMinutes != null &&
                LengthMinutes.Equals(other.LengthMinutes)
            ) &&
            (
                Notes == other.Notes ||
                Notes != null &&
                Notes.Equals(other.Notes)
            ) &&
            (
                ReviewedBy == other.ReviewedBy ||
                ReviewedBy != null &&
                ReviewedBy.Equals(other.ReviewedBy)
            ) &&
            (
                ReviewedDate == other.ReviewedDate ||
                ReviewedDate != null &&
                ReviewedDate.Equals(other.ReviewedDate)
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

            if (Agent != null)
            {
                hash = hash * 59 + Agent.GetHashCode();
            }

            if (ManagementUnit != null)
            {
                hash = hash * 59 + ManagementUnit.GetHashCode();
            }

            if (BusinessUnit != null)
            {
                hash = hash * 59 + BusinessUnit.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (StartDate != null)
            {
                hash = hash * 59 + StartDate.GetHashCode();
            }

            if (LengthMinutes != null)
            {
                hash = hash * 59 + LengthMinutes.GetHashCode();
            }

            if (Notes != null)
            {
                hash = hash * 59 + Notes.GetHashCode();
            }

            if (ReviewedBy != null)
            {
                hash = hash * 59 + ReviewedBy.GetHashCode();
            }

            if (ReviewedDate != null)
            {
                hash = hash * 59 + ReviewedDate.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
