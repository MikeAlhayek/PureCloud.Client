using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// DialerCampaignProgressEventObject
    /// </summary>
    [DataContract]
    public partial class DialerCampaignProgressEventObject :  IEquatable<DialerCampaignProgressEventObject>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialerCampaignProgressEventObject" /> class.
        /// </summary>
        public DialerCampaignProgressEventObject()
        {
            
        }
        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DialerCampaignProgressEventObject {\n");

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
            return this.Equals(obj as DialerCampaignProgressEventObject);
        }

        /// <summary>
        /// Returns true if DialerCampaignProgressEventObject instances are equal
        /// </summary>
        /// <param name="other">Instance of DialerCampaignProgressEventObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DialerCampaignProgressEventObject other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true && false;
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
                return hash;
            }
        }
    }

}
