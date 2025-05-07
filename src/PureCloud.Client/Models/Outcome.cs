using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Outcome
/// </summary>

public partial class Outcome : IEquatable<Outcome>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="Outcome" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Outcome() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Outcome" /> class.
    /// </summary>
    /// <param name="Id">ID of the outcome. (required).</param>
    /// <param name="IsActive">Whether or not the outcome is active. (required).</param>
    /// <param name="DisplayName">The display name of the outcome. (required).</param>
    /// <param name="Version">The version of the outcome. (required).</param>
    /// <param name="Description">A description of the outcome..</param>
    /// <param name="IsPositive">Whether or not the outcome is positive. (required).</param>
    /// <param name="Context">The context of the outcome. (required).</param>
    /// <param name="Journey">The pattern of rules defining the filter of the outcome. (required).</param>
    /// <param name="AssociatedValueField">The field from the event indicating the associated value..</param>
    /// <param name="CreatedDate">Timestamp indicating when the outcome was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    /// <param name="ModifiedDate">Timestamp indicating when the outcome was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    public Outcome(string Id = null, bool? IsActive = null, string DisplayName = null, int? Version = null, string Description = null, bool? IsPositive = null, Context Context = null, Journey Journey = null, AssociatedValueField AssociatedValueField = null, DateTime? CreatedDate = null, DateTime? ModifiedDate = null)
    {
        this.Id = Id;
        this.IsActive = IsActive;
        this.DisplayName = DisplayName;
        this.Version = Version;
        this.Description = Description;
        this.IsPositive = IsPositive;
        this.Context = Context;
        this.Journey = Journey;
        this.AssociatedValueField = AssociatedValueField;
        this.CreatedDate = CreatedDate;
        this.ModifiedDate = ModifiedDate;

    }



    /// <summary>
    /// ID of the outcome.
    /// </summary>
    /// <value>ID of the outcome.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Whether or not the outcome is active.
    /// </summary>
    /// <value>Whether or not the outcome is active.</value>
    [JsonPropertyName("isActive")]
    public bool? IsActive { get; set; }



    /// <summary>
    /// The display name of the outcome.
    /// </summary>
    /// <value>The display name of the outcome.</value>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }



    /// <summary>
    /// The version of the outcome.
    /// </summary>
    /// <value>The version of the outcome.</value>
    [JsonPropertyName("version")]
    public int? Version { get; set; }



    /// <summary>
    /// A description of the outcome.
    /// </summary>
    /// <value>A description of the outcome.</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// Whether or not the outcome is positive.
    /// </summary>
    /// <value>Whether or not the outcome is positive.</value>
    [JsonPropertyName("isPositive")]
    public bool? IsPositive { get; set; }



    /// <summary>
    /// The context of the outcome.
    /// </summary>
    /// <value>The context of the outcome.</value>
    [JsonPropertyName("context")]
    public Context Context { get; set; }



    /// <summary>
    /// The pattern of rules defining the filter of the outcome.
    /// </summary>
    /// <value>The pattern of rules defining the filter of the outcome.</value>
    [JsonPropertyName("journey")]
    public Journey Journey { get; set; }



    /// <summary>
    /// The field from the event indicating the associated value.
    /// </summary>
    /// <value>The field from the event indicating the associated value.</value>
    [JsonPropertyName("associatedValueField")]
    public AssociatedValueField AssociatedValueField { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }



    /// <summary>
    /// Timestamp indicating when the outcome was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp indicating when the outcome was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("createdDate")]
    public DateTime? CreatedDate { get; set; }



    /// <summary>
    /// Timestamp indicating when the outcome was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp indicating when the outcome was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("modifiedDate")]
    public DateTime? ModifiedDate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Outcome {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  IsActive: ").Append(IsActive).Append("\n");
        sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  IsPositive: ").Append(IsPositive).Append("\n");
        sb.Append("  Context: ").Append(Context).Append("\n");
        sb.Append("  Journey: ").Append(Journey).Append("\n");
        sb.Append("  AssociatedValueField: ").Append(AssociatedValueField).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
        sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
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
        return Equals(obj as Outcome);
    }

    /// <summary>
    /// Returns true if Outcome instances are equal
    /// </summary>
    /// <param name="other">Instance of Outcome to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Outcome other)
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
                IsActive == other.IsActive ||
                IsActive != null &&
                IsActive.Equals(other.IsActive)
            ) &&
            (
                DisplayName == other.DisplayName ||
                DisplayName != null &&
                DisplayName.Equals(other.DisplayName)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                IsPositive == other.IsPositive ||
                IsPositive != null &&
                IsPositive.Equals(other.IsPositive)
            ) &&
            (
                Context == other.Context ||
                Context != null &&
                Context.Equals(other.Context)
            ) &&
            (
                Journey == other.Journey ||
                Journey != null &&
                Journey.Equals(other.Journey)
            ) &&
            (
                AssociatedValueField == other.AssociatedValueField ||
                AssociatedValueField != null &&
                AssociatedValueField.Equals(other.AssociatedValueField)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
            ) &&
            (
                CreatedDate == other.CreatedDate ||
                CreatedDate != null &&
                CreatedDate.Equals(other.CreatedDate)
            ) &&
            (
                ModifiedDate == other.ModifiedDate ||
                ModifiedDate != null &&
                ModifiedDate.Equals(other.ModifiedDate)
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

            if (IsActive != null)
            {
                hash = hash * 59 + IsActive.GetHashCode();
            }

            if (DisplayName != null)
            {
                hash = hash * 59 + DisplayName.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (IsPositive != null)
            {
                hash = hash * 59 + IsPositive.GetHashCode();
            }

            if (Context != null)
            {
                hash = hash * 59 + Context.GetHashCode();
            }

            if (Journey != null)
            {
                hash = hash * 59 + Journey.GetHashCode();
            }

            if (AssociatedValueField != null)
            {
                hash = hash * 59 + AssociatedValueField.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            if (CreatedDate != null)
            {
                hash = hash * 59 + CreatedDate.GetHashCode();
            }

            if (ModifiedDate != null)
            {
                hash = hash * 59 + ModifiedDate.GetHashCode();
            }

            return hash;
        }
    }
}
