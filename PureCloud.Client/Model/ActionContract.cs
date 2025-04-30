using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// This resource contains all of the schemas needed to define the inputs and outputs, of a single Action.
    /// </summary>
    [DataContract]
    public partial class ActionContract : IEquatable<ActionContract>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionContract" /> class.
        /// </summary>
        /// <param name="Output">The output to expect when executing this action..</param>
        /// <param name="Input">The input required when executing this action..</param>
        public ActionContract(ActionOutput Output = null, ActionInput Input = null)
        {
            this.Output = Output;
            this.Input = Input;

        }



        /// <summary>
        /// The output to expect when executing this action.
        /// </summary>
        /// <value>The output to expect when executing this action.</value>
        [DataMember(Name = "output", EmitDefaultValue = false)]
        public ActionOutput Output { get; set; }



        /// <summary>
        /// The input required when executing this action.
        /// </summary>
        /// <value>The input required when executing this action.</value>
        [DataMember(Name = "input", EmitDefaultValue = false)]
        public ActionInput Input { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActionContract {\n");

            sb.Append("  Output: ").Append(Output).Append("\n");
            sb.Append("  Input: ").Append(Input).Append("\n");
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
            return this.Equals(obj as ActionContract);
        }

        /// <summary>
        /// Returns true if ActionContract instances are equal
        /// </summary>
        /// <param name="other">Instance of ActionContract to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActionContract other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Output == other.Output ||
                    this.Output != null &&
                    this.Output.Equals(other.Output)
                ) &&
                (
                    this.Input == other.Input ||
                    this.Input != null &&
                    this.Input.Equals(other.Input)
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
                if (this.Output != null)
                    hash = hash * 59 + this.Output.GetHashCode();

                if (this.Input != null)
                    hash = hash * 59 + this.Input.GetHashCode();

                return hash;
            }
        }
    }

}
