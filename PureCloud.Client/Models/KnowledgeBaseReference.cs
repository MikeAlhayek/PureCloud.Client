using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeBaseReference
/// </summary>
[DataContract]
public partial class KnowledgeBaseReference : IEquatable<KnowledgeBaseReference>
{
    /// <summary>
    /// Language of the knowledge base
    /// </summary>
    /// <value>Language of the knowledge base</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum LanguageCodeEnum
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
        Enus,

        /// <summary>
        /// Enum Enuk for "en-UK"
        /// </summary>
        [EnumMember(Value = "en-UK")]
        Enuk,

        /// <summary>
        /// Enum Enau for "en-AU"
        /// </summary>
        [EnumMember(Value = "en-AU")]
        Enau,

        /// <summary>
        /// Enum Enca for "en-CA"
        /// </summary>
        [EnumMember(Value = "en-CA")]
        Enca,

        /// <summary>
        /// Enum Enhk for "en-HK"
        /// </summary>
        [EnumMember(Value = "en-HK")]
        Enhk,

        /// <summary>
        /// Enum Enin for "en-IN"
        /// </summary>
        [EnumMember(Value = "en-IN")]
        Enin,

        /// <summary>
        /// Enum Enie for "en-IE"
        /// </summary>
        [EnumMember(Value = "en-IE")]
        Enie,

        /// <summary>
        /// Enum Ennz for "en-NZ"
        /// </summary>
        [EnumMember(Value = "en-NZ")]
        Ennz,

        /// <summary>
        /// Enum Enph for "en-PH"
        /// </summary>
        [EnumMember(Value = "en-PH")]
        Enph,

        /// <summary>
        /// Enum Ensg for "en-SG"
        /// </summary>
        [EnumMember(Value = "en-SG")]
        Ensg,

        /// <summary>
        /// Enum Enza for "en-ZA"
        /// </summary>
        [EnumMember(Value = "en-ZA")]
        Enza,

        /// <summary>
        /// Enum Dede for "de-DE"
        /// </summary>
        [EnumMember(Value = "de-DE")]
        Dede,

        /// <summary>
        /// Enum Deat for "de-AT"
        /// </summary>
        [EnumMember(Value = "de-AT")]
        Deat,

        /// <summary>
        /// Enum Dech for "de-CH"
        /// </summary>
        [EnumMember(Value = "de-CH")]
        Dech,

        /// <summary>
        /// Enum Esar for "es-AR"
        /// </summary>
        [EnumMember(Value = "es-AR")]
        Esar,

        /// <summary>
        /// Enum Esco for "es-CO"
        /// </summary>
        [EnumMember(Value = "es-CO")]
        Esco,

        /// <summary>
        /// Enum Esmx for "es-MX"
        /// </summary>
        [EnumMember(Value = "es-MX")]
        Esmx,

        /// <summary>
        /// Enum Esus for "es-US"
        /// </summary>
        [EnumMember(Value = "es-US")]
        Esus,

        /// <summary>
        /// Enum Eses for "es-ES"
        /// </summary>
        [EnumMember(Value = "es-ES")]
        Eses,

        /// <summary>
        /// Enum Frfr for "fr-FR"
        /// </summary>
        [EnumMember(Value = "fr-FR")]
        Frfr,

        /// <summary>
        /// Enum Frbe for "fr-BE"
        /// </summary>
        [EnumMember(Value = "fr-BE")]
        Frbe,

        /// <summary>
        /// Enum Frca for "fr-CA"
        /// </summary>
        [EnumMember(Value = "fr-CA")]
        Frca,

        /// <summary>
        /// Enum Frch for "fr-CH"
        /// </summary>
        [EnumMember(Value = "fr-CH")]
        Frch,

        /// <summary>
        /// Enum Ptbr for "pt-BR"
        /// </summary>
        [EnumMember(Value = "pt-BR")]
        Ptbr,

        /// <summary>
        /// Enum Ptpt for "pt-PT"
        /// </summary>
        [EnumMember(Value = "pt-PT")]
        Ptpt,

        /// <summary>
        /// Enum Nlnl for "nl-NL"
        /// </summary>
        [EnumMember(Value = "nl-NL")]
        Nlnl,

        /// <summary>
        /// Enum Nlbe for "nl-BE"
        /// </summary>
        [EnumMember(Value = "nl-BE")]
        Nlbe,

        /// <summary>
        /// Enum Itit for "it-IT"
        /// </summary>
        [EnumMember(Value = "it-IT")]
        Itit,

        /// <summary>
        /// Enum Caes for "ca-ES"
        /// </summary>
        [EnumMember(Value = "ca-ES")]
        Caes,

        /// <summary>
        /// Enum Trtr for "tr-TR"
        /// </summary>
        [EnumMember(Value = "tr-TR")]
        Trtr,

        /// <summary>
        /// Enum Svse for "sv-SE"
        /// </summary>
        [EnumMember(Value = "sv-SE")]
        Svse,

        /// <summary>
        /// Enum Fifi for "fi-FI"
        /// </summary>
        [EnumMember(Value = "fi-FI")]
        Fifi,

        /// <summary>
        /// Enum Nbno for "nb-NO"
        /// </summary>
        [EnumMember(Value = "nb-NO")]
        Nbno,

        /// <summary>
        /// Enum Dadk for "da-DK"
        /// </summary>
        [EnumMember(Value = "da-DK")]
        Dadk,

        /// <summary>
        /// Enum Jajp for "ja-JP"
        /// </summary>
        [EnumMember(Value = "ja-JP")]
        Jajp,

        /// <summary>
        /// Enum Arae for "ar-AE"
        /// </summary>
        [EnumMember(Value = "ar-AE")]
        Arae,

        /// <summary>
        /// Enum Zhcn for "zh-CN"
        /// </summary>
        [EnumMember(Value = "zh-CN")]
        Zhcn,

        /// <summary>
        /// Enum Zhtw for "zh-TW"
        /// </summary>
        [EnumMember(Value = "zh-TW")]
        Zhtw,

        /// <summary>
        /// Enum Zhhk for "zh-HK"
        /// </summary>
        [EnumMember(Value = "zh-HK")]
        Zhhk,

        /// <summary>
        /// Enum Kokr for "ko-KR"
        /// </summary>
        [EnumMember(Value = "ko-KR")]
        Kokr,

        /// <summary>
        /// Enum Plpl for "pl-PL"
        /// </summary>
        [EnumMember(Value = "pl-PL")]
        Plpl,

        /// <summary>
        /// Enum Hiin for "hi-IN"
        /// </summary>
        [EnumMember(Value = "hi-IN")]
        Hiin,

        /// <summary>
        /// Enum Thth for "th-TH"
        /// </summary>
        [EnumMember(Value = "th-TH")]
        Thth,

        /// <summary>
        /// Enum Huhu for "hu-HU"
        /// </summary>
        [EnumMember(Value = "hu-HU")]
        Huhu,

        /// <summary>
        /// Enum Vivn for "vi-VN"
        /// </summary>
        [EnumMember(Value = "vi-VN")]
        Vivn,

        /// <summary>
        /// Enum Ukua for "uk-UA"
        /// </summary>
        [EnumMember(Value = "uk-UA")]
        Ukua
    }
    /// <summary>
    /// Language of the knowledge base
    /// </summary>
    /// <value>Language of the knowledge base</value>
    [DataMember(Name = "languageCode", EmitDefaultValue = false)]
    public LanguageCodeEnum? LanguageCode { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeBaseReference" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected KnowledgeBaseReference() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeBaseReference" /> class.
    /// </summary>
    /// <param name="Id">The globally unique identifier for the knowledge base. (required).</param>
    /// <param name="LanguageCode">Language of the knowledge base.</param>
    public KnowledgeBaseReference(string Id = null, LanguageCodeEnum? LanguageCode = null)
    {
        this.Id = Id;
        this.LanguageCode = LanguageCode;

    }



    /// <summary>
    /// The globally unique identifier for the knowledge base.
    /// </summary>
    /// <value>The globally unique identifier for the knowledge base.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }





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
        sb.Append("class KnowledgeBaseReference {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  LanguageCode: ").Append(LanguageCode).Append("\n");
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
        return Equals(obj as KnowledgeBaseReference);
    }

    /// <summary>
    /// Returns true if KnowledgeBaseReference instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeBaseReference to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeBaseReference other)
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
                LanguageCode == other.LanguageCode ||
                LanguageCode != null &&
                LanguageCode.Equals(other.LanguageCode)
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

            if (LanguageCode != null)
            {
                hash = hash * 59 + LanguageCode.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
