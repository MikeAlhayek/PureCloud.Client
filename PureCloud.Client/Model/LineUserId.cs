using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// Channel-specific User ID for Line accounts
    /// </summary>
    [DataContract]
    public partial class LineUserId :  IEquatable<LineUserId>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LineUserId" /> class.
        /// </summary>
        /// <param name="UserId">The unique channel-specific userId for the user.</param>
        public LineUserId(string UserId = null)
        {
            this.UserId = UserId;
            
        }
        


        /// <summary>
        /// The unique channel-specific userId for the user
        /// </summary>
        /// <value>The unique channel-specific userId for the user</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LineUserId {\n");

            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(obj as LineUserId);
        }

        /// <summary>
        /// Returns true if LineUserId instances are equal
        /// </summary>
        /// <param name="other">Instance of LineUserId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LineUserId other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
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
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();

                return hash;
            }
        }
    }

}
