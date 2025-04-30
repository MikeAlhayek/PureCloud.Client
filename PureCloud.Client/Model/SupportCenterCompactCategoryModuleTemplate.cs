using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// SupportCenterCompactCategoryModuleTemplate
    /// </summary>
    [DataContract]
    public partial class SupportCenterCompactCategoryModuleTemplate :  IEquatable<SupportCenterCompactCategoryModuleTemplate>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SupportCenterCompactCategoryModuleTemplate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SupportCenterCompactCategoryModuleTemplate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SupportCenterCompactCategoryModuleTemplate" /> class.
        /// </summary>
        /// <param name="Active">Whether this template is active or not (required).</param>
        public SupportCenterCompactCategoryModuleTemplate(bool? Active = null)
        {
            this.Active = Active;
            
        }
        


        /// <summary>
        /// Whether this template is active or not
        /// </summary>
        /// <value>Whether this template is active or not</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SupportCenterCompactCategoryModuleTemplate {\n");

            sb.Append("  Active: ").Append(Active).Append("\n");
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
            return this.Equals(obj as SupportCenterCompactCategoryModuleTemplate);
        }

        /// <summary>
        /// Returns true if SupportCenterCompactCategoryModuleTemplate instances are equal
        /// </summary>
        /// <param name="other">Instance of SupportCenterCompactCategoryModuleTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SupportCenterCompactCategoryModuleTemplate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Active == other.Active ||
                    this.Active != null &&
                    this.Active.Equals(other.Active)
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
                if (this.Active != null)
                    hash = hash * 59 + this.Active.GetHashCode();

                return hash;
            }
        }
    }

}
