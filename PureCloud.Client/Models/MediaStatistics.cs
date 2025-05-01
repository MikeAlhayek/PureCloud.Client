using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MediaStatistics
/// </summary>
[DataContract]
public partial class MediaStatistics : IEquatable<MediaStatistics>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MediaStatistics" /> class.
    /// </summary>
    /// <param name="CommunicationId">CommunicationId.</param>
    /// <param name="DateStart">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="CreationMilliseconds">Relative milliseconds to create media session.</param>
    /// <param name="PreferredRegion">Preferred media region.</param>
    /// <param name="EffectiveRegion">Actual media region.</param>
    /// <param name="_MediaStatistics">Media statistics for each media endpoint.</param>
    public MediaStatistics(string CommunicationId = null, DateTime? DateStart = null, long? CreationMilliseconds = null, string PreferredRegion = null, string EffectiveRegion = null, List<MediaEndpointStatistics> _MediaStatistics = null)
    {
        this.CommunicationId = CommunicationId;
        this.DateStart = DateStart;
        this.CreationMilliseconds = CreationMilliseconds;
        this.PreferredRegion = PreferredRegion;
        this.EffectiveRegion = EffectiveRegion;
        this._MediaStatistics = _MediaStatistics;

    }



    /// <summary>
    /// Gets or Sets CommunicationId
    /// </summary>
    [DataMember(Name = "communicationId", EmitDefaultValue = false)]
    public string CommunicationId { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateStart", EmitDefaultValue = false)]
    public DateTime? DateStart { get; set; }



    /// <summary>
    /// Relative milliseconds to create media session
    /// </summary>
    /// <value>Relative milliseconds to create media session</value>
    [DataMember(Name = "creationMilliseconds", EmitDefaultValue = false)]
    public long? CreationMilliseconds { get; set; }



    /// <summary>
    /// Preferred media region
    /// </summary>
    /// <value>Preferred media region</value>
    [DataMember(Name = "preferredRegion", EmitDefaultValue = false)]
    public string PreferredRegion { get; set; }



    /// <summary>
    /// Actual media region
    /// </summary>
    /// <value>Actual media region</value>
    [DataMember(Name = "effectiveRegion", EmitDefaultValue = false)]
    public string EffectiveRegion { get; set; }



    /// <summary>
    /// Media statistics for each media endpoint
    /// </summary>
    /// <value>Media statistics for each media endpoint</value>
    [DataMember(Name = "mediaStatistics", EmitDefaultValue = false)]
    public List<MediaEndpointStatistics> _MediaStatistics { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MediaStatistics {\n");

        sb.Append("  CommunicationId: ").Append(CommunicationId).Append("\n");
        sb.Append("  DateStart: ").Append(DateStart).Append("\n");
        sb.Append("  CreationMilliseconds: ").Append(CreationMilliseconds).Append("\n");
        sb.Append("  PreferredRegion: ").Append(PreferredRegion).Append("\n");
        sb.Append("  EffectiveRegion: ").Append(EffectiveRegion).Append("\n");
        sb.Append("  _MediaStatistics: ").Append(_MediaStatistics).Append("\n");
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
        return Equals(obj as MediaStatistics);
    }

    /// <summary>
    /// Returns true if MediaStatistics instances are equal
    /// </summary>
    /// <param name="other">Instance of MediaStatistics to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MediaStatistics other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                CommunicationId == other.CommunicationId ||
                CommunicationId != null &&
                CommunicationId.Equals(other.CommunicationId)
            ) &&
            (
                DateStart == other.DateStart ||
                DateStart != null &&
                DateStart.Equals(other.DateStart)
            ) &&
            (
                CreationMilliseconds == other.CreationMilliseconds ||
                CreationMilliseconds != null &&
                CreationMilliseconds.Equals(other.CreationMilliseconds)
            ) &&
            (
                PreferredRegion == other.PreferredRegion ||
                PreferredRegion != null &&
                PreferredRegion.Equals(other.PreferredRegion)
            ) &&
            (
                EffectiveRegion == other.EffectiveRegion ||
                EffectiveRegion != null &&
                EffectiveRegion.Equals(other.EffectiveRegion)
            ) &&
            (
                _MediaStatistics == other._MediaStatistics ||
                _MediaStatistics != null &&
                _MediaStatistics.SequenceEqual(other._MediaStatistics)
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
            if (CommunicationId != null)
            {
                hash = hash * 59 + CommunicationId.GetHashCode();
            }

            if (DateStart != null)
            {
                hash = hash * 59 + DateStart.GetHashCode();
            }

            if (CreationMilliseconds != null)
            {
                hash = hash * 59 + CreationMilliseconds.GetHashCode();
            }

            if (PreferredRegion != null)
            {
                hash = hash * 59 + PreferredRegion.GetHashCode();
            }

            if (EffectiveRegion != null)
            {
                hash = hash * 59 + EffectiveRegion.GetHashCode();
            }

            if (_MediaStatistics != null)
            {
                hash = hash * 59 + _MediaStatistics.GetHashCode();
            }

            return hash;
        }
    }
}
