using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// A subset of the Journey System&#39;s customer data at a point-in-time (for external linkage and internal usage/context)
    /// </summary>
    [DataContract]
    public partial class ConversationVideoEventTopicJourneyCustomer :  IEquatable<ConversationVideoEventTopicJourneyCustomer>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationVideoEventTopicJourneyCustomer" /> class.
        /// </summary>
        /// <param name="Id">An ID of a customer within the Journey System at a point-in-time.  Note that a customer entity can have multiple customerIds based on the stitching process.  Depending on the context within the PureCloud conversation, this may or may not be mutable..</param>
        /// <param name="IdType">The type of the customerId within the Journey System (e.g. cookie)..</param>
        public ConversationVideoEventTopicJourneyCustomer(string Id = null, string IdType = null)
        {
            this.Id = Id;
            this.IdType = IdType;
            
        }
        


        /// <summary>
        /// An ID of a customer within the Journey System at a point-in-time.  Note that a customer entity can have multiple customerIds based on the stitching process.  Depending on the context within the PureCloud conversation, this may or may not be mutable.
        /// </summary>
        /// <value>An ID of a customer within the Journey System at a point-in-time.  Note that a customer entity can have multiple customerIds based on the stitching process.  Depending on the context within the PureCloud conversation, this may or may not be mutable.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The type of the customerId within the Journey System (e.g. cookie).
        /// </summary>
        /// <value>The type of the customerId within the Journey System (e.g. cookie).</value>
        [DataMember(Name="idType", EmitDefaultValue=false)]
        public string IdType { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationVideoEventTopicJourneyCustomer {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdType: ").Append(IdType).Append("\n");
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
            return this.Equals(obj as ConversationVideoEventTopicJourneyCustomer);
        }

        /// <summary>
        /// Returns true if ConversationVideoEventTopicJourneyCustomer instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationVideoEventTopicJourneyCustomer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationVideoEventTopicJourneyCustomer other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.IdType == other.IdType ||
                    this.IdType != null &&
                    this.IdType.Equals(other.IdType)
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

                if (this.IdType != null)
                    hash = hash * 59 + this.IdType.GetHashCode();

                return hash;
            }
        }
    }

}
