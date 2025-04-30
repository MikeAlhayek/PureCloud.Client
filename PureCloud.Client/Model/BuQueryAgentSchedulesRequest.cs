using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// BuQueryAgentSchedulesRequest
    /// </summary>
    [DataContract]
    public partial class BuQueryAgentSchedulesRequest : IEquatable<BuQueryAgentSchedulesRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="BuQueryAgentSchedulesRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BuQueryAgentSchedulesRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BuQueryAgentSchedulesRequest" /> class.
        /// </summary>
        /// <param name="ManagementUnitId">The ID of the management unit to query (required).</param>
        /// <param name="UserIds">The IDs of the users to query.  Omit to query all user schedules in the management unit. Note: If teamIds is also specified, only schedules for users in the requested teams will be returned.</param>
        /// <param name="TeamIds">The teamIds to request. If null or not set, results will be queried for requested users if applicable or otherwise all users in the management unit.</param>
        public BuQueryAgentSchedulesRequest(string ManagementUnitId = null, List<string> UserIds = null, List<string> TeamIds = null)
        {
            this.ManagementUnitId = ManagementUnitId;
            this.UserIds = UserIds;
            this.TeamIds = TeamIds;

        }



        /// <summary>
        /// The ID of the management unit to query
        /// </summary>
        /// <value>The ID of the management unit to query</value>
        [DataMember(Name = "managementUnitId", EmitDefaultValue = false)]
        public string ManagementUnitId { get; set; }



        /// <summary>
        /// The IDs of the users to query.  Omit to query all user schedules in the management unit. Note: If teamIds is also specified, only schedules for users in the requested teams will be returned
        /// </summary>
        /// <value>The IDs of the users to query.  Omit to query all user schedules in the management unit. Note: If teamIds is also specified, only schedules for users in the requested teams will be returned</value>
        [DataMember(Name = "userIds", EmitDefaultValue = false)]
        public List<string> UserIds { get; set; }



        /// <summary>
        /// The teamIds to request. If null or not set, results will be queried for requested users if applicable or otherwise all users in the management unit
        /// </summary>
        /// <value>The teamIds to request. If null or not set, results will be queried for requested users if applicable or otherwise all users in the management unit</value>
        [DataMember(Name = "teamIds", EmitDefaultValue = false)]
        public List<string> TeamIds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuQueryAgentSchedulesRequest {\n");

            sb.Append("  ManagementUnitId: ").Append(ManagementUnitId).Append("\n");
            sb.Append("  UserIds: ").Append(UserIds).Append("\n");
            sb.Append("  TeamIds: ").Append(TeamIds).Append("\n");
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
            return this.Equals(obj as BuQueryAgentSchedulesRequest);
        }

        /// <summary>
        /// Returns true if BuQueryAgentSchedulesRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of BuQueryAgentSchedulesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuQueryAgentSchedulesRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ManagementUnitId == other.ManagementUnitId ||
                    this.ManagementUnitId != null &&
                    this.ManagementUnitId.Equals(other.ManagementUnitId)
                ) &&
                (
                    this.UserIds == other.UserIds ||
                    this.UserIds != null &&
                    this.UserIds.SequenceEqual(other.UserIds)
                ) &&
                (
                    this.TeamIds == other.TeamIds ||
                    this.TeamIds != null &&
                    this.TeamIds.SequenceEqual(other.TeamIds)
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
                if (this.ManagementUnitId != null)
                    hash = hash * 59 + this.ManagementUnitId.GetHashCode();

                if (this.UserIds != null)
                    hash = hash * 59 + this.UserIds.GetHashCode();

                if (this.TeamIds != null)
                    hash = hash * 59 + this.TeamIds.GetHashCode();

                return hash;
            }
        }
    }

}
