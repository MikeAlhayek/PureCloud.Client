using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ProgramInsightsSettings
/// </summary>
[DataContract]
public partial class ProgramInsightsSettings : IEquatable<ProgramInsightsSettings>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProgramInsightsSettings" /> class.
    /// </summary>
    /// <param name="Program">The ID of the program.</param>
    /// <param name="Enabled">The program AI Insights settings.</param>
    public ProgramInsightsSettings(BaseProgramEntity Program = null, bool? Enabled = null)
    {
        this.Program = Program;
        this.Enabled = Enabled;

    }



    /// <summary>
    /// The ID of the program
    /// </summary>
    /// <value>The ID of the program</value>
    [DataMember(Name = "program", EmitDefaultValue = false)]
    public BaseProgramEntity Program { get; set; }



    /// <summary>
    /// The program AI Insights settings
    /// </summary>
    /// <value>The program AI Insights settings</value>
    [DataMember(Name = "enabled", EmitDefaultValue = false)]
    public bool? Enabled { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ProgramInsightsSettings {\n");

        sb.Append("  Program: ").Append(Program).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
        return Equals(obj as ProgramInsightsSettings);
    }

    /// <summary>
    /// Returns true if ProgramInsightsSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of ProgramInsightsSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ProgramInsightsSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Program == other.Program ||
                Program != null &&
                Program.Equals(other.Program)
            ) &&
            (
                Enabled == other.Enabled ||
                Enabled != null &&
                Enabled.Equals(other.Enabled)
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
            if (Program != null)
            {
                hash = hash * 59 + Program.GetHashCode();
            }

            if (Enabled != null)
            {
                hash = hash * 59 + Enabled.GetHashCode();
            }

            return hash;
        }
    }
}
