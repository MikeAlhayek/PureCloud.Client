using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// GrammarLanguage
/// </summary>
[DataContract]
public partial class GrammarLanguage : IEquatable<GrammarLanguage>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="GrammarLanguage" /> class.
    /// </summary>
    /// <param name="GrammarId">The ID of the grammar associated with this grammar language.</param>
    /// <param name="Language">Language.</param>
    /// <param name="VoiceFileMetadata">Additional information about the associated voice file.</param>
    /// <param name="DtmfFileMetadata">Additional information about the associated dtmf file.</param>
    public GrammarLanguage(string GrammarId = null, string Language = null, GrammarLanguageFileMetadata VoiceFileMetadata = null, GrammarLanguageFileMetadata DtmfFileMetadata = null)
    {
        this.GrammarId = GrammarId;
        this.Language = Language;
        this.VoiceFileMetadata = VoiceFileMetadata;
        this.DtmfFileMetadata = DtmfFileMetadata;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// The ID of the grammar associated with this grammar language
    /// </summary>
    /// <value>The ID of the grammar associated with this grammar language</value>
    [DataMember(Name = "grammarId", EmitDefaultValue = false)]
    public string GrammarId { get; set; }



    /// <summary>
    /// Gets or Sets Language
    /// </summary>
    [DataMember(Name = "language", EmitDefaultValue = false)]
    public string Language { get; set; }



    /// <summary>
    /// The URL to the voice mode file associated with this grammar language
    /// </summary>
    /// <value>The URL to the voice mode file associated with this grammar language</value>
    [DataMember(Name = "voiceFileUrl", EmitDefaultValue = false)]
    public string VoiceFileUrl { get; private set; }



    /// <summary>
    /// The URL to the DTMF mode file associated with this grammar language
    /// </summary>
    /// <value>The URL to the DTMF mode file associated with this grammar language</value>
    [DataMember(Name = "dtmfFileUrl", EmitDefaultValue = false)]
    public string DtmfFileUrl { get; private set; }



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
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class GrammarLanguage {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  GrammarId: ").Append(GrammarId).Append("\n");
        sb.Append("  Language: ").Append(Language).Append("\n");
        sb.Append("  VoiceFileUrl: ").Append(VoiceFileUrl).Append("\n");
        sb.Append("  DtmfFileUrl: ").Append(DtmfFileUrl).Append("\n");
        sb.Append("  VoiceFileMetadata: ").Append(VoiceFileMetadata).Append("\n");
        sb.Append("  DtmfFileMetadata: ").Append(DtmfFileMetadata).Append("\n");
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
        return Equals(obj as GrammarLanguage);
    }

    /// <summary>
    /// Returns true if GrammarLanguage instances are equal
    /// </summary>
    /// <param name="other">Instance of GrammarLanguage to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(GrammarLanguage other)
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
                GrammarId == other.GrammarId ||
                GrammarId != null &&
                GrammarId.Equals(other.GrammarId)
            ) &&
            (
                Language == other.Language ||
                Language != null &&
                Language.Equals(other.Language)
            ) &&
            (
                VoiceFileUrl == other.VoiceFileUrl ||
                VoiceFileUrl != null &&
                VoiceFileUrl.Equals(other.VoiceFileUrl)
            ) &&
            (
                DtmfFileUrl == other.DtmfFileUrl ||
                DtmfFileUrl != null &&
                DtmfFileUrl.Equals(other.DtmfFileUrl)
            ) &&
            (
                VoiceFileMetadata == other.VoiceFileMetadata ||
                VoiceFileMetadata != null &&
                VoiceFileMetadata.Equals(other.VoiceFileMetadata)
            ) &&
            (
                DtmfFileMetadata == other.DtmfFileMetadata ||
                DtmfFileMetadata != null &&
                DtmfFileMetadata.Equals(other.DtmfFileMetadata)
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

            if (GrammarId != null)
            {
                hash = hash * 59 + GrammarId.GetHashCode();
            }

            if (Language != null)
            {
                hash = hash * 59 + Language.GetHashCode();
            }

            if (VoiceFileUrl != null)
            {
                hash = hash * 59 + VoiceFileUrl.GetHashCode();
            }

            if (DtmfFileUrl != null)
            {
                hash = hash * 59 + DtmfFileUrl.GetHashCode();
            }

            if (VoiceFileMetadata != null)
            {
                hash = hash * 59 + VoiceFileMetadata.GetHashCode();
            }

            if (DtmfFileMetadata != null)
            {
                hash = hash * 59 + DtmfFileMetadata.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
