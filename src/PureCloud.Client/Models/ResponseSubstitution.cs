namespace PureCloud.Client.Models;

/// <summary>
/// Contains information about the substitutions associated with a response.
/// </summary>
public sealed class ResponseSubstitution
{
    /// <summary>
    /// Response substitution identifier.
    /// </summary>
    /// <value>Response substitution identifier.</value>
    public string Id { get; set; }

    /// <summary>
    /// Response substitution description.
    /// </summary>
    /// <value>Response substitution description.</value>
    public string Description { get; set; }

    /// <summary>
    /// Response substitution default value.
    /// </summary>
    /// <value>Response substitution default value.</value>
    public string DefaultValue { get; set; }
}