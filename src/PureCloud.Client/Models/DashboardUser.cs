using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DashboardUser
/// </summary>

public partial class DashboardUser : IEquatable<DashboardUser>
{
    /// <summary>
    /// The state of the user
    /// </summary>
    /// <value>The state of the user</value>
    
    public enum StateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Active for "active"
        /// </summary>
        [EnumMember(Value = "active")]
        Active,

        /// <summary>
        /// Enum Inactive for "inactive"
        /// </summary>
        [EnumMember(Value = "inactive")]
        Inactive
    }
    /// <summary>
    /// The state of the user
    /// </summary>
    /// <value>The state of the user</value>
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="DashboardUser" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="DashboardCount">The count of dashboards for the user.</param>
    /// <param name="PublicDashboardCount">The count of public dashboards for the user.</param>
    /// <param name="State">The state of the user.</param>
    public DashboardUser(string Name = null, int? DashboardCount = null, int? PublicDashboardCount = null, StateEnum? State = null)
    {
        this.Name = Name;
        this.DashboardCount = DashboardCount;
        this.PublicDashboardCount = PublicDashboardCount;
        this.State = State;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The count of dashboards for the user
    /// </summary>
    /// <value>The count of dashboards for the user</value>
    [JsonPropertyName("dashboardCount")]
    public int? DashboardCount { get; set; }



    /// <summary>
    /// The count of public dashboards for the user
    /// </summary>
    /// <value>The count of public dashboards for the user</value>
    [JsonPropertyName("publicDashboardCount")]
    public int? PublicDashboardCount { get; set; }





    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DashboardUser {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  DashboardCount: ").Append(DashboardCount).Append("\n");
        sb.Append("  PublicDashboardCount: ").Append(PublicDashboardCount).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
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
        return Equals(obj as DashboardUser);
    }

    /// <summary>
    /// Returns true if DashboardUser instances are equal
    /// </summary>
    /// <param name="other">Instance of DashboardUser to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DashboardUser other)
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
                DashboardCount == other.DashboardCount ||
                DashboardCount != null &&
                DashboardCount.Equals(other.DashboardCount)
            ) &&
            (
                PublicDashboardCount == other.PublicDashboardCount ||
                PublicDashboardCount != null &&
                PublicDashboardCount.Equals(other.PublicDashboardCount)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
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

            if (DashboardCount != null)
            {
                hash = hash * 59 + DashboardCount.GetHashCode();
            }

            if (PublicDashboardCount != null)
            {
                hash = hash * 59 + PublicDashboardCount.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
