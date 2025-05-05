using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SupportedDialectsTranscriptionEngine
/// </summary>

public partial class SupportedDialectsTranscriptionEngine : IEquatable<SupportedDialectsTranscriptionEngine>
{
    /// <summary>
    /// Gets or Sets Engine
    /// </summary>
    
    public enum EngineEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Genesys for "Genesys"
        /// </summary>
        [EnumMember(Value = "Genesys")]
        Genesys,

        /// <summary>
        /// Enum Genesysextended for "GenesysExtended"
        /// </summary>
        [EnumMember(Value = "GenesysExtended")]
        Genesysextended,

        /// <summary>
        /// Enum Transcriptionconnector for "TranscriptionConnector"
        /// </summary>
        [EnumMember(Value = "TranscriptionConnector")]
        Transcriptionconnector
    }
    /// <summary>
    /// Gets or Sets Engine
    /// </summary>
    [JsonPropertyName("engine")]
    public EngineEnum? Engine { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="SupportedDialectsTranscriptionEngine" /> class.
    /// </summary>
    /// <param name="Engine">Engine.</param>
    /// <param name="Dialects">Dialects.</param>
    /// <param name="EngineIntegration">EngineIntegration.</param>
    public SupportedDialectsTranscriptionEngine(EngineEnum? Engine = null, List<string> Dialects = null, EngineIntegration EngineIntegration = null)
    {
        this.Engine = Engine;
        this.Dialects = Dialects;
        this.EngineIntegration = EngineIntegration;

    }





    /// <summary>
    /// Gets or Sets Dialects
    /// </summary>
    [JsonPropertyName("dialects")]
    public List<string> Dialects { get; set; }



    /// <summary>
    /// Gets or Sets EngineIntegration
    /// </summary>
    [JsonPropertyName("engineIntegration")]
    public EngineIntegration EngineIntegration { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SupportedDialectsTranscriptionEngine {\n");

        sb.Append("  Engine: ").Append(Engine).Append("\n");
        sb.Append("  Dialects: ").Append(Dialects).Append("\n");
        sb.Append("  EngineIntegration: ").Append(EngineIntegration).Append("\n");
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
        return Equals(obj as SupportedDialectsTranscriptionEngine);
    }

    /// <summary>
    /// Returns true if SupportedDialectsTranscriptionEngine instances are equal
    /// </summary>
    /// <param name="other">Instance of SupportedDialectsTranscriptionEngine to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SupportedDialectsTranscriptionEngine other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Engine == other.Engine ||
                Engine != null &&
                Engine.Equals(other.Engine)
            ) &&
            (
                Dialects == other.Dialects ||
                Dialects != null &&
                Dialects.SequenceEqual(other.Dialects)
            ) &&
            (
                EngineIntegration == other.EngineIntegration ||
                EngineIntegration != null &&
                EngineIntegration.Equals(other.EngineIntegration)
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
            if (Engine != null)
            {
                hash = hash * 59 + Engine.GetHashCode();
            }

            if (Dialects != null)
            {
                hash = hash * 59 + Dialects.GetHashCode();
            }

            if (EngineIntegration != null)
            {
                hash = hash * 59 + EngineIntegration.GetHashCode();
            }

            return hash;
        }
    }
}
