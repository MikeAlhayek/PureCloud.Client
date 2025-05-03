using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UpdateServiceGoalTemplate
/// </summary>

public partial class UpdateServiceGoalTemplate : IEquatable<UpdateServiceGoalTemplate>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="UpdateServiceGoalTemplate" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected UpdateServiceGoalTemplate() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="UpdateServiceGoalTemplate" /> class.
    /// </summary>
    /// <param name="Name">The name of the service goal template..</param>
    /// <param name="ServiceLevel">Service level targets for this service goal template.</param>
    /// <param name="AverageSpeedOfAnswer">Average speed of answer targets for this service goal template.</param>
    /// <param name="AbandonRate">Abandon rate targets for this service goal template.</param>
    /// <param name="Metadata">Version metadata for the service goal template (required).</param>
    /// <param name="ImpactOverride">Settings controlling max percent increase and decrease of service goals for this service goal template.</param>
    public UpdateServiceGoalTemplate(string Name = null, BuServiceLevel ServiceLevel = null, BuAverageSpeedOfAnswer AverageSpeedOfAnswer = null, BuAbandonRate AbandonRate = null, WfmVersionedEntityMetadata Metadata = null, ServiceGoalTemplateImpactOverride ImpactOverride = null)
    {
        this.Name = Name;
        this.ServiceLevel = ServiceLevel;
        this.AverageSpeedOfAnswer = AverageSpeedOfAnswer;
        this.AbandonRate = AbandonRate;
        this.Metadata = Metadata;
        this.ImpactOverride = ImpactOverride;

    }



    /// <summary>
    /// The name of the service goal template.
    /// </summary>
    /// <value>The name of the service goal template.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Service level targets for this service goal template
    /// </summary>
    /// <value>Service level targets for this service goal template</value>
    [JsonPropertyName("serviceLevel")]
    public BuServiceLevel ServiceLevel { get; set; }



    /// <summary>
    /// Average speed of answer targets for this service goal template
    /// </summary>
    /// <value>Average speed of answer targets for this service goal template</value>
    [JsonPropertyName("averageSpeedOfAnswer")]
    public BuAverageSpeedOfAnswer AverageSpeedOfAnswer { get; set; }



    /// <summary>
    /// Abandon rate targets for this service goal template
    /// </summary>
    /// <value>Abandon rate targets for this service goal template</value>
    [JsonPropertyName("abandonRate")]
    public BuAbandonRate AbandonRate { get; set; }



    /// <summary>
    /// Version metadata for the service goal template
    /// </summary>
    /// <value>Version metadata for the service goal template</value>
    [JsonPropertyName("metadata")]
    public WfmVersionedEntityMetadata Metadata { get; set; }



    /// <summary>
    /// Settings controlling max percent increase and decrease of service goals for this service goal template
    /// </summary>
    /// <value>Settings controlling max percent increase and decrease of service goals for this service goal template</value>
    [JsonPropertyName("impactOverride")]
    public ServiceGoalTemplateImpactOverride ImpactOverride { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UpdateServiceGoalTemplate {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  ServiceLevel: ").Append(ServiceLevel).Append("\n");
        sb.Append("  AverageSpeedOfAnswer: ").Append(AverageSpeedOfAnswer).Append("\n");
        sb.Append("  AbandonRate: ").Append(AbandonRate).Append("\n");
        sb.Append("  Metadata: ").Append(Metadata).Append("\n");
        sb.Append("  ImpactOverride: ").Append(ImpactOverride).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as UpdateServiceGoalTemplate);
    }

    /// <summary>
    /// Returns true if UpdateServiceGoalTemplate instances are equal
    /// </summary>
    /// <param name="other">Instance of UpdateServiceGoalTemplate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UpdateServiceGoalTemplate other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                ServiceLevel == other.ServiceLevel ||
                ServiceLevel != null &&
                ServiceLevel.Equals(other.ServiceLevel)
            ) &&
            (
                AverageSpeedOfAnswer == other.AverageSpeedOfAnswer ||
                AverageSpeedOfAnswer != null &&
                AverageSpeedOfAnswer.Equals(other.AverageSpeedOfAnswer)
            ) &&
            (
                AbandonRate == other.AbandonRate ||
                AbandonRate != null &&
                AbandonRate.Equals(other.AbandonRate)
            ) &&
            (
                Metadata == other.Metadata ||
                Metadata != null &&
                Metadata.Equals(other.Metadata)
            ) &&
            (
                ImpactOverride == other.ImpactOverride ||
                ImpactOverride != null &&
                ImpactOverride.Equals(other.ImpactOverride)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (ServiceLevel != null)
            {
                hash = hash * 59 + ServiceLevel.GetHashCode();
            }

            if (AverageSpeedOfAnswer != null)
            {
                hash = hash * 59 + AverageSpeedOfAnswer.GetHashCode();
            }

            if (AbandonRate != null)
            {
                hash = hash * 59 + AbandonRate.GetHashCode();
            }

            if (Metadata != null)
            {
                hash = hash * 59 + Metadata.GetHashCode();
            }

            if (ImpactOverride != null)
            {
                hash = hash * 59 + ImpactOverride.GetHashCode();
            }

            return hash;
        }
    }
}
