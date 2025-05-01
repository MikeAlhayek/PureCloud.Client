using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DeleteProgramResponse
/// </summary>
[DataContract]
public partial class DeleteProgramResponse : IEquatable<DeleteProgramResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DeleteProgramResponse" /> class.
    /// </summary>
    /// <param name="TopicLinksJob">TopicLinksJob.</param>
    public DeleteProgramResponse(AddressableEntityRef TopicLinksJob = null)
    {
        this.TopicLinksJob = TopicLinksJob;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets TopicLinksJob
    /// </summary>
    [DataMember(Name = "topicLinksJob", EmitDefaultValue = false)]
    public AddressableEntityRef TopicLinksJob { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DeleteProgramResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  TopicLinksJob: ").Append(TopicLinksJob).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as DeleteProgramResponse);
    }

    /// <summary>
    /// Returns true if DeleteProgramResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of DeleteProgramResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DeleteProgramResponse other)
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
                TopicLinksJob == other.TopicLinksJob ||
                TopicLinksJob != null &&
                TopicLinksJob.Equals(other.TopicLinksJob)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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

            if (TopicLinksJob != null)
            {
                hash = hash * 59 + TopicLinksJob.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
