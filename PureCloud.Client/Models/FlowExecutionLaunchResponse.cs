using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Response object from launching a flow.
/// </summary>
[DataContract]
public partial class FlowExecutionLaunchResponse : IEquatable<FlowExecutionLaunchResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FlowExecutionLaunchResponse" /> class.
    /// </summary>
    /// <param name="Id">The flow execution ID.</param>
    /// <param name="Name">The flow execution name..</param>
    /// <param name="FlowVersion">The version of the flow that launched.</param>
    public FlowExecutionLaunchResponse(string Id = null, string Name = null, DomainEntityRef FlowVersion = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.FlowVersion = FlowVersion;

    }



    /// <summary>
    /// The flow execution ID
    /// </summary>
    /// <value>The flow execution ID</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// The flow execution name.
    /// </summary>
    /// <value>The flow execution name.</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The version of the flow that launched
    /// </summary>
    /// <value>The version of the flow that launched</value>
    [DataMember(Name = "flowVersion", EmitDefaultValue = false)]
    public DomainEntityRef FlowVersion { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FlowExecutionLaunchResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  FlowVersion: ").Append(FlowVersion).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as FlowExecutionLaunchResponse);
    }

    /// <summary>
    /// Returns true if FlowExecutionLaunchResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of FlowExecutionLaunchResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FlowExecutionLaunchResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                FlowVersion == other.FlowVersion ||
                FlowVersion != null &&
                FlowVersion.Equals(other.FlowVersion)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (FlowVersion != null)
            {
                hash = hash * 59 + FlowVersion.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
