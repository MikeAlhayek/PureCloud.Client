using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// ActionMapScheduleGroup
    /// </summary>
    [DataContract]
    public partial class ActionMapScheduleGroup : IEquatable<ActionMapScheduleGroup>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionMapScheduleGroup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ActionMapScheduleGroup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionMapScheduleGroup" /> class.
        /// </summary>
        /// <param name="Id">The ID of the action maps&#39;s associated schedule group. (required).</param>
        public ActionMapScheduleGroup(string Id = null)
        {
            this.Id = Id;

        }



        /// <summary>
        /// The ID of the action maps&#39;s associated schedule group.
        /// </summary>
        /// <value>The ID of the action maps&#39;s associated schedule group.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActionMapScheduleGroup {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(obj as ActionMapScheduleGroup);
        }

        /// <summary>
        /// Returns true if ActionMapScheduleGroup instances are equal
        /// </summary>
        /// <param name="other">Instance of ActionMapScheduleGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActionMapScheduleGroup other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
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

                return hash;
            }
        }
    }

}
