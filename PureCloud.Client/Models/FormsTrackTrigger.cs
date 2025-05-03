using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Details about a forms tracking event trigger
/// </summary>

public partial class FormsTrackTrigger : IEquatable<FormsTrackTrigger>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="FormsTrackTrigger" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected FormsTrackTrigger() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="FormsTrackTrigger" /> class.
    /// </summary>
    /// <param name="Selector">Form element that triggers the form submitted or abandoned event. (required).</param>
    /// <param name="FormName">Prefix for the form submitted or abandoned event name. (required).</param>
    /// <param name="CaptureDataOnFormAbandon">Whether to capture the form data in the form abandoned event. (required).</param>
    /// <param name="CaptureDataOnFormSubmit">Whether to capture the form data in the form submitted event. (required).</param>
    public FormsTrackTrigger(string Selector = null, string FormName = null, bool? CaptureDataOnFormAbandon = null, bool? CaptureDataOnFormSubmit = null)
    {
        this.Selector = Selector;
        this.FormName = FormName;
        this.CaptureDataOnFormAbandon = CaptureDataOnFormAbandon;
        this.CaptureDataOnFormSubmit = CaptureDataOnFormSubmit;

    }



    /// <summary>
    /// Form element that triggers the form submitted or abandoned event.
    /// </summary>
    /// <value>Form element that triggers the form submitted or abandoned event.</value>
    [JsonPropertyName("selector")]
    public string Selector { get; set; }



    /// <summary>
    /// Prefix for the form submitted or abandoned event name.
    /// </summary>
    /// <value>Prefix for the form submitted or abandoned event name.</value>
    [JsonPropertyName("formName")]
    public string FormName { get; set; }



    /// <summary>
    /// Whether to capture the form data in the form abandoned event.
    /// </summary>
    /// <value>Whether to capture the form data in the form abandoned event.</value>
    [JsonPropertyName("captureDataOnFormAbandon")]
    public bool? CaptureDataOnFormAbandon { get; set; }



    /// <summary>
    /// Whether to capture the form data in the form submitted event.
    /// </summary>
    /// <value>Whether to capture the form data in the form submitted event.</value>
    [JsonPropertyName("captureDataOnFormSubmit")]
    public bool? CaptureDataOnFormSubmit { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FormsTrackTrigger {\n");

        sb.Append("  Selector: ").Append(Selector).Append("\n");
        sb.Append("  FormName: ").Append(FormName).Append("\n");
        sb.Append("  CaptureDataOnFormAbandon: ").Append(CaptureDataOnFormAbandon).Append("\n");
        sb.Append("  CaptureDataOnFormSubmit: ").Append(CaptureDataOnFormSubmit).Append("\n");
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
        return Equals(obj as FormsTrackTrigger);
    }

    /// <summary>
    /// Returns true if FormsTrackTrigger instances are equal
    /// </summary>
    /// <param name="other">Instance of FormsTrackTrigger to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FormsTrackTrigger other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Selector == other.Selector ||
                Selector != null &&
                Selector.Equals(other.Selector)
            ) &&
            (
                FormName == other.FormName ||
                FormName != null &&
                FormName.Equals(other.FormName)
            ) &&
            (
                CaptureDataOnFormAbandon == other.CaptureDataOnFormAbandon ||
                CaptureDataOnFormAbandon != null &&
                CaptureDataOnFormAbandon.Equals(other.CaptureDataOnFormAbandon)
            ) &&
            (
                CaptureDataOnFormSubmit == other.CaptureDataOnFormSubmit ||
                CaptureDataOnFormSubmit != null &&
                CaptureDataOnFormSubmit.Equals(other.CaptureDataOnFormSubmit)
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
            if (Selector != null)
            {
                hash = hash * 59 + Selector.GetHashCode();
            }

            if (FormName != null)
            {
                hash = hash * 59 + FormName.GetHashCode();
            }

            if (CaptureDataOnFormAbandon != null)
            {
                hash = hash * 59 + CaptureDataOnFormAbandon.GetHashCode();
            }

            if (CaptureDataOnFormSubmit != null)
            {
                hash = hash * 59 + CaptureDataOnFormSubmit.GetHashCode();
            }

            return hash;
        }
    }
}
