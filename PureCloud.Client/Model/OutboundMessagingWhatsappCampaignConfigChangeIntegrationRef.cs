using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// A reference for an WhatsApp integration
    /// </summary>
    [DataContract]
    public partial class OutboundMessagingWhatsappCampaignConfigChangeIntegrationRef :  IEquatable<OutboundMessagingWhatsappCampaignConfigChangeIntegrationRef>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OutboundMessagingWhatsappCampaignConfigChangeIntegrationRef" /> class.
        /// </summary>
        /// <param name="Id">The unique integration id.</param>
        public OutboundMessagingWhatsappCampaignConfigChangeIntegrationRef(string Id = null)
        {
            this.Id = Id;
            
        }
        


        /// <summary>
        /// The unique integration id
        /// </summary>
        /// <value>The unique integration id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutboundMessagingWhatsappCampaignConfigChangeIntegrationRef {\n");

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
            return this.Equals(obj as OutboundMessagingWhatsappCampaignConfigChangeIntegrationRef);
        }

        /// <summary>
        /// Returns true if OutboundMessagingWhatsappCampaignConfigChangeIntegrationRef instances are equal
        /// </summary>
        /// <param name="other">Instance of OutboundMessagingWhatsappCampaignConfigChangeIntegrationRef to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutboundMessagingWhatsappCampaignConfigChangeIntegrationRef other)
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
