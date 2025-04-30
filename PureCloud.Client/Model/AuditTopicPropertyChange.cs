using System.Runtime.Serialization;
using System.Text;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// AuditTopicPropertyChange
    /// </summary>
    [DataContract]
    public partial class AuditTopicPropertyChange : IEquatable<AuditTopicPropertyChange>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditTopicPropertyChange" /> class.
        /// </summary>
        /// <param name="Property">Property.</param>
        /// <param name="OldValues">OldValues.</param>
        /// <param name="NewValues">NewValues.</param>
        public AuditTopicPropertyChange(string Property = null, List<string> OldValues = null, List<string> NewValues = null)
        {
            this.Property = Property;
            this.OldValues = OldValues;
            this.NewValues = NewValues;

        }



        /// <summary>
        /// Gets or Sets Property
        /// </summary>
        [DataMember(Name = "property", EmitDefaultValue = false)]
        public string Property { get; set; }



        /// <summary>
        /// Gets or Sets OldValues
        /// </summary>
        [DataMember(Name = "oldValues", EmitDefaultValue = false)]
        public List<string> OldValues { get; set; }



        /// <summary>
        /// Gets or Sets NewValues
        /// </summary>
        [DataMember(Name = "newValues", EmitDefaultValue = false)]
        public List<string> NewValues { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditTopicPropertyChange {\n");

            sb.Append("  Property: ").Append(Property).Append("\n");
            sb.Append("  OldValues: ").Append(OldValues).Append("\n");
            sb.Append("  NewValues: ").Append(NewValues).Append("\n");
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
            return this.Equals(obj as AuditTopicPropertyChange);
        }

        /// <summary>
        /// Returns true if AuditTopicPropertyChange instances are equal
        /// </summary>
        /// <param name="other">Instance of AuditTopicPropertyChange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuditTopicPropertyChange other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Property == other.Property ||
                    this.Property != null &&
                    this.Property.Equals(other.Property)
                ) &&
                (
                    this.OldValues == other.OldValues ||
                    this.OldValues != null &&
                    this.OldValues.SequenceEqual(other.OldValues)
                ) &&
                (
                    this.NewValues == other.NewValues ||
                    this.NewValues != null &&
                    this.NewValues.SequenceEqual(other.NewValues)
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
                if (this.Property != null)
                    hash = hash * 59 + this.Property.GetHashCode();

                if (this.OldValues != null)
                    hash = hash * 59 + this.OldValues.GetHashCode();

                if (this.NewValues != null)
                    hash = hash * 59 + this.NewValues.GetHashCode();

                return hash;
            }
        }
    }

}
