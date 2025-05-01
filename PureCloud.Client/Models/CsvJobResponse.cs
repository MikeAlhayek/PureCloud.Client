using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CsvJobResponse
/// </summary>
[DataContract]
public partial class CsvJobResponse : IEquatable<CsvJobResponse>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="CsvJobResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CsvJobResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CsvJobResponse" /> class.
    /// </summary>
    /// <param name="Job">Job for the import (required).</param>
    public CsvJobResponse(AddressableEntityRef Job = null)
    {
        this.Job = Job;

    }



    /// <summary>
    /// Job for the import
    /// </summary>
    /// <value>Job for the import</value>
    [DataMember(Name = "job", EmitDefaultValue = false)]
    public AddressableEntityRef Job { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CsvJobResponse {\n");

        sb.Append("  Job: ").Append(Job).Append("\n");
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
        return Equals(obj as CsvJobResponse);
    }

    /// <summary>
    /// Returns true if CsvJobResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of CsvJobResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CsvJobResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Job == other.Job ||
                Job != null &&
                Job.Equals(other.Job)
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
            if (Job != null)
            {
                hash = hash * 59 + Job.GetHashCode();
            }

            return hash;
        }
    }
}
