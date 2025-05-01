using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Detailed information about an error response.
/// </summary>
[DataContract]
public partial class ConversationEventTopicErrorDetails : IEquatable<ConversationEventTopicErrorDetails>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationEventTopicErrorDetails" /> class.
    /// </summary>
    /// <param name="Status">The HTTP status code for this message (400, 401, 403, 404, 500, etc..</param>
    /// <param name="Code">A code unique to this error..</param>
    /// <param name="Message">Friendly description of this error..</param>
    /// <param name="MessageWithParams">This is the same as message except it uses template fields for variable replacement. For instance: &#39;User {username} was not found&#39;.</param>
    /// <param name="MessageParams">Used in conjunction with messageWithParams. These are the template parameters. For instance: UserParam.key &#x3D; &#39;username&#39;, UserParam.value &#x3D; &#39;john.doe&#39;.</param>
    /// <param name="ContextId">The correlation Id or context Id for this message. If left blank the Public API will look at the HTTP response header &#39;ININ-Correlation-Id&#39; instead..</param>
    /// <param name="Uri">Uri.</param>
    public ConversationEventTopicErrorDetails(long? Status = null, string Code = null, string Message = null, string MessageWithParams = null, Dictionary<string, string> MessageParams = null, string ContextId = null, string Uri = null)
    {
        this.Status = Status;
        this.Code = Code;
        this.Message = Message;
        this.MessageWithParams = MessageWithParams;
        this.MessageParams = MessageParams;
        this.ContextId = ContextId;
        this.Uri = Uri;

    }



    /// <summary>
    /// The HTTP status code for this message (400, 401, 403, 404, 500, etc.
    /// </summary>
    /// <value>The HTTP status code for this message (400, 401, 403, 404, 500, etc.</value>
    [DataMember(Name = "status", EmitDefaultValue = false)]
    public long? Status { get; set; }



    /// <summary>
    /// A code unique to this error.
    /// </summary>
    /// <value>A code unique to this error.</value>
    [DataMember(Name = "code", EmitDefaultValue = false)]
    public string Code { get; set; }



    /// <summary>
    /// Friendly description of this error.
    /// </summary>
    /// <value>Friendly description of this error.</value>
    [DataMember(Name = "message", EmitDefaultValue = false)]
    public string Message { get; set; }



    /// <summary>
    /// This is the same as message except it uses template fields for variable replacement. For instance: &#39;User {username} was not found&#39;
    /// </summary>
    /// <value>This is the same as message except it uses template fields for variable replacement. For instance: &#39;User {username} was not found&#39;</value>
    [DataMember(Name = "messageWithParams", EmitDefaultValue = false)]
    public string MessageWithParams { get; set; }



    /// <summary>
    /// Used in conjunction with messageWithParams. These are the template parameters. For instance: UserParam.key &#x3D; &#39;username&#39;, UserParam.value &#x3D; &#39;john.doe&#39;
    /// </summary>
    /// <value>Used in conjunction with messageWithParams. These are the template parameters. For instance: UserParam.key &#x3D; &#39;username&#39;, UserParam.value &#x3D; &#39;john.doe&#39;</value>
    [DataMember(Name = "messageParams", EmitDefaultValue = false)]
    public Dictionary<string, string> MessageParams { get; set; }



    /// <summary>
    /// The correlation Id or context Id for this message. If left blank the Public API will look at the HTTP response header &#39;ININ-Correlation-Id&#39; instead.
    /// </summary>
    /// <value>The correlation Id or context Id for this message. If left blank the Public API will look at the HTTP response header &#39;ININ-Correlation-Id&#39; instead.</value>
    [DataMember(Name = "contextId", EmitDefaultValue = false)]
    public string ContextId { get; set; }



    /// <summary>
    /// Gets or Sets Uri
    /// </summary>
    [DataMember(Name = "uri", EmitDefaultValue = false)]
    public string Uri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationEventTopicErrorDetails {\n");

        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Code: ").Append(Code).Append("\n");
        sb.Append("  Message: ").Append(Message).Append("\n");
        sb.Append("  MessageWithParams: ").Append(MessageWithParams).Append("\n");
        sb.Append("  MessageParams: ").Append(MessageParams).Append("\n");
        sb.Append("  ContextId: ").Append(ContextId).Append("\n");
        sb.Append("  Uri: ").Append(Uri).Append("\n");
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
        return Equals(obj as ConversationEventTopicErrorDetails);
    }

    /// <summary>
    /// Returns true if ConversationEventTopicErrorDetails instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationEventTopicErrorDetails to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationEventTopicErrorDetails other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                Code == other.Code ||
                Code != null &&
                Code.Equals(other.Code)
            ) &&
            (
                Message == other.Message ||
                Message != null &&
                Message.Equals(other.Message)
            ) &&
            (
                MessageWithParams == other.MessageWithParams ||
                MessageWithParams != null &&
                MessageWithParams.Equals(other.MessageWithParams)
            ) &&
            (
                MessageParams == other.MessageParams ||
                MessageParams != null &&
                MessageParams.SequenceEqual(other.MessageParams)
            ) &&
            (
                ContextId == other.ContextId ||
                ContextId != null &&
                ContextId.Equals(other.ContextId)
            ) &&
            (
                Uri == other.Uri ||
                Uri != null &&
                Uri.Equals(other.Uri)
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
            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (Code != null)
            {
                hash = hash * 59 + Code.GetHashCode();
            }

            if (Message != null)
            {
                hash = hash * 59 + Message.GetHashCode();
            }

            if (MessageWithParams != null)
            {
                hash = hash * 59 + MessageWithParams.GetHashCode();
            }

            if (MessageParams != null)
            {
                hash = hash * 59 + MessageParams.GetHashCode();
            }

            if (ContextId != null)
            {
                hash = hash * 59 + ContextId.GetHashCode();
            }

            if (Uri != null)
            {
                hash = hash * 59 + Uri.GetHashCode();
            }

            return hash;
        }
    }
}
