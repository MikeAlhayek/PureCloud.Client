using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// JourneyOutcomeEventsNotificationDevice
/// </summary>

public partial class JourneyOutcomeEventsNotificationDevice : IEquatable<JourneyOutcomeEventsNotificationDevice>
{
    /// <summary>
    /// Gets or Sets Category
    /// </summary>
    
    public enum CategoryEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Desktop for "desktop"
        /// </summary>
        [EnumMember(Value = "desktop")]
        Desktop,

        /// <summary>
        /// Enum Mobile for "mobile"
        /// </summary>
        [EnumMember(Value = "mobile")]
        Mobile,

        /// <summary>
        /// Enum Tablet for "tablet"
        /// </summary>
        [EnumMember(Value = "tablet")]
        Tablet,

        /// <summary>
        /// Enum Other for "other"
        /// </summary>
        [EnumMember(Value = "other")]
        Other
    }
    /// <summary>
    /// Gets or Sets Category
    /// </summary>
    [JsonPropertyName("category")]
    public CategoryEnum? Category { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyOutcomeEventsNotificationDevice" /> class.
    /// </summary>
    /// <param name="Type">Type.</param>
    /// <param name="IsMobile">IsMobile.</param>
    /// <param name="ScreenHeight">ScreenHeight.</param>
    /// <param name="ScreenWidth">ScreenWidth.</param>
    /// <param name="ScreenDensity">ScreenDensity.</param>
    /// <param name="Fingerprint">Fingerprint.</param>
    /// <param name="OsFamily">OsFamily.</param>
    /// <param name="OsVersion">OsVersion.</param>
    /// <param name="Category">Category.</param>
    /// <param name="Manufacturer">Manufacturer.</param>
    public JourneyOutcomeEventsNotificationDevice(string Type = null, bool? IsMobile = null, long? ScreenHeight = null, long? ScreenWidth = null, long? ScreenDensity = null, string Fingerprint = null, string OsFamily = null, string OsVersion = null, CategoryEnum? Category = null, string Manufacturer = null)
    {
        this.Type = Type;
        this.IsMobile = IsMobile;
        this.ScreenHeight = ScreenHeight;
        this.ScreenWidth = ScreenWidth;
        this.ScreenDensity = ScreenDensity;
        this.Fingerprint = Fingerprint;
        this.OsFamily = OsFamily;
        this.OsVersion = OsVersion;
        this.Category = Category;
        this.Manufacturer = Manufacturer;

    }



    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }



    /// <summary>
    /// Gets or Sets IsMobile
    /// </summary>
    [JsonPropertyName("isMobile")]
    public bool? IsMobile { get; set; }



    /// <summary>
    /// Gets or Sets ScreenHeight
    /// </summary>
    [JsonPropertyName("screenHeight")]
    public long? ScreenHeight { get; set; }



    /// <summary>
    /// Gets or Sets ScreenWidth
    /// </summary>
    [JsonPropertyName("screenWidth")]
    public long? ScreenWidth { get; set; }



    /// <summary>
    /// Gets or Sets ScreenDensity
    /// </summary>
    [JsonPropertyName("screenDensity")]
    public long? ScreenDensity { get; set; }



    /// <summary>
    /// Gets or Sets Fingerprint
    /// </summary>
    [JsonPropertyName("fingerprint")]
    public string Fingerprint { get; set; }



    /// <summary>
    /// Gets or Sets OsFamily
    /// </summary>
    [JsonPropertyName("osFamily")]
    public string OsFamily { get; set; }



    /// <summary>
    /// Gets or Sets OsVersion
    /// </summary>
    [JsonPropertyName("osVersion")]
    public string OsVersion { get; set; }





    /// <summary>
    /// Gets or Sets Manufacturer
    /// </summary>
    [JsonPropertyName("manufacturer")]
    public string Manufacturer { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneyOutcomeEventsNotificationDevice {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  IsMobile: ").Append(IsMobile).Append("\n");
        sb.Append("  ScreenHeight: ").Append(ScreenHeight).Append("\n");
        sb.Append("  ScreenWidth: ").Append(ScreenWidth).Append("\n");
        sb.Append("  ScreenDensity: ").Append(ScreenDensity).Append("\n");
        sb.Append("  Fingerprint: ").Append(Fingerprint).Append("\n");
        sb.Append("  OsFamily: ").Append(OsFamily).Append("\n");
        sb.Append("  OsVersion: ").Append(OsVersion).Append("\n");
        sb.Append("  Category: ").Append(Category).Append("\n");
        sb.Append("  Manufacturer: ").Append(Manufacturer).Append("\n");
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
        return Equals(obj as JourneyOutcomeEventsNotificationDevice);
    }

    /// <summary>
    /// Returns true if JourneyOutcomeEventsNotificationDevice instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneyOutcomeEventsNotificationDevice to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneyOutcomeEventsNotificationDevice other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                IsMobile == other.IsMobile ||
                IsMobile != null &&
                IsMobile.Equals(other.IsMobile)
            ) &&
            (
                ScreenHeight == other.ScreenHeight ||
                ScreenHeight != null &&
                ScreenHeight.Equals(other.ScreenHeight)
            ) &&
            (
                ScreenWidth == other.ScreenWidth ||
                ScreenWidth != null &&
                ScreenWidth.Equals(other.ScreenWidth)
            ) &&
            (
                ScreenDensity == other.ScreenDensity ||
                ScreenDensity != null &&
                ScreenDensity.Equals(other.ScreenDensity)
            ) &&
            (
                Fingerprint == other.Fingerprint ||
                Fingerprint != null &&
                Fingerprint.Equals(other.Fingerprint)
            ) &&
            (
                OsFamily == other.OsFamily ||
                OsFamily != null &&
                OsFamily.Equals(other.OsFamily)
            ) &&
            (
                OsVersion == other.OsVersion ||
                OsVersion != null &&
                OsVersion.Equals(other.OsVersion)
            ) &&
            (
                Category == other.Category ||
                Category != null &&
                Category.Equals(other.Category)
            ) &&
            (
                Manufacturer == other.Manufacturer ||
                Manufacturer != null &&
                Manufacturer.Equals(other.Manufacturer)
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
            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (IsMobile != null)
            {
                hash = hash * 59 + IsMobile.GetHashCode();
            }

            if (ScreenHeight != null)
            {
                hash = hash * 59 + ScreenHeight.GetHashCode();
            }

            if (ScreenWidth != null)
            {
                hash = hash * 59 + ScreenWidth.GetHashCode();
            }

            if (ScreenDensity != null)
            {
                hash = hash * 59 + ScreenDensity.GetHashCode();
            }

            if (Fingerprint != null)
            {
                hash = hash * 59 + Fingerprint.GetHashCode();
            }

            if (OsFamily != null)
            {
                hash = hash * 59 + OsFamily.GetHashCode();
            }

            if (OsVersion != null)
            {
                hash = hash * 59 + OsVersion.GetHashCode();
            }

            if (Category != null)
            {
                hash = hash * 59 + Category.GetHashCode();
            }

            if (Manufacturer != null)
            {
                hash = hash * 59 + Manufacturer.GetHashCode();
            }

            return hash;
        }
    }
}
