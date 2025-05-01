using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Format
/// </summary>
[DataContract]
public partial class Format : IEquatable<Format>
{
    /// <summary>
    /// Gets or Sets Flags
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum FlagsEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Boolplayyesno for "BoolPlayYesNo"
        /// </summary>
        [EnumMember(Value = "BoolPlayYesNo")]
        Boolplayyesno,

        /// <summary>
        /// Enum Currencyasminorunits for "CurrencyAsMinorUnits"
        /// </summary>
        [EnumMember(Value = "CurrencyAsMinorUnits")]
        Currencyasminorunits,

        /// <summary>
        /// Enum Currencymajorunitsonly for "CurrencyMajorUnitsOnly"
        /// </summary>
        [EnumMember(Value = "CurrencyMajorUnitsOnly")]
        Currencymajorunitsonly,

        /// <summary>
        /// Enum Currencyminorunitsonly for "CurrencyMinorUnitsOnly"
        /// </summary>
        [EnumMember(Value = "CurrencyMinorUnitsOnly")]
        Currencyminorunitsonly,

        /// <summary>
        /// Enum Currencyplaydigits for "CurrencyPlayDigits"
        /// </summary>
        [EnumMember(Value = "CurrencyPlayDigits")]
        Currencyplaydigits,

        /// <summary>
        /// Enum Datelongyear for "DateLongYear"
        /// </summary>
        [EnumMember(Value = "DateLongYear")]
        Datelongyear,

        /// <summary>
        /// Enum Dateshortyear for "DateShortYear"
        /// </summary>
        [EnumMember(Value = "DateShortYear")]
        Dateshortyear,

        /// <summary>
        /// Enum Dateshortmonthandday for "DateShortMonthAndDay"
        /// </summary>
        [EnumMember(Value = "DateShortMonthAndDay")]
        Dateshortmonthandday,

        /// <summary>
        /// Enum Datedayofweekonly for "DateDayOfWeekOnly"
        /// </summary>
        [EnumMember(Value = "DateDayOfWeekOnly")]
        Datedayofweekonly,

        /// <summary>
        /// Enum Datedayonly for "DateDayOnly"
        /// </summary>
        [EnumMember(Value = "DateDayOnly")]
        Datedayonly,

        /// <summary>
        /// Enum Datemonthonly for "DateMonthOnly"
        /// </summary>
        [EnumMember(Value = "DateMonthOnly")]
        Datemonthonly,

        /// <summary>
        /// Enum Dateshortyearonly for "DateShortYearOnly"
        /// </summary>
        [EnumMember(Value = "DateShortYearOnly")]
        Dateshortyearonly,

        /// <summary>
        /// Enum Datelongyearonly for "DateLongYearOnly"
        /// </summary>
        [EnumMember(Value = "DateLongYearOnly")]
        Datelongyearonly,

        /// <summary>
        /// Enum Timetwentyfourhours for "TimeTwentyFourHours"
        /// </summary>
        [EnumMember(Value = "TimeTwentyFourHours")]
        Timetwentyfourhours,

        /// <summary>
        /// Enum Timetwelvehours for "TimeTwelveHours"
        /// </summary>
        [EnumMember(Value = "TimeTwelveHours")]
        Timetwelvehours,

        /// <summary>
        /// Enum Timepartdays for "TimePartDays"
        /// </summary>
        [EnumMember(Value = "TimePartDays")]
        Timepartdays,

        /// <summary>
        /// Enum Timeparthours for "TimePartHours"
        /// </summary>
        [EnumMember(Value = "TimePartHours")]
        Timeparthours,

        /// <summary>
        /// Enum Timepartminutes for "TimePartMinutes"
        /// </summary>
        [EnumMember(Value = "TimePartMinutes")]
        Timepartminutes,

        /// <summary>
        /// Enum Timepartseconds for "TimePartSeconds"
        /// </summary>
        [EnumMember(Value = "TimePartSeconds")]
        Timepartseconds,

        /// <summary>
        /// Enum Stringplaychars for "StringPlayChars"
        /// </summary>
        [EnumMember(Value = "StringPlayChars")]
        Stringplaychars,

        /// <summary>
        /// Enum Numberplaydigits for "NumberPlayDigits"
        /// </summary>
        [EnumMember(Value = "NumberPlayDigits")]
        Numberplaydigits,

        /// <summary>
        /// Enum Numberordinal for "NumberOrdinal"
        /// </summary>
        [EnumMember(Value = "NumberOrdinal")]
        Numberordinal,

        /// <summary>
        /// Enum Languagecasearticle for "LanguageCaseArticle"
        /// </summary>
        [EnumMember(Value = "LanguageCaseArticle")]
        Languagecasearticle,

        /// <summary>
        /// Enum Languagecaseaccusative for "LanguageCaseAccusative"
        /// </summary>
        [EnumMember(Value = "LanguageCaseAccusative")]
        Languagecaseaccusative,

        /// <summary>
        /// Enum Languagecasedative for "LanguageCaseDative"
        /// </summary>
        [EnumMember(Value = "LanguageCaseDative")]
        Languagecasedative,

        /// <summary>
        /// Enum Languagecasegenitive for "LanguageCaseGenitive"
        /// </summary>
        [EnumMember(Value = "LanguageCaseGenitive")]
        Languagecasegenitive,

        /// <summary>
        /// Enum Languagecasenominative for "LanguageCaseNominative"
        /// </summary>
        [EnumMember(Value = "LanguageCaseNominative")]
        Languagecasenominative,

        /// <summary>
        /// Enum Languagequantityplural for "LanguageQuantityPlural"
        /// </summary>
        [EnumMember(Value = "LanguageQuantityPlural")]
        Languagequantityplural,

        /// <summary>
        /// Enum Languagequantitysingular for "LanguageQuantitySingular"
        /// </summary>
        [EnumMember(Value = "LanguageQuantitySingular")]
        Languagequantitysingular,

        /// <summary>
        /// Enum Languagegendercommon for "LanguageGenderCommon"
        /// </summary>
        [EnumMember(Value = "LanguageGenderCommon")]
        Languagegendercommon,

        /// <summary>
        /// Enum Languagegenderfeminine for "LanguageGenderFeminine"
        /// </summary>
        [EnumMember(Value = "LanguageGenderFeminine")]
        Languagegenderfeminine,

        /// <summary>
        /// Enum Languagegendermasculine for "LanguageGenderMasculine"
        /// </summary>
        [EnumMember(Value = "LanguageGenderMasculine")]
        Languagegendermasculine,

        /// <summary>
        /// Enum Languagegenderneuter for "LanguageGenderNeuter"
        /// </summary>
        [EnumMember(Value = "LanguageGenderNeuter")]
        Languagegenderneuter,

        /// <summary>
        /// Enum Casearticle for "CaseArticle"
        /// </summary>
        [EnumMember(Value = "CaseArticle")]
        Casearticle,

        /// <summary>
        /// Enum Caseaccusative for "CaseAccusative"
        /// </summary>
        [EnumMember(Value = "CaseAccusative")]
        Caseaccusative,

        /// <summary>
        /// Enum Casedative for "CaseDative"
        /// </summary>
        [EnumMember(Value = "CaseDative")]
        Casedative,

        /// <summary>
        /// Enum Casegenitive for "CaseGenitive"
        /// </summary>
        [EnumMember(Value = "CaseGenitive")]
        Casegenitive,

        /// <summary>
        /// Enum Casenominative for "CaseNominative"
        /// </summary>
        [EnumMember(Value = "CaseNominative")]
        Casenominative,

        /// <summary>
        /// Enum Quantityplural for "QuantityPlural"
        /// </summary>
        [EnumMember(Value = "QuantityPlural")]
        Quantityplural,

        /// <summary>
        /// Enum Quantitysingular for "QuantitySingular"
        /// </summary>
        [EnumMember(Value = "QuantitySingular")]
        Quantitysingular,

        /// <summary>
        /// Enum Gendercommon for "GenderCommon"
        /// </summary>
        [EnumMember(Value = "GenderCommon")]
        Gendercommon,

        /// <summary>
        /// Enum Genderfeminine for "GenderFeminine"
        /// </summary>
        [EnumMember(Value = "GenderFeminine")]
        Genderfeminine,

        /// <summary>
        /// Enum Gendermasculine for "GenderMasculine"
        /// </summary>
        [EnumMember(Value = "GenderMasculine")]
        Gendermasculine,

        /// <summary>
        /// Enum Genderneuter for "GenderNeuter"
        /// </summary>
        [EnumMember(Value = "GenderNeuter")]
        Genderneuter
    }
    /// <summary>
    /// Initializes a new instance of the <see cref="Format" /> class.
    /// </summary>
    /// <param name="Flags">The Set of prompt segment format flags i.e. each entry is a part of describing the overall format. E.g. \&quot;format\&quot;: { \&quot;flags\&quot;: [StringPlayChars] }.</param>
    public Format(List<FlagsEnum> Flags = null)
    {
        this.Flags = Flags;

    }



    /// <summary>
    /// The Set of prompt segment format flags i.e. each entry is a part of describing the overall format. E.g. \&quot;format\&quot;: { \&quot;flags\&quot;: [StringPlayChars] }
    /// </summary>
    /// <value>The Set of prompt segment format flags i.e. each entry is a part of describing the overall format. E.g. \&quot;format\&quot;: { \&quot;flags\&quot;: [StringPlayChars] }</value>
    [DataMember(Name = "flags", EmitDefaultValue = false)]
    public List<FlagsEnum> Flags { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Format {\n");

        sb.Append("  Flags: ").Append(Flags).Append("\n");
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
        return Equals(obj as Format);
    }

    /// <summary>
    /// Returns true if Format instances are equal
    /// </summary>
    /// <param name="other">Instance of Format to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Format other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Flags == other.Flags ||
                Flags != null &&
                Flags.SequenceEqual(other.Flags)
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
            if (Flags != null)
            {
                hash = hash * 59 + Flags.GetHashCode();
            }

            return hash;
        }
    }
}
