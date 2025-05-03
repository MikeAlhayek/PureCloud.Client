namespace PureCloud.Client.Models;

public sealed class CannedResponseLibraries
{
    /// <summary>
    /// The association mode of canned response libraries to queue
    /// </summary>
    /// <value>The association mode of canned response libraries to queue</value>
    public CannedResponseLibrariesMode? Mode { get; set; }

    /// <summary>
    /// Set of canned response library IDs associated with the queue only when mode is SelectedOnly.
    /// </summary>
    /// <value>Set of canned response library IDs associated with the queue only when mode is SelectedOnly.</value>
    public IEnumerable<string> LibraryIds { get; set; }
}
