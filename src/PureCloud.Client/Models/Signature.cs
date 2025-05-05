namespace PureCloud.Client.Models;

public sealed class Signature
{
    /// <summary>
    /// The configuration to indicate when the signature of a conversation has to be included
    /// </summary>
    /// <value>The configuration to indicate when the signature of a conversation has to be included</value>
    public InclusionType? InclusionType { get; set; }

    /// <summary>
    /// A toggle to enable the signature on email send.
    /// </summary>
    /// <value>A toggle to enable the signature on email send.</value>
    public bool? Enabled { get; set; }

    /// <summary>
    /// The identifier referring to an email signature canned response.
    /// </summary>
    /// <value>The identifier referring to an email signature canned response.</value>
    public string CannedResponseId { get; set; }

    /// <summary>
    /// A toggle that defines if a signature is always included or only set on the first email in an email chain.
    /// </summary>
    /// <value>A toggle that defines if a signature is always included or only set on the first email in an email chain.</value>
    public bool? AlwaysIncluded { get; set; }
}
