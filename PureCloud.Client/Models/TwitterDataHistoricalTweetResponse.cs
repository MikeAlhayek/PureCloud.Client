using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TwitterDataHistoricalTweetResponse
/// </summary>
[DataContract]
public partial class TwitterDataHistoricalTweetResponse : IEquatable<TwitterDataHistoricalTweetResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TwitterDataHistoricalTweetResponse" /> class.
    /// </summary>
    /// <param name="MatchingTweets">The count of matching tweets using the searchTerms..</param>
    /// <param name="PreviousNumberOfDays">The number of days used for the query.</param>
    /// <param name="UsageStatistics">The tweet usage of the org.</param>
    public TwitterDataHistoricalTweetResponse(long? MatchingTweets = null, int? PreviousNumberOfDays = null, TweetUsage UsageStatistics = null)
    {
        this.MatchingTweets = MatchingTweets;
        this.PreviousNumberOfDays = PreviousNumberOfDays;
        this.UsageStatistics = UsageStatistics;

    }



    /// <summary>
    /// The count of matching tweets using the searchTerms.
    /// </summary>
    /// <value>The count of matching tweets using the searchTerms.</value>
    [DataMember(Name = "matchingTweets", EmitDefaultValue = false)]
    public long? MatchingTweets { get; set; }



    /// <summary>
    /// The number of days used for the query
    /// </summary>
    /// <value>The number of days used for the query</value>
    [DataMember(Name = "previousNumberOfDays", EmitDefaultValue = false)]
    public int? PreviousNumberOfDays { get; set; }



    /// <summary>
    /// The tweet usage of the org
    /// </summary>
    /// <value>The tweet usage of the org</value>
    [DataMember(Name = "usageStatistics", EmitDefaultValue = false)]
    public TweetUsage UsageStatistics { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TwitterDataHistoricalTweetResponse {\n");

        sb.Append("  MatchingTweets: ").Append(MatchingTweets).Append("\n");
        sb.Append("  PreviousNumberOfDays: ").Append(PreviousNumberOfDays).Append("\n");
        sb.Append("  UsageStatistics: ").Append(UsageStatistics).Append("\n");
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
        return Equals(obj as TwitterDataHistoricalTweetResponse);
    }

    /// <summary>
    /// Returns true if TwitterDataHistoricalTweetResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of TwitterDataHistoricalTweetResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TwitterDataHistoricalTweetResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                MatchingTweets == other.MatchingTweets ||
                MatchingTweets != null &&
                MatchingTweets.Equals(other.MatchingTweets)
            ) &&
            (
                PreviousNumberOfDays == other.PreviousNumberOfDays ||
                PreviousNumberOfDays != null &&
                PreviousNumberOfDays.Equals(other.PreviousNumberOfDays)
            ) &&
            (
                UsageStatistics == other.UsageStatistics ||
                UsageStatistics != null &&
                UsageStatistics.Equals(other.UsageStatistics)
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
            if (MatchingTweets != null)
            {
                hash = hash * 59 + MatchingTweets.GetHashCode();
            }

            if (PreviousNumberOfDays != null)
            {
                hash = hash * 59 + PreviousNumberOfDays.GetHashCode();
            }

            if (UsageStatistics != null)
            {
                hash = hash * 59 + UsageStatistics.GetHashCode();
            }

            return hash;
        }
    }
}
