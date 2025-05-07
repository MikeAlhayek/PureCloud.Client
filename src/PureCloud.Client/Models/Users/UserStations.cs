namespace PureCloud.Client.Models;

public sealed class UserStations
{
    /// <summary>
    /// Current associated station for this user.
    /// </summary>
    /// <value>Current associated station for this user.</value>
    public UserStation AssociatedStation { get; set; }

    /// <summary>
    /// The station where the user can be reached based on their default and associated station.
    /// </summary>
    /// <value>The station where the user can be reached based on their default and associated station.</value>
    public UserStation EffectiveStation { get; set; }

    /// <summary>
    /// Default station to be used if not associated with a station.
    /// </summary>
    /// <value>Default station to be used if not associated with a station.</value>
    public UserStation DefaultStation { get; set; }

    /// <summary>
    /// Last associated station for this user.
    /// </summary>
    /// <value>Last associated station for this user.</value>
    public UserStation LastAssociatedStation { get; set; }
}
