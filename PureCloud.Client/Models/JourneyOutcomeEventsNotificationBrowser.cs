using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// JourneyOutcomeEventsNotificationBrowser
/// </summary>
[DataContract]
public partial class JourneyOutcomeEventsNotificationBrowser : IEquatable<JourneyOutcomeEventsNotificationBrowser>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyOutcomeEventsNotificationBrowser" /> class.
    /// </summary>
    /// <param name="Family">Family.</param>
    /// <param name="Version">Version.</param>
    /// <param name="Lang">Lang.</param>
    /// <param name="Fingerprint">Fingerprint.</param>
    /// <param name="ViewHeight">ViewHeight.</param>
    /// <param name="ViewWidth">ViewWidth.</param>
    /// <param name="FeaturesFlash">FeaturesFlash.</param>
    /// <param name="FeaturesJava">FeaturesJava.</param>
    /// <param name="FeaturesPdf">FeaturesPdf.</param>
    /// <param name="FeaturesWebrtc">FeaturesWebrtc.</param>
    public JourneyOutcomeEventsNotificationBrowser(string Family = null, string Version = null, string Lang = null, string Fingerprint = null, long? ViewHeight = null, long? ViewWidth = null, bool? FeaturesFlash = null, bool? FeaturesJava = null, bool? FeaturesPdf = null, bool? FeaturesWebrtc = null)
    {
        this.Family = Family;
        this.Version = Version;
        this.Lang = Lang;
        this.Fingerprint = Fingerprint;
        this.ViewHeight = ViewHeight;
        this.ViewWidth = ViewWidth;
        this.FeaturesFlash = FeaturesFlash;
        this.FeaturesJava = FeaturesJava;
        this.FeaturesPdf = FeaturesPdf;
        this.FeaturesWebrtc = FeaturesWebrtc;

    }



    /// <summary>
    /// Gets or Sets Family
    /// </summary>
    [DataMember(Name = "family", EmitDefaultValue = false)]
    public string Family { get; set; }



    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    [DataMember(Name = "version", EmitDefaultValue = false)]
    public string Version { get; set; }



    /// <summary>
    /// Gets or Sets Lang
    /// </summary>
    [DataMember(Name = "lang", EmitDefaultValue = false)]
    public string Lang { get; set; }



    /// <summary>
    /// Gets or Sets Fingerprint
    /// </summary>
    [DataMember(Name = "fingerprint", EmitDefaultValue = false)]
    public string Fingerprint { get; set; }



    /// <summary>
    /// Gets or Sets ViewHeight
    /// </summary>
    [DataMember(Name = "viewHeight", EmitDefaultValue = false)]
    public long? ViewHeight { get; set; }



    /// <summary>
    /// Gets or Sets ViewWidth
    /// </summary>
    [DataMember(Name = "viewWidth", EmitDefaultValue = false)]
    public long? ViewWidth { get; set; }



    /// <summary>
    /// Gets or Sets FeaturesFlash
    /// </summary>
    [DataMember(Name = "featuresFlash", EmitDefaultValue = false)]
    public bool? FeaturesFlash { get; set; }



    /// <summary>
    /// Gets or Sets FeaturesJava
    /// </summary>
    [DataMember(Name = "featuresJava", EmitDefaultValue = false)]
    public bool? FeaturesJava { get; set; }



    /// <summary>
    /// Gets or Sets FeaturesPdf
    /// </summary>
    [DataMember(Name = "featuresPdf", EmitDefaultValue = false)]
    public bool? FeaturesPdf { get; set; }



    /// <summary>
    /// Gets or Sets FeaturesWebrtc
    /// </summary>
    [DataMember(Name = "featuresWebrtc", EmitDefaultValue = false)]
    public bool? FeaturesWebrtc { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneyOutcomeEventsNotificationBrowser {\n");

        sb.Append("  Family: ").Append(Family).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  Lang: ").Append(Lang).Append("\n");
        sb.Append("  Fingerprint: ").Append(Fingerprint).Append("\n");
        sb.Append("  ViewHeight: ").Append(ViewHeight).Append("\n");
        sb.Append("  ViewWidth: ").Append(ViewWidth).Append("\n");
        sb.Append("  FeaturesFlash: ").Append(FeaturesFlash).Append("\n");
        sb.Append("  FeaturesJava: ").Append(FeaturesJava).Append("\n");
        sb.Append("  FeaturesPdf: ").Append(FeaturesPdf).Append("\n");
        sb.Append("  FeaturesWebrtc: ").Append(FeaturesWebrtc).Append("\n");
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
        return Equals(obj as JourneyOutcomeEventsNotificationBrowser);
    }

    /// <summary>
    /// Returns true if JourneyOutcomeEventsNotificationBrowser instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneyOutcomeEventsNotificationBrowser to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneyOutcomeEventsNotificationBrowser other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Family == other.Family ||
                Family != null &&
                Family.Equals(other.Family)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                Lang == other.Lang ||
                Lang != null &&
                Lang.Equals(other.Lang)
            ) &&
            (
                Fingerprint == other.Fingerprint ||
                Fingerprint != null &&
                Fingerprint.Equals(other.Fingerprint)
            ) &&
            (
                ViewHeight == other.ViewHeight ||
                ViewHeight != null &&
                ViewHeight.Equals(other.ViewHeight)
            ) &&
            (
                ViewWidth == other.ViewWidth ||
                ViewWidth != null &&
                ViewWidth.Equals(other.ViewWidth)
            ) &&
            (
                FeaturesFlash == other.FeaturesFlash ||
                FeaturesFlash != null &&
                FeaturesFlash.Equals(other.FeaturesFlash)
            ) &&
            (
                FeaturesJava == other.FeaturesJava ||
                FeaturesJava != null &&
                FeaturesJava.Equals(other.FeaturesJava)
            ) &&
            (
                FeaturesPdf == other.FeaturesPdf ||
                FeaturesPdf != null &&
                FeaturesPdf.Equals(other.FeaturesPdf)
            ) &&
            (
                FeaturesWebrtc == other.FeaturesWebrtc ||
                FeaturesWebrtc != null &&
                FeaturesWebrtc.Equals(other.FeaturesWebrtc)
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
            if (Family != null)
            {
                hash = hash * 59 + Family.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (Lang != null)
            {
                hash = hash * 59 + Lang.GetHashCode();
            }

            if (Fingerprint != null)
            {
                hash = hash * 59 + Fingerprint.GetHashCode();
            }

            if (ViewHeight != null)
            {
                hash = hash * 59 + ViewHeight.GetHashCode();
            }

            if (ViewWidth != null)
            {
                hash = hash * 59 + ViewWidth.GetHashCode();
            }

            if (FeaturesFlash != null)
            {
                hash = hash * 59 + FeaturesFlash.GetHashCode();
            }

            if (FeaturesJava != null)
            {
                hash = hash * 59 + FeaturesJava.GetHashCode();
            }

            if (FeaturesPdf != null)
            {
                hash = hash * 59 + FeaturesPdf.GetHashCode();
            }

            if (FeaturesWebrtc != null)
            {
                hash = hash * 59 + FeaturesWebrtc.GetHashCode();
            }

            return hash;
        }
    }
}
