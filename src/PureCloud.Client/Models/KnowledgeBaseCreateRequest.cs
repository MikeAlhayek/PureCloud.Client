using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeBaseCreateRequest
/// </summary>

public partial class KnowledgeBaseCreateRequest : IEquatable<KnowledgeBaseCreateRequest>
{
    /// <summary>
    /// Core language for knowledge base in which initial content must be created, language codes [en-US, en-UK, en-AU, de-DE] are supported currently. However, the new DX knowledge will support all these language codes, along with 'early preview' language codes [ca-ES, tr-TR, sv-SE, fi-FI, nb-NO, da-DK, ja-JP, ar-AE, zh-CN, zh-TW, zh-HK, ko-KR, pl-PL, hi-IN, th-TH, hu-HU, vi-VN, uk-UA] which might have a lower accuracy.
    /// </summary>
    /// <value>Core language for knowledge base in which initial content must be created, language codes [en-US, en-UK, en-AU, de-DE] are supported currently. However, the new DX knowledge will support all these language codes, along with 'early preview' language codes [ca-ES, tr-TR, sv-SE, fi-FI, nb-NO, da-DK, ja-JP, ar-AE, zh-CN, zh-TW, zh-HK, ko-KR, pl-PL, hi-IN, th-TH, hu-HU, vi-VN, uk-UA] which might have a lower accuracy.</value>
    
    public enum CoreLanguageEnum
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
    /// Core language for knowledge base in which initial content must be created, language codes [en-US, en-UK, en-AU, de-DE] are supported currently. However, the new DX knowledge will support all these language codes, along with 'early preview' language codes [ca-ES, tr-TR, sv-SE, fi-FI, nb-NO, da-DK, ja-JP, ar-AE, zh-CN, zh-TW, zh-HK, ko-KR, pl-PL, hi-IN, th-TH, hu-HU, vi-VN, uk-UA] which might have a lower accuracy.
    /// </summary>
    /// <value>Core language for knowledge base in which initial content must be created, language codes [en-US, en-UK, en-AU, de-DE] are supported currently. However, the new DX knowledge will support all these language codes, along with 'early preview' language codes [ca-ES, tr-TR, sv-SE, fi-FI, nb-NO, da-DK, ja-JP, ar-AE, zh-CN, zh-TW, zh-HK, ko-KR, pl-PL, hi-IN, th-TH, hu-HU, vi-VN, uk-UA] which might have a lower accuracy.</value>
    [JsonPropertyName("coreLanguage")]
    public CoreLanguageEnum? CoreLanguage { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeBaseCreateRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected KnowledgeBaseCreateRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeBaseCreateRequest" /> class.
    /// </summary>
    /// <param name="Name">Knowledge base name (required).</param>
    /// <param name="Description">Knowledge base description.</param>
    /// <param name="CoreLanguage">Core language for knowledge base in which initial content must be created, language codes [en-US, en-UK, en-AU, de-DE] are supported currently. However, the new DX knowledge will support all these language codes, along with &#39;early preview&#39; language codes [ca-ES, tr-TR, sv-SE, fi-FI, nb-NO, da-DK, ja-JP, ar-AE, zh-CN, zh-TW, zh-HK, ko-KR, pl-PL, hi-IN, th-TH, hu-HU, vi-VN, uk-UA] which might have a lower accuracy. (required).</param>
    public KnowledgeBaseCreateRequest(string Name = null, string Description = null, CoreLanguageEnum? CoreLanguage = null)
    {
        this.Name = Name;
        this.Description = Description;
        this.CoreLanguage = CoreLanguage;

    }



    /// <summary>
    /// Knowledge base name
    /// </summary>
    /// <value>Knowledge base name</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Knowledge base description
    /// </summary>
    /// <value>Knowledge base description</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeBaseCreateRequest {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  CoreLanguage: ").Append(CoreLanguage).Append("\n");
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
        return Equals(obj as KnowledgeBaseCreateRequest);
    }

    /// <summary>
    /// Returns true if KnowledgeBaseCreateRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeBaseCreateRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeBaseCreateRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                CoreLanguage == other.CoreLanguage ||
                CoreLanguage != null &&
                CoreLanguage.Equals(other.CoreLanguage)
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
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (CoreLanguage != null)
            {
                hash = hash * 59 + CoreLanguage.GetHashCode();
            }

            return hash;
        }
    }
}
