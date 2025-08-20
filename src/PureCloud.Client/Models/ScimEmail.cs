namespace PureCloud.Client.Models;

/// <summary>
/// Defines a SCIM email address.
/// </summary>
public sealed class ScimEmail
{
    /// <summary>
    /// The type of email address. "value" is immutable if "type" is set to "other".
    /// </summary>
    public ScimEmailTypeEnum? Type { get; set; }

    /// <summary>
    /// The email address. Is immutable if "type" is set to "other".
    /// </summary>
    public string Value { get; set; }

    /// <summary>
    /// Indicates whether the email address is the primary email address.
    /// </summary>
    public bool? Primary { get; set; }
}