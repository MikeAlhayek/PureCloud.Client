using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class Term
{
    /// <summary>
    /// Dictates if term operand must come from the internal, external or both participants
    /// </summary>
    /// <value>Dictates if term operand must come from the internal, external or both participants</value>
    public TermParticipantTypeEnum? ParticipantType { get; set; }

    /// <summary>
    /// Find term in interaction
    /// </summary>
    /// <value>Find term in interaction</value>
    public string Word { get; set; }
}
