using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PatchActionProperties
/// </summary>

public partial class PatchActionProperties : IEquatable<PatchActionProperties>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PatchActionProperties" /> class.
    /// </summary>
    /// <param name="WebchatPrompt">Prompt message shown to user, used for webchat type action..</param>
    /// <param name="WebchatTitleText">Title shown to the user, used for webchat type action..</param>
    /// <param name="WebchatAcceptText">Accept button text shown to user, used for webchat type action..</param>
    /// <param name="WebchatDeclineText">Decline button text shown to user, used for webchat type action..</param>
    /// <param name="WebchatSurvey">Survey provided to the user, used for webchat type action..</param>
    public PatchActionProperties(string WebchatPrompt = null, string WebchatTitleText = null, string WebchatAcceptText = null, string WebchatDeclineText = null, PatchActionSurvey WebchatSurvey = null)
    {
        this.WebchatPrompt = WebchatPrompt;
        this.WebchatTitleText = WebchatTitleText;
        this.WebchatAcceptText = WebchatAcceptText;
        this.WebchatDeclineText = WebchatDeclineText;
        this.WebchatSurvey = WebchatSurvey;

    }



    /// <summary>
    /// Prompt message shown to user, used for webchat type action.
    /// </summary>
    /// <value>Prompt message shown to user, used for webchat type action.</value>
    [JsonPropertyName("webchatPrompt")]
    public string WebchatPrompt { get; set; }



    /// <summary>
    /// Title shown to the user, used for webchat type action.
    /// </summary>
    /// <value>Title shown to the user, used for webchat type action.</value>
    [JsonPropertyName("webchatTitleText")]
    public string WebchatTitleText { get; set; }



    /// <summary>
    /// Accept button text shown to user, used for webchat type action.
    /// </summary>
    /// <value>Accept button text shown to user, used for webchat type action.</value>
    [JsonPropertyName("webchatAcceptText")]
    public string WebchatAcceptText { get; set; }



    /// <summary>
    /// Decline button text shown to user, used for webchat type action.
    /// </summary>
    /// <value>Decline button text shown to user, used for webchat type action.</value>
    [JsonPropertyName("webchatDeclineText")]
    public string WebchatDeclineText { get; set; }



    /// <summary>
    /// Survey provided to the user, used for webchat type action.
    /// </summary>
    /// <value>Survey provided to the user, used for webchat type action.</value>
    [JsonPropertyName("webchatSurvey")]
    public PatchActionSurvey WebchatSurvey { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PatchActionProperties {\n");

        sb.Append("  WebchatPrompt: ").Append(WebchatPrompt).Append("\n");
        sb.Append("  WebchatTitleText: ").Append(WebchatTitleText).Append("\n");
        sb.Append("  WebchatAcceptText: ").Append(WebchatAcceptText).Append("\n");
        sb.Append("  WebchatDeclineText: ").Append(WebchatDeclineText).Append("\n");
        sb.Append("  WebchatSurvey: ").Append(WebchatSurvey).Append("\n");
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
        return Equals(obj as PatchActionProperties);
    }

    /// <summary>
    /// Returns true if PatchActionProperties instances are equal
    /// </summary>
    /// <param name="other">Instance of PatchActionProperties to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PatchActionProperties other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                WebchatPrompt == other.WebchatPrompt ||
                WebchatPrompt != null &&
                WebchatPrompt.Equals(other.WebchatPrompt)
            ) &&
            (
                WebchatTitleText == other.WebchatTitleText ||
                WebchatTitleText != null &&
                WebchatTitleText.Equals(other.WebchatTitleText)
            ) &&
            (
                WebchatAcceptText == other.WebchatAcceptText ||
                WebchatAcceptText != null &&
                WebchatAcceptText.Equals(other.WebchatAcceptText)
            ) &&
            (
                WebchatDeclineText == other.WebchatDeclineText ||
                WebchatDeclineText != null &&
                WebchatDeclineText.Equals(other.WebchatDeclineText)
            ) &&
            (
                WebchatSurvey == other.WebchatSurvey ||
                WebchatSurvey != null &&
                WebchatSurvey.Equals(other.WebchatSurvey)
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
            if (WebchatPrompt != null)
            {
                hash = hash * 59 + WebchatPrompt.GetHashCode();
            }

            if (WebchatTitleText != null)
            {
                hash = hash * 59 + WebchatTitleText.GetHashCode();
            }

            if (WebchatAcceptText != null)
            {
                hash = hash * 59 + WebchatAcceptText.GetHashCode();
            }

            if (WebchatDeclineText != null)
            {
                hash = hash * 59 + WebchatDeclineText.GetHashCode();
            }

            if (WebchatSurvey != null)
            {
                hash = hash * 59 + WebchatSurvey.GetHashCode();
            }

            return hash;
        }
    }
}
