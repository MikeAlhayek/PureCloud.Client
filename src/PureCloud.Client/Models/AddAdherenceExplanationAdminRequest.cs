using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AddAdherenceExplanationAdminRequest
/// </summary>

public partial class AddAdherenceExplanationAdminRequest : IEquatable<AddAdherenceExplanationAdminRequest>
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
    /// Initializes a new instance of the <see cref="AddAdherenceExplanationAdminRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AddAdherenceExplanationAdminRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AddAdherenceExplanationAdminRequest" /> class.
    /// </summary>
    /// <param name="Type">The type of the adherence explanation (required).</param>
    /// <param name="StartDate">The start timestamp of the adherence explanation in ISO-8601 format (required).</param>
    /// <param name="LengthMinutes">The length of the adherence explanation in minutes (required).</param>
    /// <param name="Notes">Notes about the adherence explanation.</param>
    /// <param name="Status">The status of the adherence explanation.</param>
    public AddAdherenceExplanationAdminRequest(TypeEnum? Type = null, DateTime? StartDate = null, int? LengthMinutes = null, string Notes = null, StatusEnum? Status = null)
    {
        this.Type = Type;
        this.StartDate = StartDate;
        this.LengthMinutes = LengthMinutes;
        this.Notes = Notes;
        this.Status = Status;

    }





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
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AddAdherenceExplanationAdminRequest {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  StartDate: ").Append(StartDate).Append("\n");
        sb.Append("  LengthMinutes: ").Append(LengthMinutes).Append("\n");
        sb.Append("  Notes: ").Append(Notes).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
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
        return Equals(obj as AddAdherenceExplanationAdminRequest);
    }

    /// <summary>
    /// Returns true if AddAdherenceExplanationAdminRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of AddAdherenceExplanationAdminRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AddAdherenceExplanationAdminRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
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
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
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
            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
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

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            return hash;
        }
    }
}
