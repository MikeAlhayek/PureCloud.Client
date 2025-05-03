namespace PureCloud.Client.Models.Users;

/// <summary>
/// Image
/// </summary>

public sealed class Image
{
    /// <summary>
    /// Height and/or width of image. ex: 640x480 or x128
    /// </summary>
    /// <value>Height and/or width of image. ex: 640x480 or x128</value>
    public string Resolution { get; set; }

    /// <summary>
    /// Gets or Sets ImageUri
    /// </summary>
    public string ImageUri { get; set; }
}
