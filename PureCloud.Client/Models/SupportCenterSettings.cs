using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Settings concerning knowledge portal (previously support center)
/// </summary>
[DataContract]
public partial class SupportCenterSettings : IEquatable<SupportCenterSettings>
{
    /// <summary>
    /// Router type for knowledge portal (previously support center)
    /// </summary>
    /// <value>Router type for knowledge portal (previously support center)</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RouterTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Hash for "Hash"
        /// </summary>
        [EnumMember(Value = "Hash")]
        Hash,

        /// <summary>
        /// Enum Browser for "Browser"
        /// </summary>
        [EnumMember(Value = "Browser")]
        Browser
    }
    /// <summary>
    /// Router type for knowledge portal (previously support center)
    /// </summary>
    /// <value>Router type for knowledge portal (previously support center)</value>
    [DataMember(Name = "routerType", EmitDefaultValue = false)]
    public RouterTypeEnum? RouterType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="SupportCenterSettings" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected SupportCenterSettings() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SupportCenterSettings" /> class.
    /// </summary>
    /// <param name="Enabled">Whether or not knowledge portal (previously support center) is enabled (required).</param>
    /// <param name="KnowledgeBase">The knowledge base for knowledge portal (previously support center) (required).</param>
    /// <param name="CustomMessages">Customizable display texts for knowledge portal (previously support center).</param>
    /// <param name="RouterType">Router type for knowledge portal (previously support center).</param>
    /// <param name="Screens">Available screens for the knowledge portal (previously support center) with its modules (required).</param>
    /// <param name="EnabledCategories">Featured categories for knowledge portal (previously support center) home screen (required).</param>
    /// <param name="LabelFilter">Document label filter. If set, only documents having at least one of the specified labels will be returned by knowledge document query operations..</param>
    /// <param name="StyleSetting">Style attributes for knowledge portal (previously support center) (required).</param>
    /// <param name="Feedback">Customer feedback settings.</param>
    public SupportCenterSettings(bool? Enabled = null, AddressableEntityRef KnowledgeBase = null, List<SupportCenterCustomMessage> CustomMessages = null, RouterTypeEnum? RouterType = null, List<SupportCenterScreen> Screens = null, List<SupportCenterCategory> EnabledCategories = null, SupportCenterLabelFilter LabelFilter = null, SupportCenterStyleSetting StyleSetting = null, SupportCenterFeedbackSettings Feedback = null)
    {
        this.Enabled = Enabled;
        this.KnowledgeBase = KnowledgeBase;
        this.CustomMessages = CustomMessages;
        this.RouterType = RouterType;
        this.Screens = Screens;
        this.EnabledCategories = EnabledCategories;
        this.LabelFilter = LabelFilter;
        this.StyleSetting = StyleSetting;
        this.Feedback = Feedback;

    }



    /// <summary>
    /// Whether or not knowledge portal (previously support center) is enabled
    /// </summary>
    /// <value>Whether or not knowledge portal (previously support center) is enabled</value>
    [DataMember(Name = "enabled", EmitDefaultValue = false)]
    public bool? Enabled { get; set; }



    /// <summary>
    /// The knowledge base for knowledge portal (previously support center)
    /// </summary>
    /// <value>The knowledge base for knowledge portal (previously support center)</value>
    [DataMember(Name = "knowledgeBase", EmitDefaultValue = false)]
    public AddressableEntityRef KnowledgeBase { get; set; }



    /// <summary>
    /// Customizable display texts for knowledge portal (previously support center)
    /// </summary>
    /// <value>Customizable display texts for knowledge portal (previously support center)</value>
    [DataMember(Name = "customMessages", EmitDefaultValue = false)]
    public List<SupportCenterCustomMessage> CustomMessages { get; set; }





    /// <summary>
    /// Available screens for the knowledge portal (previously support center) with its modules
    /// </summary>
    /// <value>Available screens for the knowledge portal (previously support center) with its modules</value>
    [DataMember(Name = "screens", EmitDefaultValue = false)]
    public List<SupportCenterScreen> Screens { get; set; }



    /// <summary>
    /// Featured categories for knowledge portal (previously support center) home screen
    /// </summary>
    /// <value>Featured categories for knowledge portal (previously support center) home screen</value>
    [DataMember(Name = "enabledCategories", EmitDefaultValue = false)]
    public List<SupportCenterCategory> EnabledCategories { get; set; }



    /// <summary>
    /// Document label filter. If set, only documents having at least one of the specified labels will be returned by knowledge document query operations.
    /// </summary>
    /// <value>Document label filter. If set, only documents having at least one of the specified labels will be returned by knowledge document query operations.</value>
    [DataMember(Name = "labelFilter", EmitDefaultValue = false)]
    public SupportCenterLabelFilter LabelFilter { get; set; }



    /// <summary>
    /// Style attributes for knowledge portal (previously support center)
    /// </summary>
    /// <value>Style attributes for knowledge portal (previously support center)</value>
    [DataMember(Name = "styleSetting", EmitDefaultValue = false)]
    public SupportCenterStyleSetting StyleSetting { get; set; }



    /// <summary>
    /// Customer feedback settings
    /// </summary>
    /// <value>Customer feedback settings</value>
    [DataMember(Name = "feedback", EmitDefaultValue = false)]
    public SupportCenterFeedbackSettings Feedback { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SupportCenterSettings {\n");

        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  KnowledgeBase: ").Append(KnowledgeBase).Append("\n");
        sb.Append("  CustomMessages: ").Append(CustomMessages).Append("\n");
        sb.Append("  RouterType: ").Append(RouterType).Append("\n");
        sb.Append("  Screens: ").Append(Screens).Append("\n");
        sb.Append("  EnabledCategories: ").Append(EnabledCategories).Append("\n");
        sb.Append("  LabelFilter: ").Append(LabelFilter).Append("\n");
        sb.Append("  StyleSetting: ").Append(StyleSetting).Append("\n");
        sb.Append("  Feedback: ").Append(Feedback).Append("\n");
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
        return Equals(obj as SupportCenterSettings);
    }

    /// <summary>
    /// Returns true if SupportCenterSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of SupportCenterSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SupportCenterSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Enabled == other.Enabled ||
                Enabled != null &&
                Enabled.Equals(other.Enabled)
            ) &&
            (
                KnowledgeBase == other.KnowledgeBase ||
                KnowledgeBase != null &&
                KnowledgeBase.Equals(other.KnowledgeBase)
            ) &&
            (
                CustomMessages == other.CustomMessages ||
                CustomMessages != null &&
                CustomMessages.SequenceEqual(other.CustomMessages)
            ) &&
            (
                RouterType == other.RouterType ||
                RouterType != null &&
                RouterType.Equals(other.RouterType)
            ) &&
            (
                Screens == other.Screens ||
                Screens != null &&
                Screens.SequenceEqual(other.Screens)
            ) &&
            (
                EnabledCategories == other.EnabledCategories ||
                EnabledCategories != null &&
                EnabledCategories.SequenceEqual(other.EnabledCategories)
            ) &&
            (
                LabelFilter == other.LabelFilter ||
                LabelFilter != null &&
                LabelFilter.Equals(other.LabelFilter)
            ) &&
            (
                StyleSetting == other.StyleSetting ||
                StyleSetting != null &&
                StyleSetting.Equals(other.StyleSetting)
            ) &&
            (
                Feedback == other.Feedback ||
                Feedback != null &&
                Feedback.Equals(other.Feedback)
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
            if (Enabled != null)
            {
                hash = hash * 59 + Enabled.GetHashCode();
            }

            if (KnowledgeBase != null)
            {
                hash = hash * 59 + KnowledgeBase.GetHashCode();
            }

            if (CustomMessages != null)
            {
                hash = hash * 59 + CustomMessages.GetHashCode();
            }

            if (RouterType != null)
            {
                hash = hash * 59 + RouterType.GetHashCode();
            }

            if (Screens != null)
            {
                hash = hash * 59 + Screens.GetHashCode();
            }

            if (EnabledCategories != null)
            {
                hash = hash * 59 + EnabledCategories.GetHashCode();
            }

            if (LabelFilter != null)
            {
                hash = hash * 59 + LabelFilter.GetHashCode();
            }

            if (StyleSetting != null)
            {
                hash = hash * 59 + StyleSetting.GetHashCode();
            }

            if (Feedback != null)
            {
                hash = hash * 59 + Feedback.GetHashCode();
            }

            return hash;
        }
    }
}
