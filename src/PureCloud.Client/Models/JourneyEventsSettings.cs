using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Settings concerning journey events
/// </summary>

public partial class JourneyEventsSettings : IEquatable<JourneyEventsSettings>
{
    /// <summary>
    /// Controls how the pageview events are tracked.
    /// </summary>
    /// <value>Controls how the pageview events are tracked.</value>
    
    public enum PageviewConfigEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Auto for "Auto"
        /// </summary>
        [EnumMember(Value = "Auto")]
        Auto,

        /// <summary>
        /// Enum Once for "Once"
        /// </summary>
        [EnumMember(Value = "Once")]
        Once,

        /// <summary>
        /// Enum Off for "Off"
        /// </summary>
        [EnumMember(Value = "Off")]
        Off
    }
    /// <summary>
    /// Controls how the pageview events are tracked.
    /// </summary>
    /// <value>Controls how the pageview events are tracked.</value>
    [JsonPropertyName("pageviewConfig")]
    public PageviewConfigEnum? PageviewConfig { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyEventsSettings" /> class.
    /// </summary>
    /// <param name="Enabled">Whether or not journey event collection is enabled..</param>
    /// <param name="ExcludedQueryParameters">List of parameters to be excluded from the query string..</param>
    /// <param name="ShouldKeepUrlFragment">Whether or not to keep the URL fragment..</param>
    /// <param name="SearchQueryParameters">List of query parameters used for search (e.g. &#39;q&#39;)..</param>
    /// <param name="PageviewConfig">Controls how the pageview events are tracked..</param>
    /// <param name="ClickEvents">Tracks when and where a visitor clicks on a webpage..</param>
    /// <param name="FormsTrackEvents">Controls how the form submitted and form abandoned events are tracked after a visitor interacts with a form element..</param>
    /// <param name="IdleEvents">Tracks when and where a visitor becomes inactive on a webpage..</param>
    /// <param name="InViewportEvents">Tracks when elements become visible or hidden on screen..</param>
    /// <param name="ScrollDepthEvents">Tracks when a visitor scrolls to a specific percentage of a webpage..</param>
    public JourneyEventsSettings(bool? Enabled = null, List<string> ExcludedQueryParameters = null, bool? ShouldKeepUrlFragment = null, List<string> SearchQueryParameters = null, PageviewConfigEnum? PageviewConfig = null, List<SelectorEventTrigger> ClickEvents = null, List<FormsTrackTrigger> FormsTrackEvents = null, List<IdleEventTrigger> IdleEvents = null, List<SelectorEventTrigger> InViewportEvents = null, List<ScrollPercentageEventTrigger> ScrollDepthEvents = null)
    {
        this.Enabled = Enabled;
        this.ExcludedQueryParameters = ExcludedQueryParameters;
        this.ShouldKeepUrlFragment = ShouldKeepUrlFragment;
        this.SearchQueryParameters = SearchQueryParameters;
        this.PageviewConfig = PageviewConfig;
        this.ClickEvents = ClickEvents;
        this.FormsTrackEvents = FormsTrackEvents;
        this.IdleEvents = IdleEvents;
        this.InViewportEvents = InViewportEvents;
        this.ScrollDepthEvents = ScrollDepthEvents;

    }



    /// <summary>
    /// Whether or not journey event collection is enabled.
    /// </summary>
    /// <value>Whether or not journey event collection is enabled.</value>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }



    /// <summary>
    /// List of parameters to be excluded from the query string.
    /// </summary>
    /// <value>List of parameters to be excluded from the query string.</value>
    [JsonPropertyName("excludedQueryParameters")]
    public List<string> ExcludedQueryParameters { get; set; }



    /// <summary>
    /// Whether or not to keep the URL fragment.
    /// </summary>
    /// <value>Whether or not to keep the URL fragment.</value>
    [JsonPropertyName("shouldKeepUrlFragment")]
    public bool? ShouldKeepUrlFragment { get; set; }



    /// <summary>
    /// List of query parameters used for search (e.g. &#39;q&#39;).
    /// </summary>
    /// <value>List of query parameters used for search (e.g. &#39;q&#39;).</value>
    [JsonPropertyName("searchQueryParameters")]
    public List<string> SearchQueryParameters { get; set; }





    /// <summary>
    /// Tracks when and where a visitor clicks on a webpage.
    /// </summary>
    /// <value>Tracks when and where a visitor clicks on a webpage.</value>
    [JsonPropertyName("clickEvents")]
    public List<SelectorEventTrigger> ClickEvents { get; set; }



    /// <summary>
    /// Controls how the form submitted and form abandoned events are tracked after a visitor interacts with a form element.
    /// </summary>
    /// <value>Controls how the form submitted and form abandoned events are tracked after a visitor interacts with a form element.</value>
    [JsonPropertyName("formsTrackEvents")]
    public List<FormsTrackTrigger> FormsTrackEvents { get; set; }



    /// <summary>
    /// Tracks when and where a visitor becomes inactive on a webpage.
    /// </summary>
    /// <value>Tracks when and where a visitor becomes inactive on a webpage.</value>
    [JsonPropertyName("idleEvents")]
    public List<IdleEventTrigger> IdleEvents { get; set; }



    /// <summary>
    /// Tracks when elements become visible or hidden on screen.
    /// </summary>
    /// <value>Tracks when elements become visible or hidden on screen.</value>
    [JsonPropertyName("inViewportEvents")]
    public List<SelectorEventTrigger> InViewportEvents { get; set; }



    /// <summary>
    /// Tracks when a visitor scrolls to a specific percentage of a webpage.
    /// </summary>
    /// <value>Tracks when a visitor scrolls to a specific percentage of a webpage.</value>
    [JsonPropertyName("scrollDepthEvents")]
    public List<ScrollPercentageEventTrigger> ScrollDepthEvents { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneyEventsSettings {\n");

        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  ExcludedQueryParameters: ").Append(ExcludedQueryParameters).Append("\n");
        sb.Append("  ShouldKeepUrlFragment: ").Append(ShouldKeepUrlFragment).Append("\n");
        sb.Append("  SearchQueryParameters: ").Append(SearchQueryParameters).Append("\n");
        sb.Append("  PageviewConfig: ").Append(PageviewConfig).Append("\n");
        sb.Append("  ClickEvents: ").Append(ClickEvents).Append("\n");
        sb.Append("  FormsTrackEvents: ").Append(FormsTrackEvents).Append("\n");
        sb.Append("  IdleEvents: ").Append(IdleEvents).Append("\n");
        sb.Append("  InViewportEvents: ").Append(InViewportEvents).Append("\n");
        sb.Append("  ScrollDepthEvents: ").Append(ScrollDepthEvents).Append("\n");
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
        return Equals(obj as JourneyEventsSettings);
    }

    /// <summary>
    /// Returns true if JourneyEventsSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneyEventsSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneyEventsSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Enabled == other.Enabled ||
                Enabled != null &&
                Enabled.Equals(other.Enabled)
            ) &&
            (
                ExcludedQueryParameters == other.ExcludedQueryParameters ||
                ExcludedQueryParameters != null &&
                ExcludedQueryParameters.SequenceEqual(other.ExcludedQueryParameters)
            ) &&
            (
                ShouldKeepUrlFragment == other.ShouldKeepUrlFragment ||
                ShouldKeepUrlFragment != null &&
                ShouldKeepUrlFragment.Equals(other.ShouldKeepUrlFragment)
            ) &&
            (
                SearchQueryParameters == other.SearchQueryParameters ||
                SearchQueryParameters != null &&
                SearchQueryParameters.SequenceEqual(other.SearchQueryParameters)
            ) &&
            (
                PageviewConfig == other.PageviewConfig ||
                PageviewConfig != null &&
                PageviewConfig.Equals(other.PageviewConfig)
            ) &&
            (
                ClickEvents == other.ClickEvents ||
                ClickEvents != null &&
                ClickEvents.SequenceEqual(other.ClickEvents)
            ) &&
            (
                FormsTrackEvents == other.FormsTrackEvents ||
                FormsTrackEvents != null &&
                FormsTrackEvents.SequenceEqual(other.FormsTrackEvents)
            ) &&
            (
                IdleEvents == other.IdleEvents ||
                IdleEvents != null &&
                IdleEvents.SequenceEqual(other.IdleEvents)
            ) &&
            (
                InViewportEvents == other.InViewportEvents ||
                InViewportEvents != null &&
                InViewportEvents.SequenceEqual(other.InViewportEvents)
            ) &&
            (
                ScrollDepthEvents == other.ScrollDepthEvents ||
                ScrollDepthEvents != null &&
                ScrollDepthEvents.SequenceEqual(other.ScrollDepthEvents)
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
            if (Enabled != null)
            {
                hash = hash * 59 + Enabled.GetHashCode();
            }

            if (ExcludedQueryParameters != null)
            {
                hash = hash * 59 + ExcludedQueryParameters.GetHashCode();
            }

            if (ShouldKeepUrlFragment != null)
            {
                hash = hash * 59 + ShouldKeepUrlFragment.GetHashCode();
            }

            if (SearchQueryParameters != null)
            {
                hash = hash * 59 + SearchQueryParameters.GetHashCode();
            }

            if (PageviewConfig != null)
            {
                hash = hash * 59 + PageviewConfig.GetHashCode();
            }

            if (ClickEvents != null)
            {
                hash = hash * 59 + ClickEvents.GetHashCode();
            }

            if (FormsTrackEvents != null)
            {
                hash = hash * 59 + FormsTrackEvents.GetHashCode();
            }

            if (IdleEvents != null)
            {
                hash = hash * 59 + IdleEvents.GetHashCode();
            }

            if (InViewportEvents != null)
            {
                hash = hash * 59 + InViewportEvents.GetHashCode();
            }

            if (ScrollDepthEvents != null)
            {
                hash = hash * 59 + ScrollDepthEvents.GetHashCode();
            }

            return hash;
        }
    }
}
