using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WorkPlanOverrideRequest
/// </summary>

public partial class WorkPlanOverrideRequest : IEquatable<WorkPlanOverrideRequest>
{
    /// <summary>
    /// The action to perform on work plan override, defaults to add
    /// </summary>
    /// <value>The action to perform on work plan override, defaults to add</value>
    
    public enum ActionEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Add for "Add"
        /// </summary>
        [EnumMember(Value = "Add")]
        Add,

        /// <summary>
        /// Enum Update for "Update"
        /// </summary>
        [EnumMember(Value = "Update")]
        Update,

        /// <summary>
        /// Enum Delete for "Delete"
        /// </summary>
        [EnumMember(Value = "Delete")]
        Delete
    }
    /// <summary>
    /// The action to perform on work plan override, defaults to add
    /// </summary>
    /// <value>The action to perform on work plan override, defaults to add</value>
    [JsonPropertyName("action")]
    public ActionEnum? Action { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="WorkPlanOverrideRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WorkPlanOverrideRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkPlanOverrideRequest" /> class.
    /// </summary>
    /// <param name="Action">The action to perform on work plan override, defaults to add.</param>
    /// <param name="StartDate">The start date in yyyy-MM-dd format for the updated work plan. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
    /// <param name="WeekCount">The week count of the updated work plan, required if action is Add or Update.</param>
    /// <param name="WorkPlanId">The updated work plan id.</param>
    public WorkPlanOverrideRequest(ActionEnum? Action = null, string StartDate = null, int? WeekCount = null, string WorkPlanId = null)
    {
        this.Action = Action;
        this.StartDate = StartDate;
        this.WeekCount = WeekCount;
        this.WorkPlanId = WorkPlanId;

    }





    /// <summary>
    /// The start date in yyyy-MM-dd format for the updated work plan. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The start date in yyyy-MM-dd format for the updated work plan. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("startDate")]
    public string StartDate { get; set; }



    /// <summary>
    /// The week count of the updated work plan, required if action is Add or Update
    /// </summary>
    /// <value>The week count of the updated work plan, required if action is Add or Update</value>
    [JsonPropertyName("weekCount")]
    public int? WeekCount { get; set; }



    /// <summary>
    /// The updated work plan id
    /// </summary>
    /// <value>The updated work plan id</value>
    [JsonPropertyName("workPlanId")]
    public string WorkPlanId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WorkPlanOverrideRequest {\n");

        sb.Append("  Action: ").Append(Action).Append("\n");
        sb.Append("  StartDate: ").Append(StartDate).Append("\n");
        sb.Append("  WeekCount: ").Append(WeekCount).Append("\n");
        sb.Append("  WorkPlanId: ").Append(WorkPlanId).Append("\n");
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
        return Equals(obj as WorkPlanOverrideRequest);
    }

    /// <summary>
    /// Returns true if WorkPlanOverrideRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkPlanOverrideRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkPlanOverrideRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Action == other.Action ||
                Action != null &&
                Action.Equals(other.Action)
            ) &&
            (
                StartDate == other.StartDate ||
                StartDate != null &&
                StartDate.Equals(other.StartDate)
            ) &&
            (
                WeekCount == other.WeekCount ||
                WeekCount != null &&
                WeekCount.Equals(other.WeekCount)
            ) &&
            (
                WorkPlanId == other.WorkPlanId ||
                WorkPlanId != null &&
                WorkPlanId.Equals(other.WorkPlanId)
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
            if (Action != null)
            {
                hash = hash * 59 + Action.GetHashCode();
            }

            if (StartDate != null)
            {
                hash = hash * 59 + StartDate.GetHashCode();
            }

            if (WeekCount != null)
            {
                hash = hash * 59 + WeekCount.GetHashCode();
            }

            if (WorkPlanId != null)
            {
                hash = hash * 59 + WorkPlanId.GetHashCode();
            }

            return hash;
        }
    }
}
