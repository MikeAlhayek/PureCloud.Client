using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContactImportJobRequest
/// </summary>

public partial class ContactImportJobRequest : IEquatable<ContactImportJobRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ContactImportJobRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ContactImportJobRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ContactImportJobRequest" /> class.
    /// </summary>
    /// <param name="SettingsId">Settings id (required).</param>
    public ContactImportJobRequest(string SettingsId = null)
    {
        this.SettingsId = SettingsId;

    }



    /// <summary>
    /// Settings id
    /// </summary>
    /// <value>Settings id</value>
    [JsonPropertyName("settingsId")]
    public string SettingsId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContactImportJobRequest {\n");

        sb.Append("  SettingsId: ").Append(SettingsId).Append("\n");
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
        return Equals(obj as ContactImportJobRequest);
    }

    /// <summary>
    /// Returns true if ContactImportJobRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of ContactImportJobRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContactImportJobRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                SettingsId == other.SettingsId ||
                SettingsId != null &&
                SettingsId.Equals(other.SettingsId)
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
            if (SettingsId != null)
            {
                hash = hash * 59 + SettingsId.GetHashCode();
            }

            return hash;
        }
    }
}
