using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AdditionalLanguagesIntent
/// </summary>
[DataContract]
public partial class AdditionalLanguagesIntent : IEquatable<AdditionalLanguagesIntent>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AdditionalLanguagesIntent" /> class.
    /// </summary>
    /// <param name="Utterances">Utterances list for additional language.</param>
    public AdditionalLanguagesIntent(List<NluUtterance> Utterances = null)
    {
        this.Utterances = Utterances;

    }



    /// <summary>
    /// ID of the intent for respective additional language
    /// </summary>
    /// <value>ID of the intent for respective additional language</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// Utterances list for additional language
    /// </summary>
    /// <value>Utterances list for additional language</value>
    [DataMember(Name = "utterances", EmitDefaultValue = false)]
    public List<NluUtterance> Utterances { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AdditionalLanguagesIntent {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Utterances: ").Append(Utterances).Append("\n");
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
        return Equals(obj as AdditionalLanguagesIntent);
    }

    /// <summary>
    /// Returns true if AdditionalLanguagesIntent instances are equal
    /// </summary>
    /// <param name="other">Instance of AdditionalLanguagesIntent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AdditionalLanguagesIntent other)
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
                Utterances == other.Utterances ||
                Utterances != null &&
                Utterances.SequenceEqual(other.Utterances)
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

            if (Utterances != null)
            {
                hash = hash * 59 + Utterances.GetHashCode();
            }

            return hash;
        }
    }
}
