using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// BillingUsageResource
    /// </summary>
    [DataContract]
    public partial class BillingUsageResource : IEquatable<BillingUsageResource>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingUsageResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BillingUsageResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingUsageResource" /> class.
        /// </summary>
        /// <param name="Name">Identifies the resource (e.g. license user, device). (required).</param>
        /// <param name="Date">The date that the usage was first observed by the billing subsystem. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
        public BillingUsageResource(string Name = null, DateTime? Date = null)
        {
            this.Name = Name;
            this.Date = Date;

        }



        /// <summary>
        /// Identifies the resource (e.g. license user, device).
        /// </summary>
        /// <value>Identifies the resource (e.g. license user, device).</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }



        /// <summary>
        /// The date that the usage was first observed by the billing subsystem. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date that the usage was first observed by the billing subsystem. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        public DateTime? Date { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillingUsageResource {\n");

            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
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
            return this.Equals(obj as BillingUsageResource);
        }

        /// <summary>
        /// Returns true if BillingUsageResource instances are equal
        /// </summary>
        /// <param name="other">Instance of BillingUsageResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingUsageResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Date == other.Date ||
                    this.Date != null &&
                    this.Date.Equals(other.Date)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Date != null)
                    hash = hash * 59 + this.Date.GetHashCode();

                return hash;
            }
        }
    }

}
