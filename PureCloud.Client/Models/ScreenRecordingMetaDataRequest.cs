using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ScreenRecordingMetaDataRequest
/// </summary>
[DataContract]
public partial class ScreenRecordingMetaDataRequest : IEquatable<ScreenRecordingMetaDataRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ScreenRecordingMetaDataRequest" /> class.
    /// </summary>
    /// <param name="ParticipantJid">ParticipantJid.</param>
    /// <param name="RoomId">RoomId.</param>
    /// <param name="MetaData">MetaData.</param>
    public ScreenRecordingMetaDataRequest(string ParticipantJid = null, string RoomId = null, List<ScreenRecordingMetaData> MetaData = null)
    {
        this.ParticipantJid = ParticipantJid;
        this.RoomId = RoomId;
        this.MetaData = MetaData;

    }



    /// <summary>
    /// Gets or Sets ParticipantJid
    /// </summary>
    [DataMember(Name = "participantJid", EmitDefaultValue = false)]
    public string ParticipantJid { get; set; }



    /// <summary>
    /// Gets or Sets RoomId
    /// </summary>
    [DataMember(Name = "roomId", EmitDefaultValue = false)]
    public string RoomId { get; set; }



    /// <summary>
    /// Gets or Sets MetaData
    /// </summary>
    [DataMember(Name = "metaData", EmitDefaultValue = false)]
    public List<ScreenRecordingMetaData> MetaData { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ScreenRecordingMetaDataRequest {\n");

        sb.Append("  ParticipantJid: ").Append(ParticipantJid).Append("\n");
        sb.Append("  RoomId: ").Append(RoomId).Append("\n");
        sb.Append("  MetaData: ").Append(MetaData).Append("\n");
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
        return Equals(obj as ScreenRecordingMetaDataRequest);
    }

    /// <summary>
    /// Returns true if ScreenRecordingMetaDataRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of ScreenRecordingMetaDataRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ScreenRecordingMetaDataRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ParticipantJid == other.ParticipantJid ||
                ParticipantJid != null &&
                ParticipantJid.Equals(other.ParticipantJid)
            ) &&
            (
                RoomId == other.RoomId ||
                RoomId != null &&
                RoomId.Equals(other.RoomId)
            ) &&
            (
                MetaData == other.MetaData ||
                MetaData != null &&
                MetaData.SequenceEqual(other.MetaData)
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
            if (ParticipantJid != null)
            {
                hash = hash * 59 + ParticipantJid.GetHashCode();
            }

            if (RoomId != null)
            {
                hash = hash * 59 + RoomId.GetHashCode();
            }

            if (MetaData != null)
            {
                hash = hash * 59 + MetaData.GetHashCode();
            }

            return hash;
        }
    }
}
