using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// Signature
    /// </summary>
    [DataContract]
    public partial class Signature :  IEquatable<Signature>
    {
        /// <summary>
        /// The configuration to indicate when the signature of a conversation has to be included
        /// </summary>
        /// <value>The configuration to indicate when the signature of a conversation has to be included</value>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public enum InclusionTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Draft for "Draft"
            /// </summary>
            [EnumMember(Value = "Draft")]
            Draft,
            
            /// <summary>
            /// Enum Send for "Send"
            /// </summary>
            [EnumMember(Value = "Send")]
            Send,
            
            /// <summary>
            /// Enum Sendonce for "SendOnce"
            /// </summary>
            [EnumMember(Value = "SendOnce")]
            Sendonce
        }
        /// <summary>
        /// The configuration to indicate when the signature of a conversation has to be included
        /// </summary>
        /// <value>The configuration to indicate when the signature of a conversation has to be included</value>
        [DataMember(Name="inclusionType", EmitDefaultValue=false)]
        public InclusionTypeEnum? InclusionType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Signature" /> class.
        /// </summary>
        /// <param name="Enabled">A toggle to enable the signature on email send..</param>
        /// <param name="CannedResponseId">The identifier referring to an email signature canned response..</param>
        /// <param name="AlwaysIncluded">A toggle that defines if a signature is always included or only set on the first email in an email chain..</param>
        /// <param name="InclusionType">The configuration to indicate when the signature of a conversation has to be included.</param>
        public Signature(bool? Enabled = null, string CannedResponseId = null, bool? AlwaysIncluded = null, InclusionTypeEnum? InclusionType = null)
        {
            this.Enabled = Enabled;
            this.CannedResponseId = CannedResponseId;
            this.AlwaysIncluded = AlwaysIncluded;
            this.InclusionType = InclusionType;
            
        }
        


        /// <summary>
        /// A toggle to enable the signature on email send.
        /// </summary>
        /// <value>A toggle to enable the signature on email send.</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }



        /// <summary>
        /// The identifier referring to an email signature canned response.
        /// </summary>
        /// <value>The identifier referring to an email signature canned response.</value>
        [DataMember(Name="cannedResponseId", EmitDefaultValue=false)]
        public string CannedResponseId { get; set; }



        /// <summary>
        /// A toggle that defines if a signature is always included or only set on the first email in an email chain.
        /// </summary>
        /// <value>A toggle that defines if a signature is always included or only set on the first email in an email chain.</value>
        [DataMember(Name="alwaysIncluded", EmitDefaultValue=false)]
        public bool? AlwaysIncluded { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Signature {\n");

            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  CannedResponseId: ").Append(CannedResponseId).Append("\n");
            sb.Append("  AlwaysIncluded: ").Append(AlwaysIncluded).Append("\n");
            sb.Append("  InclusionType: ").Append(InclusionType).Append("\n");
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
            return this.Equals(obj as Signature);
        }

        /// <summary>
        /// Returns true if Signature instances are equal
        /// </summary>
        /// <param name="other">Instance of Signature to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Signature other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.CannedResponseId == other.CannedResponseId ||
                    this.CannedResponseId != null &&
                    this.CannedResponseId.Equals(other.CannedResponseId)
                ) &&
                (
                    this.AlwaysIncluded == other.AlwaysIncluded ||
                    this.AlwaysIncluded != null &&
                    this.AlwaysIncluded.Equals(other.AlwaysIncluded)
                ) &&
                (
                    this.InclusionType == other.InclusionType ||
                    this.InclusionType != null &&
                    this.InclusionType.Equals(other.InclusionType)
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
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();

                if (this.CannedResponseId != null)
                    hash = hash * 59 + this.CannedResponseId.GetHashCode();

                if (this.AlwaysIncluded != null)
                    hash = hash * 59 + this.AlwaysIncluded.GetHashCode();

                if (this.InclusionType != null)
                    hash = hash * 59 + this.InclusionType.GetHashCode();

                return hash;
            }
        }
    }

}
