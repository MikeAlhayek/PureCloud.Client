namespace PureCloud.Client.Models;

public sealed class Language
{
    public string Id { get; set; }

    public string Name { get; set; }

    public DateTime? DateModified { get; set; }

    public LanguageState? State { get; set; }

    public string Version { get; set; }

    public string SelfUri { get; set; }
}
