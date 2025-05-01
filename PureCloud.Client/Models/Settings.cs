using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Settings
/// </summary>
[DataContract]
public partial class Settings : IEquatable<Settings>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Settings" /> class.
    /// </summary>
    /// <param name="CommunicationBasedACW">Communication Based ACW.</param>
    /// <param name="IncludeNonAgentConversationSummary">Display communication summary.</param>
    /// <param name="AllowCallbackQueueSelection">Allow Callback Queue Selection.</param>
    /// <param name="CallbacksInheritRoutingFromInboundCall">Inherit callback routing data from inbound calls.</param>
    /// <param name="CompleteAcwWhenAgentTransitionsOffline">Complete ACW When Agent Transitions Offline.</param>
    /// <param name="TotalActiveCallback">Exclude the &#39;interacting&#39; duration from the handle calculations of callbacks.</param>
    public Settings(bool? CommunicationBasedACW = null, bool? IncludeNonAgentConversationSummary = null, bool? AllowCallbackQueueSelection = null, bool? CallbacksInheritRoutingFromInboundCall = null, bool? CompleteAcwWhenAgentTransitionsOffline = null, bool? TotalActiveCallback = null)
    {
        this.CommunicationBasedACW = CommunicationBasedACW;
        this.IncludeNonAgentConversationSummary = IncludeNonAgentConversationSummary;
        this.AllowCallbackQueueSelection = AllowCallbackQueueSelection;
        this.CallbacksInheritRoutingFromInboundCall = CallbacksInheritRoutingFromInboundCall;
        this.CompleteAcwWhenAgentTransitionsOffline = CompleteAcwWhenAgentTransitionsOffline;
        this.TotalActiveCallback = TotalActiveCallback;

    }



    /// <summary>
    /// Communication Based ACW
    /// </summary>
    /// <value>Communication Based ACW</value>
    [DataMember(Name = "communicationBasedACW", EmitDefaultValue = false)]
    public bool? CommunicationBasedACW { get; set; }



    /// <summary>
    /// Display communication summary
    /// </summary>
    /// <value>Display communication summary</value>
    [DataMember(Name = "includeNonAgentConversationSummary", EmitDefaultValue = false)]
    public bool? IncludeNonAgentConversationSummary { get; set; }



    /// <summary>
    /// Allow Callback Queue Selection
    /// </summary>
    /// <value>Allow Callback Queue Selection</value>
    [DataMember(Name = "allowCallbackQueueSelection", EmitDefaultValue = false)]
    public bool? AllowCallbackQueueSelection { get; set; }



    /// <summary>
    /// Inherit callback routing data from inbound calls
    /// </summary>
    /// <value>Inherit callback routing data from inbound calls</value>
    [DataMember(Name = "callbacksInheritRoutingFromInboundCall", EmitDefaultValue = false)]
    public bool? CallbacksInheritRoutingFromInboundCall { get; set; }



    /// <summary>
    /// Complete ACW When Agent Transitions Offline
    /// </summary>
    /// <value>Complete ACW When Agent Transitions Offline</value>
    [DataMember(Name = "completeAcwWhenAgentTransitionsOffline", EmitDefaultValue = false)]
    public bool? CompleteAcwWhenAgentTransitionsOffline { get; set; }



    /// <summary>
    /// Exclude the &#39;interacting&#39; duration from the handle calculations of callbacks
    /// </summary>
    /// <value>Exclude the &#39;interacting&#39; duration from the handle calculations of callbacks</value>
    [DataMember(Name = "totalActiveCallback", EmitDefaultValue = false)]
    public bool? TotalActiveCallback { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Settings {\n");

        sb.Append("  CommunicationBasedACW: ").Append(CommunicationBasedACW).Append("\n");
        sb.Append("  IncludeNonAgentConversationSummary: ").Append(IncludeNonAgentConversationSummary).Append("\n");
        sb.Append("  AllowCallbackQueueSelection: ").Append(AllowCallbackQueueSelection).Append("\n");
        sb.Append("  CallbacksInheritRoutingFromInboundCall: ").Append(CallbacksInheritRoutingFromInboundCall).Append("\n");
        sb.Append("  CompleteAcwWhenAgentTransitionsOffline: ").Append(CompleteAcwWhenAgentTransitionsOffline).Append("\n");
        sb.Append("  TotalActiveCallback: ").Append(TotalActiveCallback).Append("\n");
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
        return Equals(obj as Settings);
    }

    /// <summary>
    /// Returns true if Settings instances are equal
    /// </summary>
    /// <param name="other">Instance of Settings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Settings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                CommunicationBasedACW == other.CommunicationBasedACW ||
                CommunicationBasedACW != null &&
                CommunicationBasedACW.Equals(other.CommunicationBasedACW)
            ) &&
            (
                IncludeNonAgentConversationSummary == other.IncludeNonAgentConversationSummary ||
                IncludeNonAgentConversationSummary != null &&
                IncludeNonAgentConversationSummary.Equals(other.IncludeNonAgentConversationSummary)
            ) &&
            (
                AllowCallbackQueueSelection == other.AllowCallbackQueueSelection ||
                AllowCallbackQueueSelection != null &&
                AllowCallbackQueueSelection.Equals(other.AllowCallbackQueueSelection)
            ) &&
            (
                CallbacksInheritRoutingFromInboundCall == other.CallbacksInheritRoutingFromInboundCall ||
                CallbacksInheritRoutingFromInboundCall != null &&
                CallbacksInheritRoutingFromInboundCall.Equals(other.CallbacksInheritRoutingFromInboundCall)
            ) &&
            (
                CompleteAcwWhenAgentTransitionsOffline == other.CompleteAcwWhenAgentTransitionsOffline ||
                CompleteAcwWhenAgentTransitionsOffline != null &&
                CompleteAcwWhenAgentTransitionsOffline.Equals(other.CompleteAcwWhenAgentTransitionsOffline)
            ) &&
            (
                TotalActiveCallback == other.TotalActiveCallback ||
                TotalActiveCallback != null &&
                TotalActiveCallback.Equals(other.TotalActiveCallback)
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
            if (CommunicationBasedACW != null)
            {
                hash = hash * 59 + CommunicationBasedACW.GetHashCode();
            }

            if (IncludeNonAgentConversationSummary != null)
            {
                hash = hash * 59 + IncludeNonAgentConversationSummary.GetHashCode();
            }

            if (AllowCallbackQueueSelection != null)
            {
                hash = hash * 59 + AllowCallbackQueueSelection.GetHashCode();
            }

            if (CallbacksInheritRoutingFromInboundCall != null)
            {
                hash = hash * 59 + CallbacksInheritRoutingFromInboundCall.GetHashCode();
            }

            if (CompleteAcwWhenAgentTransitionsOffline != null)
            {
                hash = hash * 59 + CompleteAcwWhenAgentTransitionsOffline.GetHashCode();
            }

            if (TotalActiveCallback != null)
            {
                hash = hash * 59 + TotalActiveCallback.GetHashCode();
            }

            return hash;
        }
    }
}
