using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// HistoryHeadersTranslation
/// </summary>

public partial class HistoryHeadersTranslation : IEquatable<HistoryHeadersTranslation>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="HistoryHeadersTranslation" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected HistoryHeadersTranslation() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="HistoryHeadersTranslation" /> class.
    /// </summary>
    /// <param name="From">A translation for the word \&quot;from\&quot;, for the expected language (required).</param>
    /// <param name="To">A translation for the word \&quot;to\&quot;, for the expected language (required).</param>
    /// <param name="Cc">A translation for the word \&quot;cc\&quot;, for the expected language (required).</param>
    /// <param name="Subject">A translation for the word \&quot;subject\&quot;, for the expected language (required).</param>
    /// <param name="ReplyPrefix">A translation for the subject prefix \&quot;Reply\&quot;, for the expected language (required).</param>
    /// <param name="ForwardPrefix">A translation for the subject prefix \&quot;Forward\&quot;, for the expected language (required).</param>
    /// <param name="Sent">A translation for the word \&quot;sent\&quot;, for the expected language (required).</param>
    /// <param name="Language">The code of the expected language (required).</param>
    /// <param name="TimeZone">Timezone used by the agent, used to format the sent email date and time. If not defined, will default to UTC. Time zones are represented as a string of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London.</param>
    public HistoryHeadersTranslation(string From = null, string To = null, string Cc = null, string Subject = null, string ReplyPrefix = null, string ForwardPrefix = null, string Sent = null, string Language = null, string TimeZone = null)
    {
        this.From = From;
        this.To = To;
        this.Cc = Cc;
        this.Subject = Subject;
        this.ReplyPrefix = ReplyPrefix;
        this.ForwardPrefix = ForwardPrefix;
        this.Sent = Sent;
        this.Language = Language;
        this.TimeZone = TimeZone;

    }



    /// <summary>
    /// A translation for the word \&quot;from\&quot;, for the expected language
    /// </summary>
    /// <value>A translation for the word \&quot;from\&quot;, for the expected language</value>
    [JsonPropertyName("from")]
    public string From { get; set; }



    /// <summary>
    /// A translation for the word \&quot;to\&quot;, for the expected language
    /// </summary>
    /// <value>A translation for the word \&quot;to\&quot;, for the expected language</value>
    [JsonPropertyName("to")]
    public string To { get; set; }



    /// <summary>
    /// A translation for the word \&quot;cc\&quot;, for the expected language
    /// </summary>
    /// <value>A translation for the word \&quot;cc\&quot;, for the expected language</value>
    [JsonPropertyName("cc")]
    public string Cc { get; set; }



    /// <summary>
    /// A translation for the word \&quot;subject\&quot;, for the expected language
    /// </summary>
    /// <value>A translation for the word \&quot;subject\&quot;, for the expected language</value>
    [JsonPropertyName("subject")]
    public string Subject { get; set; }



    /// <summary>
    /// A translation for the subject prefix \&quot;Reply\&quot;, for the expected language
    /// </summary>
    /// <value>A translation for the subject prefix \&quot;Reply\&quot;, for the expected language</value>
    [JsonPropertyName("replyPrefix")]
    public string ReplyPrefix { get; set; }



    /// <summary>
    /// A translation for the subject prefix \&quot;Forward\&quot;, for the expected language
    /// </summary>
    /// <value>A translation for the subject prefix \&quot;Forward\&quot;, for the expected language</value>
    [JsonPropertyName("forwardPrefix")]
    public string ForwardPrefix { get; set; }



    /// <summary>
    /// A translation for the word \&quot;sent\&quot;, for the expected language
    /// </summary>
    /// <value>A translation for the word \&quot;sent\&quot;, for the expected language</value>
    [JsonPropertyName("sent")]
    public string Sent { get; set; }



    /// <summary>
    /// The code of the expected language
    /// </summary>
    /// <value>The code of the expected language</value>
    [JsonPropertyName("language")]
    public string Language { get; set; }



    /// <summary>
    /// Timezone used by the agent, used to format the sent email date and time. If not defined, will default to UTC. Time zones are represented as a string of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London
    /// </summary>
    /// <value>Timezone used by the agent, used to format the sent email date and time. If not defined, will default to UTC. Time zones are represented as a string of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London</value>
    [JsonPropertyName("timeZone")]
    public string TimeZone { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class HistoryHeadersTranslation {\n");

        sb.Append("  From: ").Append(From).Append("\n");
        sb.Append("  To: ").Append(To).Append("\n");
        sb.Append("  Cc: ").Append(Cc).Append("\n");
        sb.Append("  Subject: ").Append(Subject).Append("\n");
        sb.Append("  ReplyPrefix: ").Append(ReplyPrefix).Append("\n");
        sb.Append("  ForwardPrefix: ").Append(ForwardPrefix).Append("\n");
        sb.Append("  Sent: ").Append(Sent).Append("\n");
        sb.Append("  Language: ").Append(Language).Append("\n");
        sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
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
        return Equals(obj as HistoryHeadersTranslation);
    }

    /// <summary>
    /// Returns true if HistoryHeadersTranslation instances are equal
    /// </summary>
    /// <param name="other">Instance of HistoryHeadersTranslation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(HistoryHeadersTranslation other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                From == other.From ||
                From != null &&
                From.Equals(other.From)
            ) &&
            (
                To == other.To ||
                To != null &&
                To.Equals(other.To)
            ) &&
            (
                Cc == other.Cc ||
                Cc != null &&
                Cc.Equals(other.Cc)
            ) &&
            (
                Subject == other.Subject ||
                Subject != null &&
                Subject.Equals(other.Subject)
            ) &&
            (
                ReplyPrefix == other.ReplyPrefix ||
                ReplyPrefix != null &&
                ReplyPrefix.Equals(other.ReplyPrefix)
            ) &&
            (
                ForwardPrefix == other.ForwardPrefix ||
                ForwardPrefix != null &&
                ForwardPrefix.Equals(other.ForwardPrefix)
            ) &&
            (
                Sent == other.Sent ||
                Sent != null &&
                Sent.Equals(other.Sent)
            ) &&
            (
                Language == other.Language ||
                Language != null &&
                Language.Equals(other.Language)
            ) &&
            (
                TimeZone == other.TimeZone ||
                TimeZone != null &&
                TimeZone.Equals(other.TimeZone)
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
            if (From != null)
            {
                hash = hash * 59 + From.GetHashCode();
            }

            if (To != null)
            {
                hash = hash * 59 + To.GetHashCode();
            }

            if (Cc != null)
            {
                hash = hash * 59 + Cc.GetHashCode();
            }

            if (Subject != null)
            {
                hash = hash * 59 + Subject.GetHashCode();
            }

            if (ReplyPrefix != null)
            {
                hash = hash * 59 + ReplyPrefix.GetHashCode();
            }

            if (ForwardPrefix != null)
            {
                hash = hash * 59 + ForwardPrefix.GetHashCode();
            }

            if (Sent != null)
            {
                hash = hash * 59 + Sent.GetHashCode();
            }

            if (Language != null)
            {
                hash = hash * 59 + Language.GetHashCode();
            }

            if (TimeZone != null)
            {
                hash = hash * 59 + TimeZone.GetHashCode();
            }

            return hash;
        }
    }
}
