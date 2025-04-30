using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// Fallback
    /// </summary>
    [DataContract]
    public partial class Fallback :  IEquatable<Fallback>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Fallback" /> class.
        /// </summary>
        /// <param name="Enabled">Fallback actions are enabled..</param>
        /// <param name="Actions">Fallback actions..</param>
        public Fallback(bool? Enabled = null, List<CopilotFallbackAction> Actions = null)
        {
            this.Enabled = Enabled;
            this.Actions = Actions;
            
        }
        


        /// <summary>
        /// Fallback actions are enabled.
        /// </summary>
        /// <value>Fallback actions are enabled.</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }



        /// <summary>
        /// Fallback actions.
        /// </summary>
        /// <value>Fallback actions.</value>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public List<CopilotFallbackAction> Actions { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Fallback {\n");

            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
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
            return this.Equals(obj as Fallback);
        }

        /// <summary>
        /// Returns true if Fallback instances are equal
        /// </summary>
        /// <param name="other">Instance of Fallback to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Fallback other)
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
                    this.Actions == other.Actions ||
                    this.Actions != null &&
                    this.Actions.SequenceEqual(other.Actions)
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

                if (this.Actions != null)
                    hash = hash * 59 + this.Actions.GetHashCode();

                return hash;
            }
        }
    }

}
