using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// ConversationProperties
/// </summary>
[DataContract]
public partial class ConversationProperties : IEquatable<ConversationProperties>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationProperties" /> class.
    /// </summary>
    /// <param name="IsWaiting">Indicates filtering for waiting.</param>
    /// <param name="IsActive">Indicates filtering for active.</param>
    /// <param name="IsAcd">Indicates filtering for Acd.</param>
    /// <param name="IsPreferred">Indicates filtering for Preferred Agent Routing.</param>
    /// <param name="IsScreenshare">Indicates filtering for screenshare.</param>
    /// <param name="IsCobrowse">Indicates filtering for Cobrowse.</param>
    /// <param name="IsVoicemail">Indicates filtering for Voice mail.</param>
    /// <param name="IsFlagged">Indicates filtering for flagged.</param>
    /// <param name="IsMonitored">Indicates filtering for monitored.</param>
    /// <param name="IsScreenMonitored">Indicates filtering for screenMonitored.</param>
    /// <param name="FilterWrapUpNotes">Indicates filtering for WrapUpNotes.</param>
    /// <param name="MatchAll">Indicates comparison operation, TRUE indicates filters will use AND logic, FALSE indicates OR logic.</param>
    public ConversationProperties(bool? IsWaiting = null, bool? IsActive = null, bool? IsAcd = null, bool? IsPreferred = null, bool? IsScreenshare = null, bool? IsCobrowse = null, bool? IsVoicemail = null, bool? IsFlagged = null, bool? IsMonitored = null, bool? IsScreenMonitored = null, bool? FilterWrapUpNotes = null, bool? MatchAll = null)
    {
        this.IsWaiting = IsWaiting;
        this.IsActive = IsActive;
        this.IsAcd = IsAcd;
        this.IsPreferred = IsPreferred;
        this.IsScreenshare = IsScreenshare;
        this.IsCobrowse = IsCobrowse;
        this.IsVoicemail = IsVoicemail;
        this.IsFlagged = IsFlagged;
        this.IsMonitored = IsMonitored;
        this.IsScreenMonitored = IsScreenMonitored;
        this.FilterWrapUpNotes = FilterWrapUpNotes;
        this.MatchAll = MatchAll;

    }



    /// <summary>
    /// Indicates filtering for waiting
    /// </summary>
    /// <value>Indicates filtering for waiting</value>
    [DataMember(Name = "isWaiting", EmitDefaultValue = false)]
    public bool? IsWaiting { get; set; }



    /// <summary>
    /// Indicates filtering for active
    /// </summary>
    /// <value>Indicates filtering for active</value>
    [DataMember(Name = "isActive", EmitDefaultValue = false)]
    public bool? IsActive { get; set; }



    /// <summary>
    /// Indicates filtering for Acd
    /// </summary>
    /// <value>Indicates filtering for Acd</value>
    [DataMember(Name = "isAcd", EmitDefaultValue = false)]
    public bool? IsAcd { get; set; }



    /// <summary>
    /// Indicates filtering for Preferred Agent Routing
    /// </summary>
    /// <value>Indicates filtering for Preferred Agent Routing</value>
    [DataMember(Name = "isPreferred", EmitDefaultValue = false)]
    public bool? IsPreferred { get; set; }



    /// <summary>
    /// Indicates filtering for screenshare
    /// </summary>
    /// <value>Indicates filtering for screenshare</value>
    [DataMember(Name = "isScreenshare", EmitDefaultValue = false)]
    public bool? IsScreenshare { get; set; }



    /// <summary>
    /// Indicates filtering for Cobrowse
    /// </summary>
    /// <value>Indicates filtering for Cobrowse</value>
    [DataMember(Name = "isCobrowse", EmitDefaultValue = false)]
    public bool? IsCobrowse { get; set; }



    /// <summary>
    /// Indicates filtering for Voice mail
    /// </summary>
    /// <value>Indicates filtering for Voice mail</value>
    [DataMember(Name = "isVoicemail", EmitDefaultValue = false)]
    public bool? IsVoicemail { get; set; }



    /// <summary>
    /// Indicates filtering for flagged
    /// </summary>
    /// <value>Indicates filtering for flagged</value>
    [DataMember(Name = "isFlagged", EmitDefaultValue = false)]
    public bool? IsFlagged { get; set; }



    /// <summary>
    /// Indicates filtering for monitored
    /// </summary>
    /// <value>Indicates filtering for monitored</value>
    [DataMember(Name = "isMonitored", EmitDefaultValue = false)]
    public bool? IsMonitored { get; set; }



    /// <summary>
    /// Indicates filtering for screenMonitored
    /// </summary>
    /// <value>Indicates filtering for screenMonitored</value>
    [DataMember(Name = "isScreenMonitored", EmitDefaultValue = false)]
    public bool? IsScreenMonitored { get; set; }



    /// <summary>
    /// Indicates filtering for WrapUpNotes
    /// </summary>
    /// <value>Indicates filtering for WrapUpNotes</value>
    [DataMember(Name = "filterWrapUpNotes", EmitDefaultValue = false)]
    public bool? FilterWrapUpNotes { get; set; }



    /// <summary>
    /// Indicates comparison operation, TRUE indicates filters will use AND logic, FALSE indicates OR logic
    /// </summary>
    /// <value>Indicates comparison operation, TRUE indicates filters will use AND logic, FALSE indicates OR logic</value>
    [DataMember(Name = "matchAll", EmitDefaultValue = false)]
    public bool? MatchAll { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationProperties {\n");

        sb.Append("  IsWaiting: ").Append(IsWaiting).Append("\n");
        sb.Append("  IsActive: ").Append(IsActive).Append("\n");
        sb.Append("  IsAcd: ").Append(IsAcd).Append("\n");
        sb.Append("  IsPreferred: ").Append(IsPreferred).Append("\n");
        sb.Append("  IsScreenshare: ").Append(IsScreenshare).Append("\n");
        sb.Append("  IsCobrowse: ").Append(IsCobrowse).Append("\n");
        sb.Append("  IsVoicemail: ").Append(IsVoicemail).Append("\n");
        sb.Append("  IsFlagged: ").Append(IsFlagged).Append("\n");
        sb.Append("  IsMonitored: ").Append(IsMonitored).Append("\n");
        sb.Append("  IsScreenMonitored: ").Append(IsScreenMonitored).Append("\n");
        sb.Append("  FilterWrapUpNotes: ").Append(FilterWrapUpNotes).Append("\n");
        sb.Append("  MatchAll: ").Append(MatchAll).Append("\n");
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
        return Equals(obj as ConversationProperties);
    }

    /// <summary>
    /// Returns true if ConversationProperties instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationProperties to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationProperties other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                IsWaiting == other.IsWaiting ||
                IsWaiting != null &&
                IsWaiting.Equals(other.IsWaiting)
            ) &&
            (
                IsActive == other.IsActive ||
                IsActive != null &&
                IsActive.Equals(other.IsActive)
            ) &&
            (
                IsAcd == other.IsAcd ||
                IsAcd != null &&
                IsAcd.Equals(other.IsAcd)
            ) &&
            (
                IsPreferred == other.IsPreferred ||
                IsPreferred != null &&
                IsPreferred.Equals(other.IsPreferred)
            ) &&
            (
                IsScreenshare == other.IsScreenshare ||
                IsScreenshare != null &&
                IsScreenshare.Equals(other.IsScreenshare)
            ) &&
            (
                IsCobrowse == other.IsCobrowse ||
                IsCobrowse != null &&
                IsCobrowse.Equals(other.IsCobrowse)
            ) &&
            (
                IsVoicemail == other.IsVoicemail ||
                IsVoicemail != null &&
                IsVoicemail.Equals(other.IsVoicemail)
            ) &&
            (
                IsFlagged == other.IsFlagged ||
                IsFlagged != null &&
                IsFlagged.Equals(other.IsFlagged)
            ) &&
            (
                IsMonitored == other.IsMonitored ||
                IsMonitored != null &&
                IsMonitored.Equals(other.IsMonitored)
            ) &&
            (
                IsScreenMonitored == other.IsScreenMonitored ||
                IsScreenMonitored != null &&
                IsScreenMonitored.Equals(other.IsScreenMonitored)
            ) &&
            (
                FilterWrapUpNotes == other.FilterWrapUpNotes ||
                FilterWrapUpNotes != null &&
                FilterWrapUpNotes.Equals(other.FilterWrapUpNotes)
            ) &&
            (
                MatchAll == other.MatchAll ||
                MatchAll != null &&
                MatchAll.Equals(other.MatchAll)
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
            if (IsWaiting != null)
            {
                hash = hash * 59 + IsWaiting.GetHashCode();
            }

            if (IsActive != null)
            {
                hash = hash * 59 + IsActive.GetHashCode();
            }

            if (IsAcd != null)
            {
                hash = hash * 59 + IsAcd.GetHashCode();
            }

            if (IsPreferred != null)
            {
                hash = hash * 59 + IsPreferred.GetHashCode();
            }

            if (IsScreenshare != null)
            {
                hash = hash * 59 + IsScreenshare.GetHashCode();
            }

            if (IsCobrowse != null)
            {
                hash = hash * 59 + IsCobrowse.GetHashCode();
            }

            if (IsVoicemail != null)
            {
                hash = hash * 59 + IsVoicemail.GetHashCode();
            }

            if (IsFlagged != null)
            {
                hash = hash * 59 + IsFlagged.GetHashCode();
            }

            if (IsMonitored != null)
            {
                hash = hash * 59 + IsMonitored.GetHashCode();
            }

            if (IsScreenMonitored != null)
            {
                hash = hash * 59 + IsScreenMonitored.GetHashCode();
            }

            if (FilterWrapUpNotes != null)
            {
                hash = hash * 59 + FilterWrapUpNotes.GetHashCode();
            }

            if (MatchAll != null)
            {
                hash = hash * 59 + MatchAll.GetHashCode();
            }

            return hash;
        }
    }
}
