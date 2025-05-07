using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DigitalRuleSet
/// </summary>

public partial class DigitalRuleSet : IEquatable<DigitalRuleSet>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="DigitalRuleSet" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected DigitalRuleSet() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="DigitalRuleSet" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
    /// <param name="ContactList">A ContactList to provide suggestions for contact columns on relevant conditions and actions..</param>
    /// <param name="Rules">The list of rules. (required).</param>
    public DigitalRuleSet(string Name = null, int? Version = null, DomainEntityRef ContactList = null, List<DigitalRule> Rules = null)
    {
        this.Name = Name;
        this.Version = Version;
        this.ContactList = ContactList;
        this.Rules = Rules;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// Required for updates, must match the version number of the most recent update
    /// </summary>
    /// <value>Required for updates, must match the version number of the most recent update</value>
    [JsonPropertyName("version")]
    public int? Version { get; set; }



    /// <summary>
    /// A ContactList to provide suggestions for contact columns on relevant conditions and actions.
    /// </summary>
    /// <value>A ContactList to provide suggestions for contact columns on relevant conditions and actions.</value>
    [JsonPropertyName("contactList")]
    public DomainEntityRef ContactList { get; set; }



    /// <summary>
    /// The list of rules.
    /// </summary>
    /// <value>The list of rules.</value>
    [JsonPropertyName("rules")]
    public List<DigitalRule> Rules { get; set; }



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
        sb.Append("class DigitalRuleSet {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  ContactList: ").Append(ContactList).Append("\n");
        sb.Append("  Rules: ").Append(Rules).Append("\n");
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
        return Equals(obj as DigitalRuleSet);
    }

    /// <summary>
    /// Returns true if DigitalRuleSet instances are equal
    /// </summary>
    /// <param name="other">Instance of DigitalRuleSet to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DigitalRuleSet other)
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
            ) &&
            (
                ContactList == other.ContactList ||
                ContactList != null &&
                ContactList.Equals(other.ContactList)
            ) &&
            (
                Rules == other.Rules ||
                Rules != null &&
                Rules.SequenceEqual(other.Rules)
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

            if (ContactList != null)
            {
                hash = hash * 59 + ContactList.GetHashCode();
            }

            if (Rules != null)
            {
                hash = hash * 59 + Rules.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
