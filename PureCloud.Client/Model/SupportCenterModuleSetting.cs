using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// SupportCenterModuleSetting
    /// </summary>
    [DataContract]
    public partial class SupportCenterModuleSetting :  IEquatable<SupportCenterModuleSetting>
    {
        /// <summary>
        /// Screen module type
        /// </summary>
        /// <value>Screen module type</value>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Search for "Search"
            /// </summary>
            [EnumMember(Value = "Search")]
            Search,
            
            /// <summary>
            /// Enum Categories for "Categories"
            /// </summary>
            [EnumMember(Value = "Categories")]
            Categories,
            
            /// <summary>
            /// Enum Faq for "FAQ"
            /// </summary>
            [EnumMember(Value = "FAQ")]
            Faq,
            
            /// <summary>
            /// Enum Contact for "Contact"
            /// </summary>
            [EnumMember(Value = "Contact")]
            Contact,
            
            /// <summary>
            /// Enum Results for "Results"
            /// </summary>
            [EnumMember(Value = "Results")]
            Results,
            
            /// <summary>
            /// Enum Article for "Article"
            /// </summary>
            [EnumMember(Value = "Article")]
            Article,
            
            /// <summary>
            /// Enum Topviewedarticles for "TopViewedArticles"
            /// </summary>
            [EnumMember(Value = "TopViewedArticles")]
            Topviewedarticles
        }
        /// <summary>
        /// Screen module type
        /// </summary>
        /// <value>Screen module type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SupportCenterModuleSetting" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SupportCenterModuleSetting() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SupportCenterModuleSetting" /> class.
        /// </summary>
        /// <param name="Type">Screen module type (required).</param>
        /// <param name="Enabled">Whether or not knowledge portal (previously support center) screen module is enabled (required).</param>
        /// <param name="CompactCategoryModuleTemplate">Compact category module template.</param>
        /// <param name="DetailedCategoryModuleTemplate">Detailed category module template.</param>
        public SupportCenterModuleSetting(TypeEnum? Type = null, bool? Enabled = null, SupportCenterCompactCategoryModuleTemplate CompactCategoryModuleTemplate = null, SupportCenterDetailedCategoryModuleTemplate DetailedCategoryModuleTemplate = null)
        {
            this.Type = Type;
            this.Enabled = Enabled;
            this.CompactCategoryModuleTemplate = CompactCategoryModuleTemplate;
            this.DetailedCategoryModuleTemplate = DetailedCategoryModuleTemplate;
            
        }
        




        /// <summary>
        /// Whether or not knowledge portal (previously support center) screen module is enabled
        /// </summary>
        /// <value>Whether or not knowledge portal (previously support center) screen module is enabled</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }



        /// <summary>
        /// Compact category module template
        /// </summary>
        /// <value>Compact category module template</value>
        [DataMember(Name="compactCategoryModuleTemplate", EmitDefaultValue=false)]
        public SupportCenterCompactCategoryModuleTemplate CompactCategoryModuleTemplate { get; set; }



        /// <summary>
        /// Detailed category module template
        /// </summary>
        /// <value>Detailed category module template</value>
        [DataMember(Name="detailedCategoryModuleTemplate", EmitDefaultValue=false)]
        public SupportCenterDetailedCategoryModuleTemplate DetailedCategoryModuleTemplate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SupportCenterModuleSetting {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  CompactCategoryModuleTemplate: ").Append(CompactCategoryModuleTemplate).Append("\n");
            sb.Append("  DetailedCategoryModuleTemplate: ").Append(DetailedCategoryModuleTemplate).Append("\n");
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
            return this.Equals(obj as SupportCenterModuleSetting);
        }

        /// <summary>
        /// Returns true if SupportCenterModuleSetting instances are equal
        /// </summary>
        /// <param name="other">Instance of SupportCenterModuleSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SupportCenterModuleSetting other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.CompactCategoryModuleTemplate == other.CompactCategoryModuleTemplate ||
                    this.CompactCategoryModuleTemplate != null &&
                    this.CompactCategoryModuleTemplate.Equals(other.CompactCategoryModuleTemplate)
                ) &&
                (
                    this.DetailedCategoryModuleTemplate == other.DetailedCategoryModuleTemplate ||
                    this.DetailedCategoryModuleTemplate != null &&
                    this.DetailedCategoryModuleTemplate.Equals(other.DetailedCategoryModuleTemplate)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();

                if (this.CompactCategoryModuleTemplate != null)
                    hash = hash * 59 + this.CompactCategoryModuleTemplate.GetHashCode();

                if (this.DetailedCategoryModuleTemplate != null)
                    hash = hash * 59 + this.DetailedCategoryModuleTemplate.GetHashCode();

                return hash;
            }
        }
    }

}
