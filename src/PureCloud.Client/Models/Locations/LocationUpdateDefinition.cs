using System.Collections.Generic;
using PureCloud.Client.Models.Locations;

namespace PureCloud.Client.Models.Locations;

/// <summary>
/// LocationUpdateDefinition
/// </summary>

public sealed class LocationUpdateDefinition 
{
    /// <summary>
    /// The name of the Location. Required for creates, not required for updates
    /// </summary>
    /// <value>The name of the Location. Required for creates, not required for updates</value>
    public string Name { get; set; }



    /// <summary>
    /// Current version of the location
    /// </summary>
    /// <value>Current version of the location</value>
    public int? Version { get; set; }

    /// <summary>
    /// Current activity status of the location.
    /// </summary>
    /// <value>Current activity status of the location.</value>
    public string State { get; set; }

    /// <summary>
    /// A list of ancestor ids
    /// </summary>
    /// <value>A list of ancestor ids</value>
    public IEnumerable<string> Path { get; set; }



    /// <summary>
    /// Notes for the location
    /// </summary>
    /// <value>Notes for the location</value>
    public string Notes { get; set; }



    /// <summary>
    /// The user id of the location contact
    /// </summary>
    /// <value>The user id of the location contact</value>
    public string ContactUser { get; set; }



    /// <summary>
    /// Emergency number for the location
    /// </summary>
    /// <value>Emergency number for the location</value>
    public LocationEmergencyNumber EmergencyNumber { get; set; }



    /// <summary>
    /// Address of the location
    /// </summary>
    /// <value>Address of the location</value>
    public LocationAddress Address { get; set; }
}
