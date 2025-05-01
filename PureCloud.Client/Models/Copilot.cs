using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Copilot
/// </summary>
[DataContract]
public partial class Copilot : IEquatable<Copilot>
{
    /// <summary>
    /// Language understanding engine type.
    /// </summary>
    /// <value>Language understanding engine type.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum NluEngineTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Nluv3 for "NluV3"
        /// </summary>
        [EnumMember(Value = "NluV3")]
        Nluv3
    }
    /// <summary>
    /// Language understanding engine type.
    /// </summary>
    /// <value>Language understanding engine type.</value>
    [DataMember(Name = "nluEngineType", EmitDefaultValue = false)]
    public NluEngineTypeEnum? NluEngineType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Copilot" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Copilot() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Copilot" /> class.
    /// </summary>
    /// <param name="LiveOnQueue">Copilot is live on selected queue. (required).</param>
    /// <param name="DefaultLanguage">Copilot default language, e.g. [en-US, es-US, es-ES]. Once set, it can not be modified. (required).</param>
    /// <param name="KnowledgeAnswerConfig">Knowledge answer configuration..</param>
    /// <param name="SummaryGenerationConfig">Copilot generated summary configuration..</param>
    /// <param name="WrapupCodePredictionConfig">Copilot generated wrapup code prediction configuration..</param>
    /// <param name="AnswerGenerationConfig">Answer generation configuration..</param>
    /// <param name="NluEngineType">Language understanding engine type..</param>
    /// <param name="NluConfig">NLU configuration..</param>
    /// <param name="RuleEngineConfig">Rule engine configuration..</param>
    public Copilot(bool? LiveOnQueue = null, string DefaultLanguage = null, KnowledgeAnswerConfig KnowledgeAnswerConfig = null, SummaryGenerationConfig SummaryGenerationConfig = null, WrapupCodePredictionConfig WrapupCodePredictionConfig = null, AnswerGenerationConfig AnswerGenerationConfig = null, NluEngineTypeEnum? NluEngineType = null, NluConfig NluConfig = null, RuleEngineConfig RuleEngineConfig = null)
    {
        this.LiveOnQueue = LiveOnQueue;
        this.DefaultLanguage = DefaultLanguage;
        this.KnowledgeAnswerConfig = KnowledgeAnswerConfig;
        this.SummaryGenerationConfig = SummaryGenerationConfig;
        this.WrapupCodePredictionConfig = WrapupCodePredictionConfig;
        this.AnswerGenerationConfig = AnswerGenerationConfig;
        this.NluEngineType = NluEngineType;
        this.NluConfig = NluConfig;
        this.RuleEngineConfig = RuleEngineConfig;

    }



    /// <summary>
    /// Copilot is enabled.
    /// </summary>
    /// <value>Copilot is enabled.</value>
    [DataMember(Name = "enabled", EmitDefaultValue = false)]
    public bool? Enabled { get; private set; }



    /// <summary>
    /// Copilot is live on selected queue.
    /// </summary>
    /// <value>Copilot is live on selected queue.</value>
    [DataMember(Name = "liveOnQueue", EmitDefaultValue = false)]
    public bool? LiveOnQueue { get; set; }



    /// <summary>
    /// Copilot default language, e.g. [en-US, es-US, es-ES]. Once set, it can not be modified.
    /// </summary>
    /// <value>Copilot default language, e.g. [en-US, es-US, es-ES]. Once set, it can not be modified.</value>
    [DataMember(Name = "defaultLanguage", EmitDefaultValue = false)]
    public string DefaultLanguage { get; set; }



    /// <summary>
    /// Knowledge answer configuration.
    /// </summary>
    /// <value>Knowledge answer configuration.</value>
    [DataMember(Name = "knowledgeAnswerConfig", EmitDefaultValue = false)]
    public KnowledgeAnswerConfig KnowledgeAnswerConfig { get; set; }



    /// <summary>
    /// Copilot generated summary configuration.
    /// </summary>
    /// <value>Copilot generated summary configuration.</value>
    [DataMember(Name = "summaryGenerationConfig", EmitDefaultValue = false)]
    public SummaryGenerationConfig SummaryGenerationConfig { get; set; }



    /// <summary>
    /// Copilot generated wrapup code prediction configuration.
    /// </summary>
    /// <value>Copilot generated wrapup code prediction configuration.</value>
    [DataMember(Name = "wrapupCodePredictionConfig", EmitDefaultValue = false)]
    public WrapupCodePredictionConfig WrapupCodePredictionConfig { get; set; }



    /// <summary>
    /// Answer generation configuration.
    /// </summary>
    /// <value>Answer generation configuration.</value>
    [DataMember(Name = "answerGenerationConfig", EmitDefaultValue = false)]
    public AnswerGenerationConfig AnswerGenerationConfig { get; set; }





    /// <summary>
    /// NLU configuration.
    /// </summary>
    /// <value>NLU configuration.</value>
    [DataMember(Name = "nluConfig", EmitDefaultValue = false)]
    public NluConfig NluConfig { get; set; }



    /// <summary>
    /// Rule engine configuration.
    /// </summary>
    /// <value>Rule engine configuration.</value>
    [DataMember(Name = "ruleEngineConfig", EmitDefaultValue = false)]
    public RuleEngineConfig RuleEngineConfig { get; set; }



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
        sb.Append("class Copilot {\n");

        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  LiveOnQueue: ").Append(LiveOnQueue).Append("\n");
        sb.Append("  DefaultLanguage: ").Append(DefaultLanguage).Append("\n");
        sb.Append("  KnowledgeAnswerConfig: ").Append(KnowledgeAnswerConfig).Append("\n");
        sb.Append("  SummaryGenerationConfig: ").Append(SummaryGenerationConfig).Append("\n");
        sb.Append("  WrapupCodePredictionConfig: ").Append(WrapupCodePredictionConfig).Append("\n");
        sb.Append("  AnswerGenerationConfig: ").Append(AnswerGenerationConfig).Append("\n");
        sb.Append("  NluEngineType: ").Append(NluEngineType).Append("\n");
        sb.Append("  NluConfig: ").Append(NluConfig).Append("\n");
        sb.Append("  RuleEngineConfig: ").Append(RuleEngineConfig).Append("\n");
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
        return Equals(obj as Copilot);
    }

    /// <summary>
    /// Returns true if Copilot instances are equal
    /// </summary>
    /// <param name="other">Instance of Copilot to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Copilot other)
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
                LiveOnQueue == other.LiveOnQueue ||
                LiveOnQueue != null &&
                LiveOnQueue.Equals(other.LiveOnQueue)
            ) &&
            (
                DefaultLanguage == other.DefaultLanguage ||
                DefaultLanguage != null &&
                DefaultLanguage.Equals(other.DefaultLanguage)
            ) &&
            (
                KnowledgeAnswerConfig == other.KnowledgeAnswerConfig ||
                KnowledgeAnswerConfig != null &&
                KnowledgeAnswerConfig.Equals(other.KnowledgeAnswerConfig)
            ) &&
            (
                SummaryGenerationConfig == other.SummaryGenerationConfig ||
                SummaryGenerationConfig != null &&
                SummaryGenerationConfig.Equals(other.SummaryGenerationConfig)
            ) &&
            (
                WrapupCodePredictionConfig == other.WrapupCodePredictionConfig ||
                WrapupCodePredictionConfig != null &&
                WrapupCodePredictionConfig.Equals(other.WrapupCodePredictionConfig)
            ) &&
            (
                AnswerGenerationConfig == other.AnswerGenerationConfig ||
                AnswerGenerationConfig != null &&
                AnswerGenerationConfig.Equals(other.AnswerGenerationConfig)
            ) &&
            (
                NluEngineType == other.NluEngineType ||
                NluEngineType != null &&
                NluEngineType.Equals(other.NluEngineType)
            ) &&
            (
                NluConfig == other.NluConfig ||
                NluConfig != null &&
                NluConfig.Equals(other.NluConfig)
            ) &&
            (
                RuleEngineConfig == other.RuleEngineConfig ||
                RuleEngineConfig != null &&
                RuleEngineConfig.Equals(other.RuleEngineConfig)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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

            if (LiveOnQueue != null)
            {
                hash = hash * 59 + LiveOnQueue.GetHashCode();
            }

            if (DefaultLanguage != null)
            {
                hash = hash * 59 + DefaultLanguage.GetHashCode();
            }

            if (KnowledgeAnswerConfig != null)
            {
                hash = hash * 59 + KnowledgeAnswerConfig.GetHashCode();
            }

            if (SummaryGenerationConfig != null)
            {
                hash = hash * 59 + SummaryGenerationConfig.GetHashCode();
            }

            if (WrapupCodePredictionConfig != null)
            {
                hash = hash * 59 + WrapupCodePredictionConfig.GetHashCode();
            }

            if (AnswerGenerationConfig != null)
            {
                hash = hash * 59 + AnswerGenerationConfig.GetHashCode();
            }

            if (NluEngineType != null)
            {
                hash = hash * 59 + NluEngineType.GetHashCode();
            }

            if (NluConfig != null)
            {
                hash = hash * 59 + NluConfig.GetHashCode();
            }

            if (RuleEngineConfig != null)
            {
                hash = hash * 59 + RuleEngineConfig.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
