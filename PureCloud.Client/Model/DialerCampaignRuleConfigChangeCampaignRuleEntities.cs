using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// DialerCampaignRuleConfigChangeCampaignRuleEntities
    /// </summary>
    [DataContract]
    public partial class DialerCampaignRuleConfigChangeCampaignRuleEntities :  IEquatable<DialerCampaignRuleConfigChangeCampaignRuleEntities>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialerCampaignRuleConfigChangeCampaignRuleEntities" /> class.
        /// </summary>
        /// <param name="Campaigns">A list of campaignIds to act on.</param>
        /// <param name="Sequences">A list of sequenceIds to act on.</param>
        public DialerCampaignRuleConfigChangeCampaignRuleEntities(List<DialerCampaignRuleConfigChangeUriReference> Campaigns = null, List<DialerCampaignRuleConfigChangeUriReference> Sequences = null)
        {
            this.Campaigns = Campaigns;
            this.Sequences = Sequences;
            
        }
        


        /// <summary>
        /// A list of campaignIds to act on
        /// </summary>
        /// <value>A list of campaignIds to act on</value>
        [DataMember(Name="campaigns", EmitDefaultValue=false)]
        public List<DialerCampaignRuleConfigChangeUriReference> Campaigns { get; set; }



        /// <summary>
        /// A list of sequenceIds to act on
        /// </summary>
        /// <value>A list of sequenceIds to act on</value>
        [DataMember(Name="sequences", EmitDefaultValue=false)]
        public List<DialerCampaignRuleConfigChangeUriReference> Sequences { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DialerCampaignRuleConfigChangeCampaignRuleEntities {\n");

            sb.Append("  Campaigns: ").Append(Campaigns).Append("\n");
            sb.Append("  Sequences: ").Append(Sequences).Append("\n");
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
            return this.Equals(obj as DialerCampaignRuleConfigChangeCampaignRuleEntities);
        }

        /// <summary>
        /// Returns true if DialerCampaignRuleConfigChangeCampaignRuleEntities instances are equal
        /// </summary>
        /// <param name="other">Instance of DialerCampaignRuleConfigChangeCampaignRuleEntities to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DialerCampaignRuleConfigChangeCampaignRuleEntities other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Campaigns == other.Campaigns ||
                    this.Campaigns != null &&
                    this.Campaigns.SequenceEqual(other.Campaigns)
                ) &&
                (
                    this.Sequences == other.Sequences ||
                    this.Sequences != null &&
                    this.Sequences.SequenceEqual(other.Sequences)
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
                if (this.Campaigns != null)
                    hash = hash * 59 + this.Campaigns.GetHashCode();

                if (this.Sequences != null)
                    hash = hash * 59 + this.Sequences.GetHashCode();

                return hash;
            }
        }
    }

}
