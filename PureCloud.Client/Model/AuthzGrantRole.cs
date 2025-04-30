using System.Runtime.Serialization;
using System.Text;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// AuthzGrantRole
    /// </summary>
    [DataContract]
    public partial class AuthzGrantRole : IEquatable<AuthzGrantRole>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthzGrantRole" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Policies">Policies.</param>
        /// <param name="Default">Default.</param>
        public AuthzGrantRole(string Name = null, string Description = null, List<AuthzGrantPolicy> Policies = null, bool? Default = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.Policies = Policies;
            this.Default = Default;

        }



        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; private set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }



        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }



        /// <summary>
        /// Gets or Sets Policies
        /// </summary>
        [DataMember(Name = "policies", EmitDefaultValue = false)]
        public List<AuthzGrantPolicy> Policies { get; set; }



        /// <summary>
        /// Gets or Sets Default
        /// </summary>
        [DataMember(Name = "default", EmitDefaultValue = false)]
        public bool? Default { get; set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name = "selfUri", EmitDefaultValue = false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthzGrantRole {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Policies: ").Append(Policies).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
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
            return this.Equals(obj as AuthzGrantRole);
        }

        /// <summary>
        /// Returns true if AuthzGrantRole instances are equal
        /// </summary>
        /// <param name="other">Instance of AuthzGrantRole to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthzGrantRole other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Policies == other.Policies ||
                    this.Policies != null &&
                    this.Policies.SequenceEqual(other.Policies)
                ) &&
                (
                    this.Default == other.Default ||
                    this.Default != null &&
                    this.Default.Equals(other.Default)
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

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.Policies != null)
                    hash = hash * 59 + this.Policies.GetHashCode();

                if (this.Default != null)
                    hash = hash * 59 + this.Default.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
