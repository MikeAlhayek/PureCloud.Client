using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ContentDatePicker
{
    /// <summary>
    /// Text to show in the title.
    /// </summary>
    /// <value>Text to show in the title.</value>
    public string Title { get; set; }

    /// <summary>
    /// Text to show in the description.
    /// </summary>
    /// <value>Text to show in the description.</value>
    public string Subtitle { get; set; }

    /// <summary>
    /// URL of an image
    /// </summary>
    /// <value>URL of an image</value>
    public string ImageUrl { get; set; }

    /// <summary>
    /// The minimum Date Enabled in the datepicker calendar. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The minimum Date Enabled in the datepicker calendar. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateMinimum { get; set; }

    /// <summary>
    /// The maximum Date Enabled in the datepicker calendar. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The maximum Date Enabled in the datepicker calendar. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateMaximum { get; set; }

    /// <summary>
    /// An array of available times objects.
    /// </summary>
    /// <value>An array of available times objects.</value>
    public IEnumerable<ContentDatePickerAvailableTime> AvailableTimes { get; set; }
}
