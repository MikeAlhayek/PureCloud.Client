using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// Update coaching appointment request
    /// </summary>
    [DataContract]
    public partial class AddConversationRequest : IEquatable<AddConversationRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AddConversationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddConversationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddConversationRequest" /> class.
        /// </summary>
        /// <param name="ConversationId">The id of the conversation to add (required).</param>
        public AddConversationRequest(string ConversationId = null)
        {
            this.ConversationId = ConversationId;

        }



        /// <summary>
        /// The id of the conversation to add
        /// </summary>
        /// <value>The id of the conversation to add</value>
        [DataMember(Name = "conversationId", EmitDefaultValue = false)]
        public string ConversationId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddConversationRequest {\n");

            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
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
            return this.Equals(obj as AddConversationRequest);
        }

        /// <summary>
        /// Returns true if AddConversationRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of AddConversationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddConversationRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ConversationId == other.ConversationId ||
                    this.ConversationId != null &&
                    this.ConversationId.Equals(other.ConversationId)
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
                if (this.ConversationId != null)
                    hash = hash * 59 + this.ConversationId.GetHashCode();

                return hash;
            }
        }
    }

}
