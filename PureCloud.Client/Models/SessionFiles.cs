using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SessionFiles
/// </summary>
[DataContract]
public partial class SessionFiles : IEquatable<SessionFiles>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SessionFiles" /> class.
    /// </summary>
    /// <param name="MetaData">Metadata for the requested session.</param>
    /// <param name="Offered">Offered data for the requested session.</param>
    /// <param name="AverageHandleTime">Average handle time data for the requested session.</param>
    public SessionFiles(SessionMetaData MetaData = null, SessionMetricData Offered = null, SessionMetricData AverageHandleTime = null)
    {
        this.MetaData = MetaData;
        this.Offered = Offered;
        this.AverageHandleTime = AverageHandleTime;

    }



    /// <summary>
    /// Metadata for the requested session
    /// </summary>
    /// <value>Metadata for the requested session</value>
    [DataMember(Name = "metaData", EmitDefaultValue = false)]
    public SessionMetaData MetaData { get; set; }



    /// <summary>
    /// Offered data for the requested session
    /// </summary>
    /// <value>Offered data for the requested session</value>
    [DataMember(Name = "offered", EmitDefaultValue = false)]
    public SessionMetricData Offered { get; set; }



    /// <summary>
    /// Average handle time data for the requested session
    /// </summary>
    /// <value>Average handle time data for the requested session</value>
    [DataMember(Name = "averageHandleTime", EmitDefaultValue = false)]
    public SessionMetricData AverageHandleTime { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SessionFiles {\n");

        sb.Append("  MetaData: ").Append(MetaData).Append("\n");
        sb.Append("  Offered: ").Append(Offered).Append("\n");
        sb.Append("  AverageHandleTime: ").Append(AverageHandleTime).Append("\n");
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
        return Equals(obj as SessionFiles);
    }

    /// <summary>
    /// Returns true if SessionFiles instances are equal
    /// </summary>
    /// <param name="other">Instance of SessionFiles to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SessionFiles other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                MetaData == other.MetaData ||
                MetaData != null &&
                MetaData.Equals(other.MetaData)
            ) &&
            (
                Offered == other.Offered ||
                Offered != null &&
                Offered.Equals(other.Offered)
            ) &&
            (
                AverageHandleTime == other.AverageHandleTime ||
                AverageHandleTime != null &&
                AverageHandleTime.Equals(other.AverageHandleTime)
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
            if (MetaData != null)
            {
                hash = hash * 59 + MetaData.GetHashCode();
            }

            if (Offered != null)
            {
                hash = hash * 59 + Offered.GetHashCode();
            }

            if (AverageHandleTime != null)
            {
                hash = hash * 59 + AverageHandleTime.GetHashCode();
            }

            return hash;
        }
    }
}
