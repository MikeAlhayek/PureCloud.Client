using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeParseRecord
/// </summary>
[DataContract]
public partial class KnowledgeParseRecord : IEquatable<KnowledgeParseRecord>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeParseRecord" /> class.
    /// </summary>
    /// <param name="Id">Unique id for the parsed data..</param>
    /// <param name="Title">Parsed article title..</param>
    /// <param name="Body">Parsed article content..</param>
    public KnowledgeParseRecord(string Id = null, string Title = null, DocumentBody Body = null)
    {
        this.Id = Id;
        this.Title = Title;
        this.Body = Body;

    }



    /// <summary>
    /// Unique id for the parsed data.
    /// </summary>
    /// <value>Unique id for the parsed data.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Parsed article title.
    /// </summary>
    /// <value>Parsed article title.</value>
    [DataMember(Name = "title", EmitDefaultValue = false)]
    public string Title { get; set; }



    /// <summary>
    /// Parsed article content.
    /// </summary>
    /// <value>Parsed article content.</value>
    [DataMember(Name = "body", EmitDefaultValue = false)]
    public DocumentBody Body { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeParseRecord {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Title: ").Append(Title).Append("\n");
        sb.Append("  Body: ").Append(Body).Append("\n");
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
        return Equals(obj as KnowledgeParseRecord);
    }

    /// <summary>
    /// Returns true if KnowledgeParseRecord instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeParseRecord to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeParseRecord other)
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
                Title == other.Title ||
                Title != null &&
                Title.Equals(other.Title)
            ) &&
            (
                Body == other.Body ||
                Body != null &&
                Body.Equals(other.Body)
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

            if (Title != null)
            {
                hash = hash * 59 + Title.GetHashCode();
            }

            if (Body != null)
            {
                hash = hash * 59 + Body.GetHashCode();
            }

            return hash;
        }
    }
}
