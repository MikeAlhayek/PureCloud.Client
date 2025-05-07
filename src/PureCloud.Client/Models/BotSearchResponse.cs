using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BotSearchResponse
/// </summary>

public partial class BotSearchResponse : IEquatable<BotSearchResponse>
{
    /// <summary>
    /// The provider of the bot
    /// </summary>
    /// <value>The provider of the bot</value>
    
    public enum BotTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Genesysbotconnector for "GenesysBotConnector"
        /// </summary>
        [EnumMember(Value = "GenesysBotConnector")]
        Genesysbotconnector,

        /// <summary>
        /// Enum Genesysdialogengine for "GenesysDialogEngine"
        /// </summary>
        [EnumMember(Value = "GenesysDialogEngine")]
        Genesysdialogengine,

        /// <summary>
        /// Enum Amazonlex for "AmazonLex"
        /// </summary>
        [EnumMember(Value = "AmazonLex")]
        Amazonlex,

        /// <summary>
        /// Enum Googledialogflowes for "GoogleDialogFlowES"
        /// </summary>
        [EnumMember(Value = "GoogleDialogFlowES")]
        Googledialogflowes,

        /// <summary>
        /// Enum Googledialogflowcx for "GoogleDialogFlowCX"
        /// </summary>
        [EnumMember(Value = "GoogleDialogFlowCX")]
        Googledialogflowcx,

        /// <summary>
        /// Enum Nuancedlg for "NuanceDlg"
        /// </summary>
        [EnumMember(Value = "NuanceDlg")]
        Nuancedlg,

        /// <summary>
        /// Enum Genesysbotflow for "GenesysBotFlow"
        /// </summary>
        [EnumMember(Value = "GenesysBotFlow")]
        Genesysbotflow,

        /// <summary>
        /// Enum Genesysdigitalbotflow for "GenesysDigitalBotFlow"
        /// </summary>
        [EnumMember(Value = "GenesysDigitalBotFlow")]
        Genesysdigitalbotflow,

        /// <summary>
        /// Enum Genesysvoicesurveyflow for "GenesysVoiceSurveyFlow"
        /// </summary>
        [EnumMember(Value = "GenesysVoiceSurveyFlow")]
        Genesysvoicesurveyflow
    }
    /// <summary>
    /// The provider of the bot
    /// </summary>
    /// <value>The provider of the bot</value>
    [JsonPropertyName("botType")]
    public BotTypeEnum? BotType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="BotSearchResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected BotSearchResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="BotSearchResponse" /> class.
    /// </summary>
    /// <param name="Id">The id of the bot (required).</param>
    /// <param name="Name">The name of the bot (required).</param>
    /// <param name="BotType">The provider of the bot (required).</param>
    /// <param name="Description">The description of the bot.</param>
    public BotSearchResponse(string Id = null, string Name = null, BotTypeEnum? BotType = null, string Description = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.BotType = BotType;
        this.Description = Description;

    }



    /// <summary>
    /// The id of the bot
    /// </summary>
    /// <value>The id of the bot</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The name of the bot
    /// </summary>
    /// <value>The name of the bot</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }





    /// <summary>
    /// The description of the bot
    /// </summary>
    /// <value>The description of the bot</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BotSearchResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  BotType: ").Append(BotType).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
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
        return Equals(obj as BotSearchResponse);
    }

    /// <summary>
    /// Returns true if BotSearchResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of BotSearchResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BotSearchResponse other)
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
                BotType == other.BotType ||
                BotType != null &&
                BotType.Equals(other.BotType)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
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

            if (BotType != null)
            {
                hash = hash * 59 + BotType.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
