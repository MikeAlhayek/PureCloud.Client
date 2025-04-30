using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// ConversationUserDisposition
    /// </summary>
    [DataContract]
    public partial class ConversationUserDisposition :  IEquatable<ConversationUserDisposition>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationUserDisposition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConversationUserDisposition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationUserDisposition" /> class.
        /// </summary>
        /// <param name="Code">User-defined wrap-up code for the conversation. (required).</param>
        /// <param name="Notes">Text entered by the user to describe the call or disposition..</param>
        public ConversationUserDisposition(string Code = null, string Notes = null)
        {
            this.Code = Code;
            this.Notes = Notes;
            
        }
        


        /// <summary>
        /// User-defined wrap-up code for the conversation.
        /// </summary>
        /// <value>User-defined wrap-up code for the conversation.</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }



        /// <summary>
        /// Text entered by the user to describe the call or disposition.
        /// </summary>
        /// <value>Text entered by the user to describe the call or disposition.</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }



        /// <summary>
        /// The user that wrapped up the conversation.
        /// </summary>
        /// <value>The user that wrapped up the conversation.</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public AddressableEntityRef User { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationUserDisposition {\n");

            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return this.Equals(obj as ConversationUserDisposition);
        }

        /// <summary>
        /// Returns true if ConversationUserDisposition instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationUserDisposition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationUserDisposition other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) &&
                (
                    this.Notes == other.Notes ||
                    this.Notes != null &&
                    this.Notes.Equals(other.Notes)
                ) &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
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
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();

                if (this.Notes != null)
                    hash = hash * 59 + this.Notes.GetHashCode();

                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();

                return hash;
            }
        }
    }

}
