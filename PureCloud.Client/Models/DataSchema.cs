using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DataSchema
/// </summary>
[DataContract]
public partial class DataSchema : IEquatable<DataSchema>
{
    /// <summary>
    /// Gets or Sets AppliesTo
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AppliesToEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Contact for "CONTACT"
        /// </summary>
        [EnumMember(Value = "CONTACT")]
        Contact,

        /// <summary>
        /// Enum Conversation for "CONVERSATION"
        /// </summary>
        [EnumMember(Value = "CONVERSATION")]
        Conversation,

        /// <summary>
        /// Enum ExternalOrganization for "EXTERNAL_ORGANIZATION"
        /// </summary>
        [EnumMember(Value = "EXTERNAL_ORGANIZATION")]
        ExternalOrganization,

        /// <summary>
        /// Enum OpenAction for "OPEN_ACTION"
        /// </summary>
        [EnumMember(Value = "OPEN_ACTION")]
        OpenAction,

        /// <summary>
        /// Enum Workitem for "WORKITEM"
        /// </summary>
        [EnumMember(Value = "WORKITEM")]
        Workitem,

        /// <summary>
        /// Enum DecisionTable for "DECISION_TABLE"
        /// </summary>
        [EnumMember(Value = "DECISION_TABLE")]
        DecisionTable
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DataSchema" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected DataSchema() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="DataSchema" /> class.
    /// </summary>
    /// <param name="Id">The globally unique identifier for the schema.  Only required if a schema is used for custom fields during external entity creation or updates..</param>
    /// <param name="Name">Name.</param>
    /// <param name="Version">The schema&#39;s version, a positive integer. Required for updates. (required).</param>
    /// <param name="Enabled">The schema&#39;s enabled/disabled status. A disabled schema cannot be assigned to any other entities, but the data on those entities from the schema still exists..</param>
    /// <param name="JsonSchema">A JSON schema defining the extension to the built-in entity type. (required).</param>
    public DataSchema(string Id = null, string Name = null, int? Version = null, bool? Enabled = null, JsonSchemaDocument JsonSchema = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.Version = Version;
        this.Enabled = Enabled;
        this.JsonSchema = JsonSchema;

    }



    /// <summary>
    /// The globally unique identifier for the schema.  Only required if a schema is used for custom fields during external entity creation or updates.
    /// </summary>
    /// <value>The globally unique identifier for the schema.  Only required if a schema is used for custom fields during external entity creation or updates.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The schema&#39;s version, a positive integer. Required for updates.
    /// </summary>
    /// <value>The schema&#39;s version, a positive integer. Required for updates.</value>
    [DataMember(Name = "version", EmitDefaultValue = false)]
    public int? Version { get; set; }



    /// <summary>
    /// Indicates the built-in entity type to which this schema applies.
    /// </summary>
    /// <value>Indicates the built-in entity type to which this schema applies.</value>
    [DataMember(Name = "appliesTo", EmitDefaultValue = false)]
    public List<AppliesToEnum> AppliesTo { get; private set; }



    /// <summary>
    /// The schema&#39;s enabled/disabled status. A disabled schema cannot be assigned to any other entities, but the data on those entities from the schema still exists.
    /// </summary>
    /// <value>The schema&#39;s enabled/disabled status. A disabled schema cannot be assigned to any other entities, but the data on those entities from the schema still exists.</value>
    [DataMember(Name = "enabled", EmitDefaultValue = false)]
    public bool? Enabled { get; set; }



    /// <summary>
    /// The URI of the user that created this schema.
    /// </summary>
    /// <value>The URI of the user that created this schema.</value>
    [DataMember(Name = "createdBy", EmitDefaultValue = false)]
    public DomainEntityRef CreatedBy { get; private set; }



    /// <summary>
    /// The date and time this schema was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date and time this schema was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateCreated", EmitDefaultValue = false)]
    public DateTime? DateCreated { get; private set; }



    /// <summary>
    /// A JSON schema defining the extension to the built-in entity type.
    /// </summary>
    /// <value>A JSON schema defining the extension to the built-in entity type.</value>
    [DataMember(Name = "jsonSchema", EmitDefaultValue = false)]
    public JsonSchemaDocument JsonSchema { get; set; }



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
        sb.Append("class DataSchema {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  AppliesTo: ").Append(AppliesTo).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  JsonSchema: ").Append(JsonSchema).Append("\n");
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
        return Equals(obj as DataSchema);
    }

    /// <summary>
    /// Returns true if DataSchema instances are equal
    /// </summary>
    /// <param name="other">Instance of DataSchema to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DataSchema other)
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
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                AppliesTo == other.AppliesTo ||
                AppliesTo != null &&
                AppliesTo.SequenceEqual(other.AppliesTo)
            ) &&
            (
                Enabled == other.Enabled ||
                Enabled != null &&
                Enabled.Equals(other.Enabled)
            ) &&
            (
                CreatedBy == other.CreatedBy ||
                CreatedBy != null &&
                CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                JsonSchema == other.JsonSchema ||
                JsonSchema != null &&
                JsonSchema.Equals(other.JsonSchema)
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

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (AppliesTo != null)
            {
                hash = hash * 59 + AppliesTo.GetHashCode();
            }

            if (Enabled != null)
            {
                hash = hash * 59 + Enabled.GetHashCode();
            }

            if (CreatedBy != null)
            {
                hash = hash * 59 + CreatedBy.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (JsonSchema != null)
            {
                hash = hash * 59 + JsonSchema.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
