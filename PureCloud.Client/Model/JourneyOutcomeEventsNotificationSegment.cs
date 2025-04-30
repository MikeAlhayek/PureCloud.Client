using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// JourneyOutcomeEventsNotificationSegment
/// </summary>
[DataContract]
public partial class JourneyOutcomeEventsNotificationSegment : IEquatable<JourneyOutcomeEventsNotificationSegment>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyOutcomeEventsNotificationSegment" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="SelfUri">SelfUri.</param>
    /// <param name="AssignedDate">AssignedDate.</param>
    public JourneyOutcomeEventsNotificationSegment(Guid? Id = null, string SelfUri = null, DateTime? AssignedDate = null)
    {
        this.Id = Id;
        this.SelfUri = SelfUri;
        this.AssignedDate = AssignedDate;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public Guid? Id { get; set; }



    /// <summary>
    /// Gets or Sets SelfUri
    /// </summary>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; set; }



    /// <summary>
    /// Gets or Sets AssignedDate
    /// </summary>
    [DataMember(Name = "assignedDate", EmitDefaultValue = false)]
    public DateTime? AssignedDate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneyOutcomeEventsNotificationSegment {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("  AssignedDate: ").Append(AssignedDate).Append("\n");
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
        return this.Equals(obj as JourneyOutcomeEventsNotificationSegment);
    }

    /// <summary>
    /// Returns true if JourneyOutcomeEventsNotificationSegment instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneyOutcomeEventsNotificationSegment to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneyOutcomeEventsNotificationSegment other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Id == other.Id ||
                this.Id != null &&
                this.Id.Equals(other.Id)
            ) &&
            (
                this.SelfUri == other.SelfUri ||
                this.SelfUri != null &&
                this.SelfUri.Equals(other.SelfUri)
            ) &&
            (
                this.AssignedDate == other.AssignedDate ||
                this.AssignedDate != null &&
                this.AssignedDate.Equals(other.AssignedDate)
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
            if (this.Id != null)
            {
                hash = hash * 59 + this.Id.GetHashCode();
            }

            if (this.SelfUri != null)
            {
                hash = hash * 59 + this.SelfUri.GetHashCode();
            }

            if (this.AssignedDate != null)
            {
                hash = hash * 59 + this.AssignedDate.GetHashCode();
            }

            return hash;
        }
    }
}
