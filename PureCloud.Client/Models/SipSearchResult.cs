using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SipSearchResult
/// </summary>
[DataContract]
public partial class SipSearchResult : IEquatable<SipSearchResult>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SipSearchResult" /> class.
    /// </summary>
    /// <param name="Status">Status of the search request.</param>
    /// <param name="Sid">Session id associated to the search request.</param>
    /// <param name="Auth">Auth token used for this search request.</param>
    /// <param name="Message">Any messages returned from homer as part of the response.</param>
    /// <param name="Data">Homer search data that is returned.</param>
    /// <param name="Count">Number of records returned.</param>
    public SipSearchResult(int? Status = null, string Sid = null, string Auth = null, string Message = null, List<HomerRecord> Data = null, int? Count = null)
    {
        this.Status = Status;
        this.Sid = Sid;
        this.Auth = Auth;
        this.Message = Message;
        this.Data = Data;
        this.Count = Count;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// Status of the search request
    /// </summary>
    /// <value>Status of the search request</value>
    [DataMember(Name = "status", EmitDefaultValue = false)]
    public int? Status { get; set; }



    /// <summary>
    /// Session id associated to the search request
    /// </summary>
    /// <value>Session id associated to the search request</value>
    [DataMember(Name = "sid", EmitDefaultValue = false)]
    public string Sid { get; set; }



    /// <summary>
    /// Auth token used for this search request
    /// </summary>
    /// <value>Auth token used for this search request</value>
    [DataMember(Name = "auth", EmitDefaultValue = false)]
    public string Auth { get; set; }



    /// <summary>
    /// Any messages returned from homer as part of the response
    /// </summary>
    /// <value>Any messages returned from homer as part of the response</value>
    [DataMember(Name = "message", EmitDefaultValue = false)]
    public string Message { get; set; }



    /// <summary>
    /// Homer search data that is returned
    /// </summary>
    /// <value>Homer search data that is returned</value>
    [DataMember(Name = "data", EmitDefaultValue = false)]
    public List<HomerRecord> Data { get; set; }



    /// <summary>
    /// Number of records returned
    /// </summary>
    /// <value>Number of records returned</value>
    [DataMember(Name = "count", EmitDefaultValue = false)]
    public int? Count { get; set; }



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
        sb.Append("class SipSearchResult {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Sid: ").Append(Sid).Append("\n");
        sb.Append("  Auth: ").Append(Auth).Append("\n");
        sb.Append("  Message: ").Append(Message).Append("\n");
        sb.Append("  Data: ").Append(Data).Append("\n");
        sb.Append("  Count: ").Append(Count).Append("\n");
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
        return Equals(obj as SipSearchResult);
    }

    /// <summary>
    /// Returns true if SipSearchResult instances are equal
    /// </summary>
    /// <param name="other">Instance of SipSearchResult to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SipSearchResult other)
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
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                Sid == other.Sid ||
                Sid != null &&
                Sid.Equals(other.Sid)
            ) &&
            (
                Auth == other.Auth ||
                Auth != null &&
                Auth.Equals(other.Auth)
            ) &&
            (
                Message == other.Message ||
                Message != null &&
                Message.Equals(other.Message)
            ) &&
            (
                Data == other.Data ||
                Data != null &&
                Data.SequenceEqual(other.Data)
            ) &&
            (
                Count == other.Count ||
                Count != null &&
                Count.Equals(other.Count)
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

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (Sid != null)
            {
                hash = hash * 59 + Sid.GetHashCode();
            }

            if (Auth != null)
            {
                hash = hash * 59 + Auth.GetHashCode();
            }

            if (Message != null)
            {
                hash = hash * 59 + Message.GetHashCode();
            }

            if (Data != null)
            {
                hash = hash * 59 + Data.GetHashCode();
            }

            if (Count != null)
            {
                hash = hash * 59 + Count.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
