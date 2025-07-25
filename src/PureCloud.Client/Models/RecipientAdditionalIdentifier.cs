namespace PureCloud.Client.Models;

/// <summary>
/// Additional identifiers for describing messaging recipient.
/// </summary>
public sealed class RecipientAdditionalIdentifier
{
    /// <summary>
    /// Type of the Identifier
    /// </summary>
    /// <value>Type of the Identifier</value>
    public RecipientAdditionalIdentifierType? Type { get; set; }

    /// <summary>
    /// The Identifier value.
    /// </summary>
    /// <value>The Identifier value.</value>
    public string Value { get; set; }
}
