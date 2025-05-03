using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PersistentConnectionChangeTopicErrorLocation
/// </summary>

public partial class PersistentConnectionChangeTopicErrorLocation : IEquatable<PersistentConnectionChangeTopicErrorLocation>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PersistentConnectionChangeTopicErrorLocation" /> class.
    /// </summary>
    /// <param name="Function">Function.</param>
    /// <param name="FileID">FileID.</param>
    /// <param name="Line">Line.</param>
    public PersistentConnectionChangeTopicErrorLocation(string Function = null, string FileID = null, long? Line = null)
    {
        this.Function = Function;
        this.FileID = FileID;
        this.Line = Line;

    }



    /// <summary>
    /// Gets or Sets Function
    /// </summary>
    [JsonPropertyName("function")]
    public string Function { get; set; }



    /// <summary>
    /// Gets or Sets FileID
    /// </summary>
    [JsonPropertyName("fileID")]
    public string FileID { get; set; }



    /// <summary>
    /// Gets or Sets Line
    /// </summary>
    [JsonPropertyName("line")]
    public long? Line { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PersistentConnectionChangeTopicErrorLocation {\n");

        sb.Append("  Function: ").Append(Function).Append("\n");
        sb.Append("  FileID: ").Append(FileID).Append("\n");
        sb.Append("  Line: ").Append(Line).Append("\n");
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
        return Equals(obj as PersistentConnectionChangeTopicErrorLocation);
    }

    /// <summary>
    /// Returns true if PersistentConnectionChangeTopicErrorLocation instances are equal
    /// </summary>
    /// <param name="other">Instance of PersistentConnectionChangeTopicErrorLocation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PersistentConnectionChangeTopicErrorLocation other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Function == other.Function ||
                Function != null &&
                Function.Equals(other.Function)
            ) &&
            (
                FileID == other.FileID ||
                FileID != null &&
                FileID.Equals(other.FileID)
            ) &&
            (
                Line == other.Line ||
                Line != null &&
                Line.Equals(other.Line)
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
            if (Function != null)
            {
                hash = hash * 59 + Function.GetHashCode();
            }

            if (FileID != null)
            {
                hash = hash * 59 + FileID.GetHashCode();
            }

            if (Line != null)
            {
                hash = hash * 59 + Line.GetHashCode();
            }

            return hash;
        }
    }
}
