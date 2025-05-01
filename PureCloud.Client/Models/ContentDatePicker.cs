using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DatePicker content object.
/// </summary>
[DataContract]
public partial class ContentDatePicker : IEquatable<ContentDatePicker>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ContentDatePicker" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ContentDatePicker() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ContentDatePicker" /> class.
    /// </summary>
    /// <param name="Title">Text to show in the title..</param>
    /// <param name="Subtitle">Text to show in the description..</param>
    /// <param name="ImageUrl">URL of an image.</param>
    /// <param name="DateMinimum">The minimum Date Enabled in the datepicker calendar. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DateMaximum">The maximum Date Enabled in the datepicker calendar. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="AvailableTimes">An array of available times objects. (required).</param>
    public ContentDatePicker(string Title = null, string Subtitle = null, string ImageUrl = null, DateTime? DateMinimum = null, DateTime? DateMaximum = null, List<ContentDatePickerAvailableTime> AvailableTimes = null)
    {
        this.Title = Title;
        this.Subtitle = Subtitle;
        this.ImageUrl = ImageUrl;
        this.DateMinimum = DateMinimum;
        this.DateMaximum = DateMaximum;
        this.AvailableTimes = AvailableTimes;

    }



    /// <summary>
    /// Text to show in the title.
    /// </summary>
    /// <value>Text to show in the title.</value>
    [DataMember(Name = "title", EmitDefaultValue = false)]
    public string Title { get; set; }



    /// <summary>
    /// Text to show in the description.
    /// </summary>
    /// <value>Text to show in the description.</value>
    [DataMember(Name = "subtitle", EmitDefaultValue = false)]
    public string Subtitle { get; set; }



    /// <summary>
    /// URL of an image
    /// </summary>
    /// <value>URL of an image</value>
    [DataMember(Name = "imageUrl", EmitDefaultValue = false)]
    public string ImageUrl { get; set; }



    /// <summary>
    /// The minimum Date Enabled in the datepicker calendar. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The minimum Date Enabled in the datepicker calendar. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateMinimum", EmitDefaultValue = false)]
    public DateTime? DateMinimum { get; set; }



    /// <summary>
    /// The maximum Date Enabled in the datepicker calendar. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The maximum Date Enabled in the datepicker calendar. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateMaximum", EmitDefaultValue = false)]
    public DateTime? DateMaximum { get; set; }



    /// <summary>
    /// An array of available times objects.
    /// </summary>
    /// <value>An array of available times objects.</value>
    [DataMember(Name = "availableTimes", EmitDefaultValue = false)]
    public List<ContentDatePickerAvailableTime> AvailableTimes { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContentDatePicker {\n");

        sb.Append("  Title: ").Append(Title).Append("\n");
        sb.Append("  Subtitle: ").Append(Subtitle).Append("\n");
        sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
        sb.Append("  DateMinimum: ").Append(DateMinimum).Append("\n");
        sb.Append("  DateMaximum: ").Append(DateMaximum).Append("\n");
        sb.Append("  AvailableTimes: ").Append(AvailableTimes).Append("\n");
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
        return Equals(obj as ContentDatePicker);
    }

    /// <summary>
    /// Returns true if ContentDatePicker instances are equal
    /// </summary>
    /// <param name="other">Instance of ContentDatePicker to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContentDatePicker other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Title == other.Title ||
                Title != null &&
                Title.Equals(other.Title)
            ) &&
            (
                Subtitle == other.Subtitle ||
                Subtitle != null &&
                Subtitle.Equals(other.Subtitle)
            ) &&
            (
                ImageUrl == other.ImageUrl ||
                ImageUrl != null &&
                ImageUrl.Equals(other.ImageUrl)
            ) &&
            (
                DateMinimum == other.DateMinimum ||
                DateMinimum != null &&
                DateMinimum.Equals(other.DateMinimum)
            ) &&
            (
                DateMaximum == other.DateMaximum ||
                DateMaximum != null &&
                DateMaximum.Equals(other.DateMaximum)
            ) &&
            (
                AvailableTimes == other.AvailableTimes ||
                AvailableTimes != null &&
                AvailableTimes.SequenceEqual(other.AvailableTimes)
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
            if (Title != null)
            {
                hash = hash * 59 + Title.GetHashCode();
            }

            if (Subtitle != null)
            {
                hash = hash * 59 + Subtitle.GetHashCode();
            }

            if (ImageUrl != null)
            {
                hash = hash * 59 + ImageUrl.GetHashCode();
            }

            if (DateMinimum != null)
            {
                hash = hash * 59 + DateMinimum.GetHashCode();
            }

            if (DateMaximum != null)
            {
                hash = hash * 59 + DateMaximum.GetHashCode();
            }

            if (AvailableTimes != null)
            {
                hash = hash * 59 + AvailableTimes.GetHashCode();
            }

            return hash;
        }
    }
}
