using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Defines the phone numbers, operating hours, and the Architect flows to execute for an IVR.
/// </summary>

public partial class IVR : IEquatable<IVR>
{
    /// <summary>
    /// Indicates if the resource is active, inactive, or deleted.
    /// </summary>
    /// <value>Indicates if the resource is active, inactive, or deleted.</value>
    
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
        Inactive,

        /// <summary>
        /// Enum Deleted for "deleted"
        /// </summary>
        [EnumMember(Value = "deleted")]
        Deleted
    }
    /// <summary>
    /// Indicates if the resource is active, inactive, or deleted.
    /// </summary>
    /// <value>Indicates if the resource is active, inactive, or deleted.</value>
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="IVR" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected IVR() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="IVR" /> class.
    /// </summary>
    /// <param name="Name">The name of the entity. (required).</param>
    /// <param name="Division">The division to which this entity belongs..</param>
    /// <param name="Description">The resource&#39;s description..</param>
    /// <param name="Version">The current version of the resource..</param>
    /// <param name="Dnis">The phone number(s) to contact the IVR by.  Each phone number must be unique and not in use by another resource.  For example, a user and an iVR cannot have the same phone number..</param>
    /// <param name="OpenHoursFlow">The Architect flow to execute during the hours an organization is open..</param>
    /// <param name="ClosedHoursFlow">The Architect flow to execute during the hours an organization is closed..</param>
    /// <param name="HolidayHoursFlow">The Architect flow to execute during an organization&#39;s holiday hours..</param>
    /// <param name="ScheduleGroup">The schedule group defining the open and closed hours for an organization.  If this is provided, an open flow and a closed flow must be specified as well..</param>
    public IVR(string Name = null, WritableDivision Division = null, string Description = null, int? Version = null, List<string> Dnis = null, DomainEntityRef OpenHoursFlow = null, DomainEntityRef ClosedHoursFlow = null, DomainEntityRef HolidayHoursFlow = null, DomainEntityRef ScheduleGroup = null)
    {
        this.Name = Name;
        this.Division = Division;
        this.Description = Description;
        this.Version = Version;
        this.Dnis = Dnis;
        this.OpenHoursFlow = OpenHoursFlow;
        this.ClosedHoursFlow = ClosedHoursFlow;
        this.HolidayHoursFlow = HolidayHoursFlow;
        this.ScheduleGroup = ScheduleGroup;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The name of the entity.
    /// </summary>
    /// <value>The name of the entity.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The division to which this entity belongs.
    /// </summary>
    /// <value>The division to which this entity belongs.</value>
    [JsonPropertyName("division")]
    public WritableDivision Division { get; set; }



    /// <summary>
    /// The resource&#39;s description.
    /// </summary>
    /// <value>The resource&#39;s description.</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// The current version of the resource.
    /// </summary>
    /// <value>The current version of the resource.</value>
    [JsonPropertyName("version")]
    public int? Version { get; set; }



    /// <summary>
    /// The date the resource was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the resource was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// The date of the last modification to the resource. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date of the last modification to the resource. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// The ID of the user that last modified the resource.
    /// </summary>
    /// <value>The ID of the user that last modified the resource.</value>
    [JsonPropertyName("modifiedBy")]
    public string ModifiedBy { get; set; }



    /// <summary>
    /// The ID of the user that created the resource.
    /// </summary>
    /// <value>The ID of the user that created the resource.</value>
    [JsonPropertyName("createdBy")]
    public string CreatedBy { get; set; }





    /// <summary>
    /// The application that last modified the resource.
    /// </summary>
    /// <value>The application that last modified the resource.</value>
    [JsonPropertyName("modifiedByApp")]
    public string ModifiedByApp { get; set; }



    /// <summary>
    /// The application that created the resource.
    /// </summary>
    /// <value>The application that created the resource.</value>
    [JsonPropertyName("createdByApp")]
    public string CreatedByApp { get; set; }



    /// <summary>
    /// The phone number(s) to contact the IVR by.  Each phone number must be unique and not in use by another resource.  For example, a user and an iVR cannot have the same phone number.
    /// </summary>
    /// <value>The phone number(s) to contact the IVR by.  Each phone number must be unique and not in use by another resource.  For example, a user and an iVR cannot have the same phone number.</value>
    [JsonPropertyName("dnis")]
    public List<string> Dnis { get; set; }



    /// <summary>
    /// The Architect flow to execute during the hours an organization is open.
    /// </summary>
    /// <value>The Architect flow to execute during the hours an organization is open.</value>
    [JsonPropertyName("openHoursFlow")]
    public DomainEntityRef OpenHoursFlow { get; set; }



    /// <summary>
    /// The Architect flow to execute during the hours an organization is closed.
    /// </summary>
    /// <value>The Architect flow to execute during the hours an organization is closed.</value>
    [JsonPropertyName("closedHoursFlow")]
    public DomainEntityRef ClosedHoursFlow { get; set; }



    /// <summary>
    /// The Architect flow to execute during an organization&#39;s holiday hours.
    /// </summary>
    /// <value>The Architect flow to execute during an organization&#39;s holiday hours.</value>
    [JsonPropertyName("holidayHoursFlow")]
    public DomainEntityRef HolidayHoursFlow { get; set; }



    /// <summary>
    /// The schedule group defining the open and closed hours for an organization.  If this is provided, an open flow and a closed flow must be specified as well.
    /// </summary>
    /// <value>The schedule group defining the open and closed hours for an organization.  If this is provided, an open flow and a closed flow must be specified as well.</value>
    [JsonPropertyName("scheduleGroup")]
    public DomainEntityRef ScheduleGroup { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class IVR {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  ModifiedByApp: ").Append(ModifiedByApp).Append("\n");
        sb.Append("  CreatedByApp: ").Append(CreatedByApp).Append("\n");
        sb.Append("  Dnis: ").Append(Dnis).Append("\n");
        sb.Append("  OpenHoursFlow: ").Append(OpenHoursFlow).Append("\n");
        sb.Append("  ClosedHoursFlow: ").Append(ClosedHoursFlow).Append("\n");
        sb.Append("  HolidayHoursFlow: ").Append(HolidayHoursFlow).Append("\n");
        sb.Append("  ScheduleGroup: ").Append(ScheduleGroup).Append("\n");
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
        return Equals(obj as IVR);
    }

    /// <summary>
    /// Returns true if IVR instances are equal
    /// </summary>
    /// <param name="other">Instance of IVR to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(IVR other)
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
                Division == other.Division ||
                Division != null &&
                Division.Equals(other.Division)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                ModifiedBy == other.ModifiedBy ||
                ModifiedBy != null &&
                ModifiedBy.Equals(other.ModifiedBy)
            ) &&
            (
                CreatedBy == other.CreatedBy ||
                CreatedBy != null &&
                CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                ModifiedByApp == other.ModifiedByApp ||
                ModifiedByApp != null &&
                ModifiedByApp.Equals(other.ModifiedByApp)
            ) &&
            (
                CreatedByApp == other.CreatedByApp ||
                CreatedByApp != null &&
                CreatedByApp.Equals(other.CreatedByApp)
            ) &&
            (
                Dnis == other.Dnis ||
                Dnis != null &&
                Dnis.SequenceEqual(other.Dnis)
            ) &&
            (
                OpenHoursFlow == other.OpenHoursFlow ||
                OpenHoursFlow != null &&
                OpenHoursFlow.Equals(other.OpenHoursFlow)
            ) &&
            (
                ClosedHoursFlow == other.ClosedHoursFlow ||
                ClosedHoursFlow != null &&
                ClosedHoursFlow.Equals(other.ClosedHoursFlow)
            ) &&
            (
                HolidayHoursFlow == other.HolidayHoursFlow ||
                HolidayHoursFlow != null &&
                HolidayHoursFlow.Equals(other.HolidayHoursFlow)
            ) &&
            (
                ScheduleGroup == other.ScheduleGroup ||
                ScheduleGroup != null &&
                ScheduleGroup.Equals(other.ScheduleGroup)
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

            if (Division != null)
            {
                hash = hash * 59 + Division.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (ModifiedBy != null)
            {
                hash = hash * 59 + ModifiedBy.GetHashCode();
            }

            if (CreatedBy != null)
            {
                hash = hash * 59 + CreatedBy.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (ModifiedByApp != null)
            {
                hash = hash * 59 + ModifiedByApp.GetHashCode();
            }

            if (CreatedByApp != null)
            {
                hash = hash * 59 + CreatedByApp.GetHashCode();
            }

            if (Dnis != null)
            {
                hash = hash * 59 + Dnis.GetHashCode();
            }

            if (OpenHoursFlow != null)
            {
                hash = hash * 59 + OpenHoursFlow.GetHashCode();
            }

            if (ClosedHoursFlow != null)
            {
                hash = hash * 59 + ClosedHoursFlow.GetHashCode();
            }

            if (HolidayHoursFlow != null)
            {
                hash = hash * 59 + HolidayHoursFlow.GetHashCode();
            }

            if (ScheduleGroup != null)
            {
                hash = hash * 59 + ScheduleGroup.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
