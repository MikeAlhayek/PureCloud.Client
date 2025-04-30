using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// TeamMemberAddListingResponse
    /// </summary>
    [DataContract]
    public partial class TeamMemberAddListingResponse :  IEquatable<TeamMemberAddListingResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMemberAddListingResponse" /> class.
        /// </summary>
        /// <param name="Entities">Entities.</param>
        public TeamMemberAddListingResponse(List<UserReference> Entities = null)
        {
            this.Entities = Entities;
            
        }
        


        /// <summary>
        /// Gets or Sets Entities
        /// </summary>
        [DataMember(Name="entities", EmitDefaultValue=false)]
        public List<UserReference> Entities { get; set; }



        /// <summary>
        /// List of any user ids that were not added.
        /// </summary>
        /// <value>List of any user ids that were not added.</value>
        [DataMember(Name="failures", EmitDefaultValue=false)]
        public List<TeamAddMemberFailure> Failures { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamMemberAddListingResponse {\n");

            sb.Append("  Entities: ").Append(Entities).Append("\n");
            sb.Append("  Failures: ").Append(Failures).Append("\n");
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
            return this.Equals(obj as TeamMemberAddListingResponse);
        }

        /// <summary>
        /// Returns true if TeamMemberAddListingResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TeamMemberAddListingResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamMemberAddListingResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Entities == other.Entities ||
                    this.Entities != null &&
                    this.Entities.SequenceEqual(other.Entities)
                ) &&
                (
                    this.Failures == other.Failures ||
                    this.Failures != null &&
                    this.Failures.SequenceEqual(other.Failures)
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
                if (this.Entities != null)
                    hash = hash * 59 + this.Entities.GetHashCode();

                if (this.Failures != null)
                    hash = hash * 59 + this.Failures.GetHashCode();

                return hash;
            }
        }
    }

}
