using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PhoneChangeTopicLineStatus
/// </summary>

public partial class PhoneChangeTopicLineStatus : IEquatable<PhoneChangeTopicLineStatus>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PhoneChangeTopicLineStatus" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Reachable">Reachable.</param>
    /// <param name="AddressOfRecord">AddressOfRecord.</param>
    /// <param name="ContactAddresses">ContactAddresses.</param>
    /// <param name="ReachableStateTime">ReachableStateTime.</param>
    public PhoneChangeTopicLineStatus(string Id = null, bool? Reachable = null, string AddressOfRecord = null, List<string> ContactAddresses = null, DateTime? ReachableStateTime = null)
    {
        this.Id = Id;
        this.Reachable = Reachable;
        this.AddressOfRecord = AddressOfRecord;
        this.ContactAddresses = ContactAddresses;
        this.ReachableStateTime = ReachableStateTime;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Reachable
    /// </summary>
    [JsonPropertyName("reachable")]
    public bool? Reachable { get; set; }



    /// <summary>
    /// Gets or Sets AddressOfRecord
    /// </summary>
    [JsonPropertyName("addressOfRecord")]
    public string AddressOfRecord { get; set; }



    /// <summary>
    /// Gets or Sets ContactAddresses
    /// </summary>
    [JsonPropertyName("contactAddresses")]
    public List<string> ContactAddresses { get; set; }



    /// <summary>
    /// Gets or Sets ReachableStateTime
    /// </summary>
    [JsonPropertyName("reachableStateTime")]
    public DateTime? ReachableStateTime { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PhoneChangeTopicLineStatus {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Reachable: ").Append(Reachable).Append("\n");
        sb.Append("  AddressOfRecord: ").Append(AddressOfRecord).Append("\n");
        sb.Append("  ContactAddresses: ").Append(ContactAddresses).Append("\n");
        sb.Append("  ReachableStateTime: ").Append(ReachableStateTime).Append("\n");
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
        return Equals(obj as PhoneChangeTopicLineStatus);
    }

    /// <summary>
    /// Returns true if PhoneChangeTopicLineStatus instances are equal
    /// </summary>
    /// <param name="other">Instance of PhoneChangeTopicLineStatus to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PhoneChangeTopicLineStatus other)
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
                Reachable == other.Reachable ||
                Reachable != null &&
                Reachable.Equals(other.Reachable)
            ) &&
            (
                AddressOfRecord == other.AddressOfRecord ||
                AddressOfRecord != null &&
                AddressOfRecord.Equals(other.AddressOfRecord)
            ) &&
            (
                ContactAddresses == other.ContactAddresses ||
                ContactAddresses != null &&
                ContactAddresses.SequenceEqual(other.ContactAddresses)
            ) &&
            (
                ReachableStateTime == other.ReachableStateTime ||
                ReachableStateTime != null &&
                ReachableStateTime.Equals(other.ReachableStateTime)
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

            if (Reachable != null)
            {
                hash = hash * 59 + Reachable.GetHashCode();
            }

            if (AddressOfRecord != null)
            {
                hash = hash * 59 + AddressOfRecord.GetHashCode();
            }

            if (ContactAddresses != null)
            {
                hash = hash * 59 + ContactAddresses.GetHashCode();
            }

            if (ReachableStateTime != null)
            {
                hash = hash * 59 + ReachableStateTime.GetHashCode();
            }

            return hash;
        }
    }
}
