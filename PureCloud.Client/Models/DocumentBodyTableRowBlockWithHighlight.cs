using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DocumentBodyTableRowBlockWithHighlight
/// </summary>
[DataContract]
public partial class DocumentBodyTableRowBlockWithHighlight : IEquatable<DocumentBodyTableRowBlockWithHighlight>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="DocumentBodyTableRowBlockWithHighlight" /> class.
    /// </summary>
    [JsonConstructor]
    protected DocumentBodyTableRowBlockWithHighlight() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="DocumentBodyTableRowBlockWithHighlight" /> class.
    /// </summary>
    /// <param name="Properties">The properties for the table rows..</param>
    /// <param name="Cells">The list of cells for the table. (required).</param>
    public DocumentBodyTableRowBlockWithHighlight(DocumentBodyTableRowBlockProperties Properties = null, List<DocumentBodyTableCellBlockWithHighlight> Cells = null)
    {
        this.Properties = Properties;
        this.Cells = Cells;

    }



    /// <summary>
    /// The properties for the table rows.
    /// </summary>
    /// <value>The properties for the table rows.</value>
    [DataMember(Name = "properties", EmitDefaultValue = false)]
    public DocumentBodyTableRowBlockProperties Properties { get; set; }



    /// <summary>
    /// The list of cells for the table.
    /// </summary>
    /// <value>The list of cells for the table.</value>
    [DataMember(Name = "cells", EmitDefaultValue = false)]
    public List<DocumentBodyTableCellBlockWithHighlight> Cells { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DocumentBodyTableRowBlockWithHighlight {\n");

        sb.Append("  Properties: ").Append(Properties).Append("\n");
        sb.Append("  Cells: ").Append(Cells).Append("\n");
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
        return Equals(obj as DocumentBodyTableRowBlockWithHighlight);
    }

    /// <summary>
    /// Returns true if DocumentBodyTableRowBlockWithHighlight instances are equal
    /// </summary>
    /// <param name="other">Instance of DocumentBodyTableRowBlockWithHighlight to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DocumentBodyTableRowBlockWithHighlight other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Properties == other.Properties ||
                Properties != null &&
                Properties.Equals(other.Properties)
            ) &&
            (
                Cells == other.Cells ||
                Cells != null &&
                Cells.SequenceEqual(other.Cells)
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
            if (Properties != null)
            {
                hash = hash * 59 + Properties.GetHashCode();
            }

            if (Cells != null)
            {
                hash = hash * 59 + Cells.GetHashCode();
            }

            return hash;
        }
    }
}
