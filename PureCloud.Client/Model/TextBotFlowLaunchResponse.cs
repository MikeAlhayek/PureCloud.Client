using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// Information related to a successful launch of a bot flow. The ID will be used in subsequent turn requests of the bot flow.
    /// </summary>
    [DataContract]
    public partial class TextBotFlowLaunchResponse :  IEquatable<TextBotFlowLaunchResponse>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="TextBotFlowLaunchResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TextBotFlowLaunchResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TextBotFlowLaunchResponse" /> class.
        /// </summary>
        /// <param name="Id">The session ID of the bot flow, used to send to subsequent turn requests (required).</param>
        public TextBotFlowLaunchResponse(string Id = null)
        {
            this.Id = Id;
            
        }
        


        /// <summary>
        /// The session ID of the bot flow, used to send to subsequent turn requests
        /// </summary>
        /// <value>The session ID of the bot flow, used to send to subsequent turn requests</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TextBotFlowLaunchResponse {\n");

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
            return this.Equals(obj as TextBotFlowLaunchResponse);
        }

        /// <summary>
        /// Returns true if TextBotFlowLaunchResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TextBotFlowLaunchResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TextBotFlowLaunchResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                return hash;
            }
        }
    }

}
