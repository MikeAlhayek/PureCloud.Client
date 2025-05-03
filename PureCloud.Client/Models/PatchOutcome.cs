using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PatchOutcome
/// </summary>

public partial class PatchOutcome : IEquatable<PatchOutcome>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="PatchOutcome" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected PatchOutcome() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="PatchOutcome" /> class.
    /// </summary>
    /// <param name="IsActive">Whether or not the outcome is active..</param>
    /// <param name="DisplayName">The display name of the outcome. (required).</param>
    /// <param name="Version">The version of the outcome..</param>
    /// <param name="Description">A description of the outcome..</param>
    /// <param name="IsPositive">Whether or not the outcome is positive..</param>
    /// <param name="Context">The context of the outcome..</param>
    /// <param name="Journey">The pattern of rules defining the filter of the outcome..</param>
    /// <param name="AssociatedValueField">The field from the event indicating the associated value..</param>
    public PatchOutcome(bool? IsActive = null, string DisplayName = null, int? Version = null, string Description = null, bool? IsPositive = null, PatchContext Context = null, PatchJourney Journey = null, PatchAssociatedValueField AssociatedValueField = null)
    {
        this.IsActive = IsActive;
        this.DisplayName = DisplayName;
        this.Version = Version;
        this.Description = Description;
        this.IsPositive = IsPositive;
        this.Context = Context;
        this.Journey = Journey;
        this.AssociatedValueField = AssociatedValueField;

    }



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
    public PatchContext Context { get; set; }



    /// <summary>
    /// The pattern of rules defining the filter of the outcome.
    /// </summary>
    /// <value>The pattern of rules defining the filter of the outcome.</value>
    [JsonPropertyName("journey")]
    public PatchJourney Journey { get; set; }



    /// <summary>
    /// The field from the event indicating the associated value.
    /// </summary>
    /// <value>The field from the event indicating the associated value.</value>
    [JsonPropertyName("associatedValueField")]
    public PatchAssociatedValueField AssociatedValueField { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PatchOutcome {\n");

        sb.Append("  IsActive: ").Append(IsActive).Append("\n");
        sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  IsPositive: ").Append(IsPositive).Append("\n");
        sb.Append("  Context: ").Append(Context).Append("\n");
        sb.Append("  Journey: ").Append(Journey).Append("\n");
        sb.Append("  AssociatedValueField: ").Append(AssociatedValueField).Append("\n");
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
        return Equals(obj as PatchOutcome);
    }

    /// <summary>
    /// Returns true if PatchOutcome instances are equal
    /// </summary>
    /// <param name="other">Instance of PatchOutcome to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PatchOutcome other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
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

            return hash;
        }
    }
}
