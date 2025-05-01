using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// RecordingAnnotationFlow
/// </summary>
[DataContract]
public partial class RecordingAnnotationFlow : IEquatable<RecordingAnnotationFlow>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="RecordingAnnotationFlow" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected RecordingAnnotationFlow() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="RecordingAnnotationFlow" /> class.
    /// </summary>
    /// <param name="Name">The flow name (required).</param>
    /// <param name="Id">The flow Id (required).</param>
    public RecordingAnnotationFlow(string Name = null, string Id = null)
    {
        this.Name = Name;
        this.Id = Id;

    }



    /// <summary>
    /// The flow name
    /// </summary>
    /// <value>The flow name</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The flow Id
    /// </summary>
    /// <value>The flow Id</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class RecordingAnnotationFlow {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
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
        return this.Equals(obj as RecordingAnnotationFlow);
    }

    /// <summary>
    /// Returns true if RecordingAnnotationFlow instances are equal
    /// </summary>
    /// <param name="other">Instance of RecordingAnnotationFlow to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RecordingAnnotationFlow other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Name == other.Name ||
                this.Name != null &&
                this.Name.Equals(other.Name)
            ) &&
            (
                this.Id == other.Id ||
                this.Id != null &&
                this.Id.Equals(other.Id)
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
            if (this.Name != null)
            {
                hash = hash * 59 + this.Name.GetHashCode();
            }

            if (this.Id != null)
            {
                hash = hash * 59 + this.Id.GetHashCode();
            }

            return hash;
        }
    }
}
