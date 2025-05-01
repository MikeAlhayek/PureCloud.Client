using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// ScreenRecordingMetaData
/// </summary>
[DataContract]
public partial class ScreenRecordingMetaData : IEquatable<ScreenRecordingMetaData>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ScreenRecordingMetaData" /> class.
    /// </summary>
    /// <param name="TrackId">TrackId.</param>
    /// <param name="MediaId">MediaId.</param>
    /// <param name="ScreenId">ScreenId.</param>
    /// <param name="OriginX">OriginX.</param>
    /// <param name="OriginY">OriginY.</param>
    /// <param name="Primary">Primary.</param>
    /// <param name="Main">Main.</param>
    public ScreenRecordingMetaData(string TrackId = null, string MediaId = null, string ScreenId = null, int? OriginX = null, int? OriginY = null, bool? Primary = null, bool? Main = null)
    {
        this.TrackId = TrackId;
        this.MediaId = MediaId;
        this.ScreenId = ScreenId;
        this.OriginX = OriginX;
        this.OriginY = OriginY;
        this.Primary = Primary;
        this.Main = Main;

    }



    /// <summary>
    /// Gets or Sets TrackId
    /// </summary>
    [DataMember(Name = "trackId", EmitDefaultValue = false)]
    public string TrackId { get; set; }



    /// <summary>
    /// Gets or Sets MediaId
    /// </summary>
    [DataMember(Name = "mediaId", EmitDefaultValue = false)]
    public string MediaId { get; set; }



    /// <summary>
    /// Gets or Sets ScreenId
    /// </summary>
    [DataMember(Name = "screenId", EmitDefaultValue = false)]
    public string ScreenId { get; set; }



    /// <summary>
    /// Gets or Sets OriginX
    /// </summary>
    [DataMember(Name = "originX", EmitDefaultValue = false)]
    public int? OriginX { get; set; }



    /// <summary>
    /// Gets or Sets OriginY
    /// </summary>
    [DataMember(Name = "originY", EmitDefaultValue = false)]
    public int? OriginY { get; set; }



    /// <summary>
    /// Gets or Sets Primary
    /// </summary>
    [DataMember(Name = "primary", EmitDefaultValue = false)]
    public bool? Primary { get; set; }



    /// <summary>
    /// Gets or Sets Main
    /// </summary>
    [DataMember(Name = "main", EmitDefaultValue = false)]
    public bool? Main { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ScreenRecordingMetaData {\n");

        sb.Append("  TrackId: ").Append(TrackId).Append("\n");
        sb.Append("  MediaId: ").Append(MediaId).Append("\n");
        sb.Append("  ScreenId: ").Append(ScreenId).Append("\n");
        sb.Append("  OriginX: ").Append(OriginX).Append("\n");
        sb.Append("  OriginY: ").Append(OriginY).Append("\n");
        sb.Append("  Primary: ").Append(Primary).Append("\n");
        sb.Append("  Main: ").Append(Main).Append("\n");
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
        return Equals(obj as ScreenRecordingMetaData);
    }

    /// <summary>
    /// Returns true if ScreenRecordingMetaData instances are equal
    /// </summary>
    /// <param name="other">Instance of ScreenRecordingMetaData to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ScreenRecordingMetaData other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                TrackId == other.TrackId ||
                TrackId != null &&
                TrackId.Equals(other.TrackId)
            ) &&
            (
                MediaId == other.MediaId ||
                MediaId != null &&
                MediaId.Equals(other.MediaId)
            ) &&
            (
                ScreenId == other.ScreenId ||
                ScreenId != null &&
                ScreenId.Equals(other.ScreenId)
            ) &&
            (
                OriginX == other.OriginX ||
                OriginX != null &&
                OriginX.Equals(other.OriginX)
            ) &&
            (
                OriginY == other.OriginY ||
                OriginY != null &&
                OriginY.Equals(other.OriginY)
            ) &&
            (
                Primary == other.Primary ||
                Primary != null &&
                Primary.Equals(other.Primary)
            ) &&
            (
                Main == other.Main ||
                Main != null &&
                Main.Equals(other.Main)
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
            if (TrackId != null)
            {
                hash = hash * 59 + TrackId.GetHashCode();
            }

            if (MediaId != null)
            {
                hash = hash * 59 + MediaId.GetHashCode();
            }

            if (ScreenId != null)
            {
                hash = hash * 59 + ScreenId.GetHashCode();
            }

            if (OriginX != null)
            {
                hash = hash * 59 + OriginX.GetHashCode();
            }

            if (OriginY != null)
            {
                hash = hash * 59 + OriginY.GetHashCode();
            }

            if (Primary != null)
            {
                hash = hash * 59 + Primary.GetHashCode();
            }

            if (Main != null)
            {
                hash = hash * 59 + Main.GetHashCode();
            }

            return hash;
        }
    }
}
