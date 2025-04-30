using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// ExternalOrganizationTrustorLink
    /// </summary>
    [DataContract]
    public partial class ExternalOrganizationTrustorLink :  IEquatable<ExternalOrganizationTrustorLink>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalOrganizationTrustorLink" /> class.
        /// </summary>
        /// <param name="Division">The division to which this entity belongs..</param>
        /// <param name="ExternalOrganizationId">The id of a PureCloud External Organization entity in the External Contacts system that will be used to represent the trustor org.</param>
        /// <param name="TrustorOrgId">The id of a PureCloud organization that has granted trust to this PureCloud organization.</param>
        /// <param name="DateCreated">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        public ExternalOrganizationTrustorLink(WritableStarrableDivision Division = null, string ExternalOrganizationId = null, string TrustorOrgId = null, DateTime? DateCreated = null)
        {
            this.Division = Division;
            this.ExternalOrganizationId = ExternalOrganizationId;
            this.TrustorOrgId = TrustorOrgId;
            this.DateCreated = DateCreated;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The division to which this entity belongs.
        /// </summary>
        /// <value>The division to which this entity belongs.</value>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public WritableStarrableDivision Division { get; set; }



        /// <summary>
        /// The id of a PureCloud External Organization entity in the External Contacts system that will be used to represent the trustor org
        /// </summary>
        /// <value>The id of a PureCloud External Organization entity in the External Contacts system that will be used to represent the trustor org</value>
        [DataMember(Name="externalOrganizationId", EmitDefaultValue=false)]
        public string ExternalOrganizationId { get; set; }



        /// <summary>
        /// The id of a PureCloud organization that has granted trust to this PureCloud organization
        /// </summary>
        /// <value>The id of a PureCloud organization that has granted trust to this PureCloud organization</value>
        [DataMember(Name="trustorOrgId", EmitDefaultValue=false)]
        public string TrustorOrgId { get; set; }



        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }



        /// <summary>
        /// The URI for the External Organization that is linked to the trustor org
        /// </summary>
        /// <value>The URI for the External Organization that is linked to the trustor org</value>
        [DataMember(Name="externalOrganizationUri", EmitDefaultValue=false)]
        public string ExternalOrganizationUri { get; private set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalOrganizationTrustorLink {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  ExternalOrganizationId: ").Append(ExternalOrganizationId).Append("\n");
            sb.Append("  TrustorOrgId: ").Append(TrustorOrgId).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  ExternalOrganizationUri: ").Append(ExternalOrganizationUri).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as ExternalOrganizationTrustorLink);
        }

        /// <summary>
        /// Returns true if ExternalOrganizationTrustorLink instances are equal
        /// </summary>
        /// <param name="other">Instance of ExternalOrganizationTrustorLink to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalOrganizationTrustorLink other)
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
                    this.Division == other.Division ||
                    this.Division != null &&
                    this.Division.Equals(other.Division)
                ) &&
                (
                    this.ExternalOrganizationId == other.ExternalOrganizationId ||
                    this.ExternalOrganizationId != null &&
                    this.ExternalOrganizationId.Equals(other.ExternalOrganizationId)
                ) &&
                (
                    this.TrustorOrgId == other.TrustorOrgId ||
                    this.TrustorOrgId != null &&
                    this.TrustorOrgId.Equals(other.TrustorOrgId)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.ExternalOrganizationUri == other.ExternalOrganizationUri ||
                    this.ExternalOrganizationUri != null &&
                    this.ExternalOrganizationUri.Equals(other.ExternalOrganizationUri)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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

                if (this.Division != null)
                    hash = hash * 59 + this.Division.GetHashCode();

                if (this.ExternalOrganizationId != null)
                    hash = hash * 59 + this.ExternalOrganizationId.GetHashCode();

                if (this.TrustorOrgId != null)
                    hash = hash * 59 + this.TrustorOrgId.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.ExternalOrganizationUri != null)
                    hash = hash * 59 + this.ExternalOrganizationUri.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
