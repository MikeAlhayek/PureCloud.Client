using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TweetUsage
/// </summary>

public partial class TweetUsage : IEquatable<TweetUsage>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TweetUsage" /> class.
    /// </summary>
    /// <param name="IngestionLimit">Ingestion limit.</param>
    /// <param name="TweetCount">The number of tweets consumed.</param>
    /// <param name="DateStart">The start of the usage period for the currently consumed tweets. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public TweetUsage(long? IngestionLimit = null, long? TweetCount = null, DateTime? DateStart = null)
    {
        this.IngestionLimit = IngestionLimit;
        this.TweetCount = TweetCount;
        this.DateStart = DateStart;

    }



    /// <summary>
    /// Ingestion limit
    /// </summary>
    /// <value>Ingestion limit</value>
    [JsonPropertyName("ingestionLimit")]
    public long? IngestionLimit { get; set; }



    /// <summary>
    /// The number of tweets consumed
    /// </summary>
    /// <value>The number of tweets consumed</value>
    [JsonPropertyName("tweetCount")]
    public long? TweetCount { get; set; }



    /// <summary>
    /// The start of the usage period for the currently consumed tweets. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The start of the usage period for the currently consumed tweets. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateStart")]
    public DateTime? DateStart { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TweetUsage {\n");

        sb.Append("  IngestionLimit: ").Append(IngestionLimit).Append("\n");
        sb.Append("  TweetCount: ").Append(TweetCount).Append("\n");
        sb.Append("  DateStart: ").Append(DateStart).Append("\n");
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
        return Equals(obj as TweetUsage);
    }

    /// <summary>
    /// Returns true if TweetUsage instances are equal
    /// </summary>
    /// <param name="other">Instance of TweetUsage to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TweetUsage other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                IngestionLimit == other.IngestionLimit ||
                IngestionLimit != null &&
                IngestionLimit.Equals(other.IngestionLimit)
            ) &&
            (
                TweetCount == other.TweetCount ||
                TweetCount != null &&
                TweetCount.Equals(other.TweetCount)
            ) &&
            (
                DateStart == other.DateStart ||
                DateStart != null &&
                DateStart.Equals(other.DateStart)
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
            if (IngestionLimit != null)
            {
                hash = hash * 59 + IngestionLimit.GetHashCode();
            }

            if (TweetCount != null)
            {
                hash = hash * 59 + TweetCount.GetHashCode();
            }

            if (DateStart != null)
            {
                hash = hash * 59 + DateStart.GetHashCode();
            }

            return hash;
        }
    }
}
