using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// DialerRulesetConfigChangeRuleSet
/// </summary>
[DataContract]
public partial class DialerRulesetConfigChangeRuleSet : IEquatable<DialerRulesetConfigChangeRuleSet>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DialerRulesetConfigChangeRuleSet" /> class.
    /// </summary>
    /// <param name="ContactList">ContactList.</param>
    /// <param name="Queue">A UriReference for a resource.</param>
    /// <param name="Rules">Rules.</param>
    /// <param name="AdditionalProperties">AdditionalProperties.</param>
    /// <param name="Id">The globally unique identifier for the object..</param>
    /// <param name="Name">The UI-visible name of the object.</param>
    /// <param name="DateCreated">Creation time of the entity.</param>
    /// <param name="DateModified">Last modified time of the entity.</param>
    /// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
    public DialerRulesetConfigChangeRuleSet(DialerRulesetConfigChangeUriReference ContactList = null, DialerRulesetConfigChangeUriReference Queue = null, List<DialerRulesetConfigChangeRule> Rules = null, Dictionary<string, object> AdditionalProperties = null, string Id = null, string Name = null, DateTime? DateCreated = null, DateTime? DateModified = null, long? Version = null)
    {
        this.ContactList = ContactList;
        this.Queue = Queue;
        this.Rules = Rules;
        this.AdditionalProperties = AdditionalProperties;
        this.Id = Id;
        this.Name = Name;
        this.DateCreated = DateCreated;
        this.DateModified = DateModified;
        this.Version = Version;

    }



    /// <summary>
    /// Gets or Sets ContactList
    /// </summary>
    [DataMember(Name = "contactList", EmitDefaultValue = false)]
    public DialerRulesetConfigChangeUriReference ContactList { get; set; }



    /// <summary>
    /// A UriReference for a resource
    /// </summary>
    /// <value>A UriReference for a resource</value>
    [DataMember(Name = "queue", EmitDefaultValue = false)]
    public DialerRulesetConfigChangeUriReference Queue { get; set; }



    /// <summary>
    /// Gets or Sets Rules
    /// </summary>
    [DataMember(Name = "rules", EmitDefaultValue = false)]
    public List<DialerRulesetConfigChangeRule> Rules { get; set; }



    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    [DataMember(Name = "additionalProperties", EmitDefaultValue = false)]
    public Dictionary<string, object> AdditionalProperties { get; set; }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// The UI-visible name of the object
    /// </summary>
    /// <value>The UI-visible name of the object</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Creation time of the entity
    /// </summary>
    /// <value>Creation time of the entity</value>
    [DataMember(Name = "dateCreated", EmitDefaultValue = false)]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Last modified time of the entity
    /// </summary>
    /// <value>Last modified time of the entity</value>
    [DataMember(Name = "dateModified", EmitDefaultValue = false)]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// Required for updates, must match the version number of the most recent update
    /// </summary>
    /// <value>Required for updates, must match the version number of the most recent update</value>
    [DataMember(Name = "version", EmitDefaultValue = false)]
    public long? Version { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DialerRulesetConfigChangeRuleSet {\n");

        sb.Append("  ContactList: ").Append(ContactList).Append("\n");
        sb.Append("  Queue: ").Append(Queue).Append("\n");
        sb.Append("  Rules: ").Append(Rules).Append("\n");
        sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
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
        return Equals(obj as DialerRulesetConfigChangeRuleSet);
    }

    /// <summary>
    /// Returns true if DialerRulesetConfigChangeRuleSet instances are equal
    /// </summary>
    /// <param name="other">Instance of DialerRulesetConfigChangeRuleSet to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DialerRulesetConfigChangeRuleSet other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ContactList == other.ContactList ||
                ContactList != null &&
                ContactList.Equals(other.ContactList)
            ) &&
            (
                Queue == other.Queue ||
                Queue != null &&
                Queue.Equals(other.Queue)
            ) &&
            (
                Rules == other.Rules ||
                Rules != null &&
                Rules.SequenceEqual(other.Rules)
            ) &&
            (
                AdditionalProperties == other.AdditionalProperties ||
                AdditionalProperties != null &&
                AdditionalProperties.SequenceEqual(other.AdditionalProperties)
            ) &&
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
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
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
            if (ContactList != null)
            {
                hash = hash * 59 + ContactList.GetHashCode();
            }

            if (Queue != null)
            {
                hash = hash * 59 + Queue.GetHashCode();
            }

            if (Rules != null)
            {
                hash = hash * 59 + Rules.GetHashCode();
            }

            if (AdditionalProperties != null)
            {
                hash = hash * 59 + AdditionalProperties.GetHashCode();
            }

            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            return hash;
        }
    }
}
