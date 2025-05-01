using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// NluConfusionMatrixRow
/// </summary>
[DataContract]
public partial class NluConfusionMatrixRow : IEquatable<NluConfusionMatrixRow>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="NluConfusionMatrixRow" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected NluConfusionMatrixRow() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="NluConfusionMatrixRow" /> class.
    /// </summary>
    /// <param name="Name">The name of the intent for the row. (required).</param>
    /// <param name="Columns">The columns of confusion matrix for the intent (required).</param>
    public NluConfusionMatrixRow(string Name = null, List<NluConfusionMatrixColumn> Columns = null)
    {
        this.Name = Name;
        this.Columns = Columns;

    }



    /// <summary>
    /// The name of the intent for the row.
    /// </summary>
    /// <value>The name of the intent for the row.</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The columns of confusion matrix for the intent
    /// </summary>
    /// <value>The columns of confusion matrix for the intent</value>
    [DataMember(Name = "columns", EmitDefaultValue = false)]
    public List<NluConfusionMatrixColumn> Columns { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class NluConfusionMatrixRow {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Columns: ").Append(Columns).Append("\n");
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
        return Equals(obj as NluConfusionMatrixRow);
    }

    /// <summary>
    /// Returns true if NluConfusionMatrixRow instances are equal
    /// </summary>
    /// <param name="other">Instance of NluConfusionMatrixRow to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(NluConfusionMatrixRow other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Columns == other.Columns ||
                Columns != null &&
                Columns.SequenceEqual(other.Columns)
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
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Columns != null)
            {
                hash = hash * 59 + Columns.GetHashCode();
            }

            return hash;
        }
    }
}
