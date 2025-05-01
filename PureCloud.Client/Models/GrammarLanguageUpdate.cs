using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// GrammarLanguageUpdate
/// </summary>
[DataContract]
public partial class GrammarLanguageUpdate : IEquatable<GrammarLanguageUpdate>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="GrammarLanguageUpdate" /> class.
    /// </summary>
    /// <param name="VoiceFileMetadata">Additional information about the associated voice file.</param>
    /// <param name="DtmfFileMetadata">Additional information about the associated dtmf file.</param>
    public GrammarLanguageUpdate(GrammarLanguageFileMetadata VoiceFileMetadata = null, GrammarLanguageFileMetadata DtmfFileMetadata = null)
    {
        this.VoiceFileMetadata = VoiceFileMetadata;
        this.DtmfFileMetadata = DtmfFileMetadata;

    }



    /// <summary>
    /// Additional information about the associated voice file
    /// </summary>
    /// <value>Additional information about the associated voice file</value>
    [DataMember(Name = "voiceFileMetadata", EmitDefaultValue = false)]
    public GrammarLanguageFileMetadata VoiceFileMetadata { get; set; }



    /// <summary>
    /// Additional information about the associated dtmf file
    /// </summary>
    /// <value>Additional information about the associated dtmf file</value>
    [DataMember(Name = "dtmfFileMetadata", EmitDefaultValue = false)]
    public GrammarLanguageFileMetadata DtmfFileMetadata { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class GrammarLanguageUpdate {\n");

        sb.Append("  VoiceFileMetadata: ").Append(VoiceFileMetadata).Append("\n");
        sb.Append("  DtmfFileMetadata: ").Append(DtmfFileMetadata).Append("\n");
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
        return Equals(obj as GrammarLanguageUpdate);
    }

    /// <summary>
    /// Returns true if GrammarLanguageUpdate instances are equal
    /// </summary>
    /// <param name="other">Instance of GrammarLanguageUpdate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(GrammarLanguageUpdate other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                VoiceFileMetadata == other.VoiceFileMetadata ||
                VoiceFileMetadata != null &&
                VoiceFileMetadata.Equals(other.VoiceFileMetadata)
            ) &&
            (
                DtmfFileMetadata == other.DtmfFileMetadata ||
                DtmfFileMetadata != null &&
                DtmfFileMetadata.Equals(other.DtmfFileMetadata)
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
            if (VoiceFileMetadata != null)
            {
                hash = hash * 59 + VoiceFileMetadata.GetHashCode();
            }

            if (DtmfFileMetadata != null)
            {
                hash = hash * 59 + DtmfFileMetadata.GetHashCode();
            }

            return hash;
        }
    }
}
