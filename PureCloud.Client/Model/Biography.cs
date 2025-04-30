using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// Biography
/// </summary>
[DataContract]
public partial class Biography : IEquatable<Biography>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Biography" /> class.
    /// </summary>
    /// <param name="_Biography">Personal detailed description.</param>
    /// <param name="Interests">Interests.</param>
    /// <param name="Hobbies">Hobbies.</param>
    /// <param name="Spouse">Spouse.</param>
    /// <param name="Education">User education details.</param>
    public Biography(string _Biography = null, List<string> Interests = null, List<string> Hobbies = null, string Spouse = null, List<Education> Education = null)
    {
        this._Biography = _Biography;
        this.Interests = Interests;
        this.Hobbies = Hobbies;
        this.Spouse = Spouse;
        this.Education = Education;

    }



    /// <summary>
    /// Personal detailed description
    /// </summary>
    /// <value>Personal detailed description</value>
    [DataMember(Name = "biography", EmitDefaultValue = false)]
    public string _Biography { get; set; }



    /// <summary>
    /// Gets or Sets Interests
    /// </summary>
    [DataMember(Name = "interests", EmitDefaultValue = false)]
    public List<string> Interests { get; set; }



    /// <summary>
    /// Gets or Sets Hobbies
    /// </summary>
    [DataMember(Name = "hobbies", EmitDefaultValue = false)]
    public List<string> Hobbies { get; set; }



    /// <summary>
    /// Gets or Sets Spouse
    /// </summary>
    [DataMember(Name = "spouse", EmitDefaultValue = false)]
    public string Spouse { get; set; }



    /// <summary>
    /// User education details
    /// </summary>
    /// <value>User education details</value>
    [DataMember(Name = "education", EmitDefaultValue = false)]
    public List<Education> Education { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Biography {\n");

        sb.Append("  _Biography: ").Append(_Biography).Append("\n");
        sb.Append("  Interests: ").Append(Interests).Append("\n");
        sb.Append("  Hobbies: ").Append(Hobbies).Append("\n");
        sb.Append("  Spouse: ").Append(Spouse).Append("\n");
        sb.Append("  Education: ").Append(Education).Append("\n");
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
        return this.Equals(obj as Biography);
    }

    /// <summary>
    /// Returns true if Biography instances are equal
    /// </summary>
    /// <param name="other">Instance of Biography to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Biography other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this._Biography == other._Biography ||
                this._Biography != null &&
                this._Biography.Equals(other._Biography)
            ) &&
            (
                this.Interests == other.Interests ||
                this.Interests != null &&
                this.Interests.SequenceEqual(other.Interests)
            ) &&
            (
                this.Hobbies == other.Hobbies ||
                this.Hobbies != null &&
                this.Hobbies.SequenceEqual(other.Hobbies)
            ) &&
            (
                this.Spouse == other.Spouse ||
                this.Spouse != null &&
                this.Spouse.Equals(other.Spouse)
            ) &&
            (
                this.Education == other.Education ||
                this.Education != null &&
                this.Education.SequenceEqual(other.Education)
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
            if (this._Biography != null)
            {
                hash = hash * 59 + this._Biography.GetHashCode();
            }

            if (this.Interests != null)
            {
                hash = hash * 59 + this.Interests.GetHashCode();
            }

            if (this.Hobbies != null)
            {
                hash = hash * 59 + this.Hobbies.GetHashCode();
            }

            if (this.Spouse != null)
            {
                hash = hash * 59 + this.Spouse.GetHashCode();
            }

            if (this.Education != null)
            {
                hash = hash * 59 + this.Education.GetHashCode();
            }

            return hash;
        }
    }
}
