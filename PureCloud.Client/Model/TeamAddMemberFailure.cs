using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// TeamAddMemberFailure
    /// </summary>
    [DataContract]
    public partial class TeamAddMemberFailure :  IEquatable<TeamAddMemberFailure>
    {
        /// <summary>
        /// Specific reason the member could not be added.
        /// </summary>
        /// <value>Specific reason the member could not be added.</value>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public enum ReasonEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Usernotfound for "UserNotFound"
            /// </summary>
            [EnumMember(Value = "UserNotFound")]
            Usernotfound,
            
            /// <summary>
            /// Enum Usergrouplimitexceeded for "UserGroupLimitExceeded"
            /// </summary>
            [EnumMember(Value = "UserGroupLimitExceeded")]
            Usergrouplimitexceeded,
            
            /// <summary>
            /// Enum Usergroupdivisionmismatch for "UserGroupDivisionMismatch"
            /// </summary>
            [EnumMember(Value = "UserGroupDivisionMismatch")]
            Usergroupdivisionmismatch
        }
        /// <summary>
        /// Specific reason the member could not be added.
        /// </summary>
        /// <value>Specific reason the member could not be added.</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public ReasonEnum? Reason { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamAddMemberFailure" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        public TeamAddMemberFailure(string Id = null)
        {
            this.Id = Id;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamAddMemberFailure {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                Formatting = Formatting.Indented
            });
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as TeamAddMemberFailure);
        }

        /// <summary>
        /// Returns true if TeamAddMemberFailure instances are equal
        /// </summary>
        /// <param name="other">Instance of TeamAddMemberFailure to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamAddMemberFailure other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();

                return hash;
            }
        }
    }

}
