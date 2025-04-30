using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// ActivityPlanAsaImpactOverride
    /// </summary>
    [DataContract]
    public partial class ActivityPlanAsaImpactOverride : IEquatable<ActivityPlanAsaImpactOverride>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityPlanAsaImpactOverride" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ActivityPlanAsaImpactOverride() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityPlanAsaImpactOverride" /> class.
        /// </summary>
        /// <param name="IncreaseByPercent">Allowed average speed of answer increase percent, from 0.0 to 100.0 (required).</param>
        public ActivityPlanAsaImpactOverride(double? IncreaseByPercent = null)
        {
            this.IncreaseByPercent = IncreaseByPercent;

        }



        /// <summary>
        /// Allowed average speed of answer increase percent, from 0.0 to 100.0
        /// </summary>
        /// <value>Allowed average speed of answer increase percent, from 0.0 to 100.0</value>
        [DataMember(Name = "increaseByPercent", EmitDefaultValue = false)]
        public double? IncreaseByPercent { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActivityPlanAsaImpactOverride {\n");

            sb.Append("  IncreaseByPercent: ").Append(IncreaseByPercent).Append("\n");
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
            return this.Equals(obj as ActivityPlanAsaImpactOverride);
        }

        /// <summary>
        /// Returns true if ActivityPlanAsaImpactOverride instances are equal
        /// </summary>
        /// <param name="other">Instance of ActivityPlanAsaImpactOverride to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivityPlanAsaImpactOverride other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.IncreaseByPercent == other.IncreaseByPercent ||
                    this.IncreaseByPercent != null &&
                    this.IncreaseByPercent.Equals(other.IncreaseByPercent)
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
                if (this.IncreaseByPercent != null)
                    hash = hash * 59 + this.IncreaseByPercent.GetHashCode();

                return hash;
            }
        }
    }

}
