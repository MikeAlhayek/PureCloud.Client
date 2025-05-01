using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// ActionProperties
/// </summary>
[DataContract]
public partial class ActionProperties : IEquatable<ActionProperties>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ActionProperties" /> class.
    /// </summary>
    /// <param name="WebchatPrompt">Prompt message shown to user, used for webchat type action..</param>
    /// <param name="WebchatTitleText">Title shown to the user, used for webchat type action..</param>
    /// <param name="WebchatAcceptText">Accept button text shown to user, used for webchat type action..</param>
    /// <param name="WebchatDeclineText">Decline button text shown to user, used for webchat type action..</param>
    /// <param name="WebchatSurvey">Survey provided to the user, used for webchat type action..</param>
    public ActionProperties(string WebchatPrompt = null, string WebchatTitleText = null, string WebchatAcceptText = null, string WebchatDeclineText = null, ActionSurvey WebchatSurvey = null)
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
    [DataMember(Name = "webchatPrompt", EmitDefaultValue = false)]
    public string WebchatPrompt { get; set; }



    /// <summary>
    /// Title shown to the user, used for webchat type action.
    /// </summary>
    /// <value>Title shown to the user, used for webchat type action.</value>
    [DataMember(Name = "webchatTitleText", EmitDefaultValue = false)]
    public string WebchatTitleText { get; set; }



    /// <summary>
    /// Accept button text shown to user, used for webchat type action.
    /// </summary>
    /// <value>Accept button text shown to user, used for webchat type action.</value>
    [DataMember(Name = "webchatAcceptText", EmitDefaultValue = false)]
    public string WebchatAcceptText { get; set; }



    /// <summary>
    /// Decline button text shown to user, used for webchat type action.
    /// </summary>
    /// <value>Decline button text shown to user, used for webchat type action.</value>
    [DataMember(Name = "webchatDeclineText", EmitDefaultValue = false)]
    public string WebchatDeclineText { get; set; }



    /// <summary>
    /// Survey provided to the user, used for webchat type action.
    /// </summary>
    /// <value>Survey provided to the user, used for webchat type action.</value>
    [DataMember(Name = "webchatSurvey", EmitDefaultValue = false)]
    public ActionSurvey WebchatSurvey { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ActionProperties {\n");

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
        return Equals(obj as ActionProperties);
    }

    /// <summary>
    /// Returns true if ActionProperties instances are equal
    /// </summary>
    /// <param name="other">Instance of ActionProperties to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ActionProperties other)
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
