using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BulkCallbackPatchRequest
/// </summary>
[DataContract]
public partial class BulkCallbackPatchRequest : IEquatable<BulkCallbackPatchRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="BulkCallbackPatchRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected BulkCallbackPatchRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="BulkCallbackPatchRequest" /> class.
    /// </summary>
    /// <param name="PatchCallbackRequests">The list of requests to update callbacks in bulk (required).</param>
    public BulkCallbackPatchRequest(List<PatchCallbackRequest> PatchCallbackRequests = null)
    {
        this.PatchCallbackRequests = PatchCallbackRequests;

    }



    /// <summary>
    /// The list of requests to update callbacks in bulk
    /// </summary>
    /// <value>The list of requests to update callbacks in bulk</value>
    [DataMember(Name = "patchCallbackRequests", EmitDefaultValue = false)]
    public List<PatchCallbackRequest> PatchCallbackRequests { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BulkCallbackPatchRequest {\n");

        sb.Append("  PatchCallbackRequests: ").Append(PatchCallbackRequests).Append("\n");
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
        return Equals(obj as BulkCallbackPatchRequest);
    }

    /// <summary>
    /// Returns true if BulkCallbackPatchRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of BulkCallbackPatchRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BulkCallbackPatchRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                PatchCallbackRequests == other.PatchCallbackRequests ||
                PatchCallbackRequests != null &&
                PatchCallbackRequests.SequenceEqual(other.PatchCallbackRequests)
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
            if (PatchCallbackRequests != null)
            {
                hash = hash * 59 + PatchCallbackRequests.GetHashCode();
            }

            return hash;
        }
    }
}
