using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// JourneySegmentRequest
    /// </summary>
    [DataContract]
    public partial class JourneySegmentRequest :  IEquatable<JourneySegmentRequest>
    {
        /// <summary>
        /// The target entity that a segment applies to.
        /// </summary>
        /// <value>The target entity that a segment applies to.</value>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public enum ScopeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Session for "Session"
            /// </summary>
            [EnumMember(Value = "Session")]
            Session,
            
            /// <summary>
            /// Enum Customer for "Customer"
            /// </summary>
            [EnumMember(Value = "Customer")]
            Customer
        }
        /// <summary>
        /// The target entity that a segment applies to.
        /// </summary>
        /// <value>The target entity that a segment applies to.</value>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public ScopeEnum? Scope { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="JourneySegmentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected JourneySegmentRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneySegmentRequest" /> class.
        /// </summary>
        /// <param name="IsActive">Whether or not the segment is active..</param>
        /// <param name="DisplayName">The display name of the segment. (required).</param>
        /// <param name="Version">The version of the segment..</param>
        /// <param name="Description">A description of the segment..</param>
        /// <param name="Color">The hexadecimal color value of the segment. (required).</param>
        /// <param name="Scope">The target entity that a segment applies to..</param>
        /// <param name="ShouldDisplayToAgent">Whether or not the segment should be displayed to agent/supervisor users..</param>
        /// <param name="Context">The context of the segment. (required).</param>
        /// <param name="Journey">The pattern of rules defining the segment. (required).</param>
        /// <param name="ExternalSegment">Details of an entity corresponding to this segment in an external system..</param>
        /// <param name="AssignmentExpirationDays">Time, in days, from when the segment is assigned until it is automatically unassigned..</param>
        public JourneySegmentRequest(bool? IsActive = null, string DisplayName = null, int? Version = null, string Description = null, string Color = null, ScopeEnum? Scope = null, bool? ShouldDisplayToAgent = null, RequestContext Context = null, RequestJourney Journey = null, RequestExternalSegment ExternalSegment = null, int? AssignmentExpirationDays = null)
        {
            this.IsActive = IsActive;
            this.DisplayName = DisplayName;
            this.Version = Version;
            this.Description = Description;
            this.Color = Color;
            this.Scope = Scope;
            this.ShouldDisplayToAgent = ShouldDisplayToAgent;
            this.Context = Context;
            this.Journey = Journey;
            this.ExternalSegment = ExternalSegment;
            this.AssignmentExpirationDays = AssignmentExpirationDays;
            
        }
        


        /// <summary>
        /// Whether or not the segment is active.
        /// </summary>
        /// <value>Whether or not the segment is active.</value>
        [DataMember(Name="isActive", EmitDefaultValue=false)]
        public bool? IsActive { get; set; }



        /// <summary>
        /// The display name of the segment.
        /// </summary>
        /// <value>The display name of the segment.</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }



        /// <summary>
        /// The version of the segment.
        /// </summary>
        /// <value>The version of the segment.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }



        /// <summary>
        /// A description of the segment.
        /// </summary>
        /// <value>A description of the segment.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// The hexadecimal color value of the segment.
        /// </summary>
        /// <value>The hexadecimal color value of the segment.</value>
        [DataMember(Name="color", EmitDefaultValue=false)]
        public string Color { get; set; }





        /// <summary>
        /// Whether or not the segment should be displayed to agent/supervisor users.
        /// </summary>
        /// <value>Whether or not the segment should be displayed to agent/supervisor users.</value>
        [DataMember(Name="shouldDisplayToAgent", EmitDefaultValue=false)]
        public bool? ShouldDisplayToAgent { get; set; }



        /// <summary>
        /// The context of the segment.
        /// </summary>
        /// <value>The context of the segment.</value>
        [DataMember(Name="context", EmitDefaultValue=false)]
        public RequestContext Context { get; set; }



        /// <summary>
        /// The pattern of rules defining the segment.
        /// </summary>
        /// <value>The pattern of rules defining the segment.</value>
        [DataMember(Name="journey", EmitDefaultValue=false)]
        public RequestJourney Journey { get; set; }



        /// <summary>
        /// Details of an entity corresponding to this segment in an external system.
        /// </summary>
        /// <value>Details of an entity corresponding to this segment in an external system.</value>
        [DataMember(Name="externalSegment", EmitDefaultValue=false)]
        public RequestExternalSegment ExternalSegment { get; set; }



        /// <summary>
        /// Time, in days, from when the segment is assigned until it is automatically unassigned.
        /// </summary>
        /// <value>Time, in days, from when the segment is assigned until it is automatically unassigned.</value>
        [DataMember(Name="assignmentExpirationDays", EmitDefaultValue=false)]
        public int? AssignmentExpirationDays { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JourneySegmentRequest {\n");

            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  ShouldDisplayToAgent: ").Append(ShouldDisplayToAgent).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  Journey: ").Append(Journey).Append("\n");
            sb.Append("  ExternalSegment: ").Append(ExternalSegment).Append("\n");
            sb.Append("  AssignmentExpirationDays: ").Append(AssignmentExpirationDays).Append("\n");
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
            return this.Equals(obj as JourneySegmentRequest);
        }

        /// <summary>
        /// Returns true if JourneySegmentRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of JourneySegmentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JourneySegmentRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.IsActive == other.IsActive ||
                    this.IsActive != null &&
                    this.IsActive.Equals(other.IsActive)
                ) &&
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Color == other.Color ||
                    this.Color != null &&
                    this.Color.Equals(other.Color)
                ) &&
                (
                    this.Scope == other.Scope ||
                    this.Scope != null &&
                    this.Scope.Equals(other.Scope)
                ) &&
                (
                    this.ShouldDisplayToAgent == other.ShouldDisplayToAgent ||
                    this.ShouldDisplayToAgent != null &&
                    this.ShouldDisplayToAgent.Equals(other.ShouldDisplayToAgent)
                ) &&
                (
                    this.Context == other.Context ||
                    this.Context != null &&
                    this.Context.Equals(other.Context)
                ) &&
                (
                    this.Journey == other.Journey ||
                    this.Journey != null &&
                    this.Journey.Equals(other.Journey)
                ) &&
                (
                    this.ExternalSegment == other.ExternalSegment ||
                    this.ExternalSegment != null &&
                    this.ExternalSegment.Equals(other.ExternalSegment)
                ) &&
                (
                    this.AssignmentExpirationDays == other.AssignmentExpirationDays ||
                    this.AssignmentExpirationDays != null &&
                    this.AssignmentExpirationDays.Equals(other.AssignmentExpirationDays)
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
                if (this.IsActive != null)
                    hash = hash * 59 + this.IsActive.GetHashCode();

                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();

                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.Color != null)
                    hash = hash * 59 + this.Color.GetHashCode();

                if (this.Scope != null)
                    hash = hash * 59 + this.Scope.GetHashCode();

                if (this.ShouldDisplayToAgent != null)
                    hash = hash * 59 + this.ShouldDisplayToAgent.GetHashCode();

                if (this.Context != null)
                    hash = hash * 59 + this.Context.GetHashCode();

                if (this.Journey != null)
                    hash = hash * 59 + this.Journey.GetHashCode();

                if (this.ExternalSegment != null)
                    hash = hash * 59 + this.ExternalSegment.GetHashCode();

                if (this.AssignmentExpirationDays != null)
                    hash = hash * 59 + this.AssignmentExpirationDays.GetHashCode();

                return hash;
            }
        }
    }

}
