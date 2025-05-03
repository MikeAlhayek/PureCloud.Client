namespace PureCloud.Client.Models;

public sealed class Education
{
    /// <summary>
    /// Gets or Sets School
    /// </summary>
    public string School { get; set; }

    /// <summary>
    /// Gets or Sets FieldOfStudy
    /// </summary>
    public string FieldOfStudy { get; set; }

    /// <summary>
    /// Notes about education has a 2000 character limit
    /// </summary>
    /// <value>Notes about education has a 2000 character limit</value>
    public string Notes { get; set; }

    /// <summary>
    /// Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    public string DateStart { get; set; }

    /// <summary>
    /// Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    public string DateEnd { get; set; }
}
