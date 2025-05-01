using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LexBotAlias
/// </summary>
[DataContract]
public partial class LexBotAlias : IEquatable<LexBotAlias>
{
    /// <summary>
    /// The status of the Lex bot alias
    /// </summary>
    /// <value>The status of the Lex bot alias</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Building for "BUILDING"
        /// </summary>
        [EnumMember(Value = "BUILDING")]
        Building,

        /// <summary>
        /// Enum Ready for "READY"
        /// </summary>
        [EnumMember(Value = "READY")]
        Ready,

        /// <summary>
        /// Enum Failed for "FAILED"
        /// </summary>
        [EnumMember(Value = "FAILED")]
        Failed,

        /// <summary>
        /// Enum NotBuilt for "NOT_BUILT"
        /// </summary>
        [EnumMember(Value = "NOT_BUILT")]
        NotBuilt
    }
    /// <summary>
    /// The target language of the Lex bot
    /// </summary>
    /// <value>The target language of the Lex bot</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum LanguageEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Enus for "en-US"
        /// </summary>
        [EnumMember(Value = "en-US")]
        Enus
    }
    /// <summary>
    /// The status of the Lex bot alias
    /// </summary>
    /// <value>The status of the Lex bot alias</value>
    [DataMember(Name = "status", EmitDefaultValue = false)]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// The target language of the Lex bot
    /// </summary>
    /// <value>The target language of the Lex bot</value>
    [DataMember(Name = "language", EmitDefaultValue = false)]
    public LanguageEnum? Language { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="LexBotAlias" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected LexBotAlias() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="LexBotAlias" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Bot">The Lex bot this is an alias for.</param>
    /// <param name="BotVersion">The version of the Lex bot this alias points at.</param>
    /// <param name="Status">The status of the Lex bot alias (required).</param>
    /// <param name="FailureReason">If the status is FAILED, Amazon Lex explains why it failed to build the bot.</param>
    /// <param name="Language">The target language of the Lex bot.</param>
    /// <param name="Intents">An array of Intents associated with this bot alias.</param>
    public LexBotAlias(string Name = null, LexBot Bot = null, string BotVersion = null, StatusEnum? Status = null, string FailureReason = null, LanguageEnum? Language = null, List<LexIntent> Intents = null)
    {
        this.Name = Name;
        this.Bot = Bot;
        this.BotVersion = BotVersion;
        this.Status = Status;
        this.FailureReason = FailureReason;
        this.Language = Language;
        this.Intents = Intents;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The Lex bot this is an alias for
    /// </summary>
    /// <value>The Lex bot this is an alias for</value>
    [DataMember(Name = "bot", EmitDefaultValue = false)]
    public LexBot Bot { get; set; }



    /// <summary>
    /// The version of the Lex bot this alias points at
    /// </summary>
    /// <value>The version of the Lex bot this alias points at</value>
    [DataMember(Name = "botVersion", EmitDefaultValue = false)]
    public string BotVersion { get; set; }





    /// <summary>
    /// If the status is FAILED, Amazon Lex explains why it failed to build the bot
    /// </summary>
    /// <value>If the status is FAILED, Amazon Lex explains why it failed to build the bot</value>
    [DataMember(Name = "failureReason", EmitDefaultValue = false)]
    public string FailureReason { get; set; }





    /// <summary>
    /// An array of Intents associated with this bot alias
    /// </summary>
    /// <value>An array of Intents associated with this bot alias</value>
    [DataMember(Name = "intents", EmitDefaultValue = false)]
    public List<LexIntent> Intents { get; set; }



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
        sb.Append("class LexBotAlias {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Bot: ").Append(Bot).Append("\n");
        sb.Append("  BotVersion: ").Append(BotVersion).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  FailureReason: ").Append(FailureReason).Append("\n");
        sb.Append("  Language: ").Append(Language).Append("\n");
        sb.Append("  Intents: ").Append(Intents).Append("\n");
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
        return Equals(obj as LexBotAlias);
    }

    /// <summary>
    /// Returns true if LexBotAlias instances are equal
    /// </summary>
    /// <param name="other">Instance of LexBotAlias to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LexBotAlias other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Bot == other.Bot ||
                Bot != null &&
                Bot.Equals(other.Bot)
            ) &&
            (
                BotVersion == other.BotVersion ||
                BotVersion != null &&
                BotVersion.Equals(other.BotVersion)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                FailureReason == other.FailureReason ||
                FailureReason != null &&
                FailureReason.Equals(other.FailureReason)
            ) &&
            (
                Language == other.Language ||
                Language != null &&
                Language.Equals(other.Language)
            ) &&
            (
                Intents == other.Intents ||
                Intents != null &&
                Intents.SequenceEqual(other.Intents)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Bot != null)
            {
                hash = hash * 59 + Bot.GetHashCode();
            }

            if (BotVersion != null)
            {
                hash = hash * 59 + BotVersion.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (FailureReason != null)
            {
                hash = hash * 59 + FailureReason.GetHashCode();
            }

            if (Language != null)
            {
                hash = hash * 59 + Language.GetHashCode();
            }

            if (Intents != null)
            {
                hash = hash * 59 + Intents.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
