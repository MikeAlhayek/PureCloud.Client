using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class FlowHealthIntent
{
    /// <summary>
    /// Language provided for this intent's health.
    /// </summary>
    /// <value>Language provided for this intent's health.</value>
    public FlowHealthIntentLanguageEnum? Language { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Info about given flow version.
    /// </summary>
    /// <value>Info about given flow version.</value>
    public FlowHealthIntentVersionInfo FlowVersionInfo { get; set; }

    /// <summary>
    /// Health computation details for given language.
    /// </summary>
    /// <value>Health computation details for given language.</value>
    public HealthInfo Health { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
