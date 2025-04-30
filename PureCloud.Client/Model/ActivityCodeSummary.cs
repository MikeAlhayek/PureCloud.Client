using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// ActivityCodeSummary
    /// </summary>
    [DataContract]
    public partial class ActivityCodeSummary : IEquatable<ActivityCodeSummary>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityCodeSummary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ActivityCodeSummary() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityCodeSummary" /> class.
        /// </summary>
        /// <param name="Id">The globally unique identifier for the object. (required).</param>
        /// <param name="Name">Name.</param>
        /// <param name="SecondaryPresences">The secondary presences of this activity code..</param>
        public ActivityCodeSummary(string Id = null, string Name = null, List<SecondaryPresence> SecondaryPresences = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.SecondaryPresences = SecondaryPresences;

        }



        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }



        /// <summary>
        /// The secondary presences of this activity code.
        /// </summary>
        /// <value>The secondary presences of this activity code.</value>
        [DataMember(Name = "secondaryPresences", EmitDefaultValue = false)]
        public List<SecondaryPresence> SecondaryPresences { get; set; }



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
            sb.Append("class ActivityCodeSummary {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SecondaryPresences: ").Append(SecondaryPresences).Append("\n");
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
            return this.Equals(obj as ActivityCodeSummary);
        }

        /// <summary>
        /// Returns true if ActivityCodeSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of ActivityCodeSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivityCodeSummary other)
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
                    this.SecondaryPresences == other.SecondaryPresences ||
                    this.SecondaryPresences != null &&
                    this.SecondaryPresences.SequenceEqual(other.SecondaryPresences)
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

                if (this.SecondaryPresences != null)
                    hash = hash * 59 + this.SecondaryPresences.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
