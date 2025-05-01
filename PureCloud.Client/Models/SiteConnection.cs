using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SiteConnection
/// </summary>
[DataContract]
public partial class SiteConnection : IEquatable<SiteConnection>
{
    /// <summary>
    /// Connection method from site to site (Direct, Indirect, CloudProxy
    /// </summary>
    /// <value>Connection method from site to site (Direct, Indirect, CloudProxy</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Direct for "Direct"
        /// </summary>
        [EnumMember(Value = "Direct")]
        Direct,

        /// <summary>
        /// Enum Indirect for "Indirect"
        /// </summary>
        [EnumMember(Value = "Indirect")]
        Indirect,

        /// <summary>
        /// Enum Cloudproxy for "CloudProxy"
        /// </summary>
        [EnumMember(Value = "CloudProxy")]
        Cloudproxy
    }
    /// <summary>
    /// Media model for the current site.
    /// </summary>
    /// <value>Media model for the current site.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MediaModelEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Premises for "Premises"
        /// </summary>
        [EnumMember(Value = "Premises")]
        Premises,

        /// <summary>
        /// Enum Cloud for "Cloud"
        /// </summary>
        [EnumMember(Value = "Cloud")]
        Cloud
    }
    /// <summary>
    /// Connection method from site to site (Direct, Indirect, CloudProxy
    /// </summary>
    /// <value>Connection method from site to site (Direct, Indirect, CloudProxy</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Media model for the current site.
    /// </summary>
    /// <value>Media model for the current site.</value>
    [DataMember(Name = "mediaModel", EmitDefaultValue = false)]
    public MediaModelEnum? MediaModel { get; private set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="SiteConnection" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Name">Name.</param>
    /// <param name="SelfUri">SelfUri.</param>
    /// <param name="Managed">Managed.</param>
    /// <param name="Type">Connection method from site to site (Direct, Indirect, CloudProxy.</param>
    /// <param name="Enabled">Indicates if the current site is linked.</param>
    public SiteConnection(string Id = null, string Name = null, string SelfUri = null, bool? Managed = null, TypeEnum? Type = null, bool? Enabled = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.SelfUri = SelfUri;
        this.Managed = Managed;
        this.Type = Type;
        this.Enabled = Enabled;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets SelfUri
    /// </summary>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; set; }



    /// <summary>
    /// Gets or Sets Managed
    /// </summary>
    [DataMember(Name = "managed", EmitDefaultValue = false)]
    public bool? Managed { get; set; }





    /// <summary>
    /// Indicates if the current site is linked
    /// </summary>
    /// <value>Indicates if the current site is linked</value>
    [DataMember(Name = "enabled", EmitDefaultValue = false)]
    public bool? Enabled { get; set; }





    /// <summary>
    /// All of the edges to which the site connects
    /// </summary>
    /// <value>All of the edges to which the site connects</value>
    [DataMember(Name = "edgeList", EmitDefaultValue = false)]
    public List<ConnectedEdge> EdgeList { get; private set; }



    /// <summary>
    /// The core site
    /// </summary>
    /// <value>The core site</value>
    [DataMember(Name = "coreSite", EmitDefaultValue = false)]
    public bool? CoreSite { get; private set; }



    /// <summary>
    /// List of site ids names and selfUris for the primary core sites
    /// </summary>
    /// <value>List of site ids names and selfUris for the primary core sites</value>
    [DataMember(Name = "primaryCoreSites", EmitDefaultValue = false)]
    public List<DomainEntityRef> PrimaryCoreSites { get; private set; }



    /// <summary>
    /// List of site ids names and selfUris for the secondary core sites
    /// </summary>
    /// <value>List of site ids names and selfUris for the secondary core sites</value>
    [DataMember(Name = "secondaryCoreSites", EmitDefaultValue = false)]
    public List<DomainEntityRef> SecondaryCoreSites { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SiteConnection {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("  Managed: ").Append(Managed).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  MediaModel: ").Append(MediaModel).Append("\n");
        sb.Append("  EdgeList: ").Append(EdgeList).Append("\n");
        sb.Append("  CoreSite: ").Append(CoreSite).Append("\n");
        sb.Append("  PrimaryCoreSites: ").Append(PrimaryCoreSites).Append("\n");
        sb.Append("  SecondaryCoreSites: ").Append(SecondaryCoreSites).Append("\n");
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
        return Equals(obj as SiteConnection);
    }

    /// <summary>
    /// Returns true if SiteConnection instances are equal
    /// </summary>
    /// <param name="other">Instance of SiteConnection to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SiteConnection other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
            ) &&
            (
                Managed == other.Managed ||
                Managed != null &&
                Managed.Equals(other.Managed)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Enabled == other.Enabled ||
                Enabled != null &&
                Enabled.Equals(other.Enabled)
            ) &&
            (
                MediaModel == other.MediaModel ||
                MediaModel != null &&
                MediaModel.Equals(other.MediaModel)
            ) &&
            (
                EdgeList == other.EdgeList ||
                EdgeList != null &&
                EdgeList.SequenceEqual(other.EdgeList)
            ) &&
            (
                CoreSite == other.CoreSite ||
                CoreSite != null &&
                CoreSite.Equals(other.CoreSite)
            ) &&
            (
                PrimaryCoreSites == other.PrimaryCoreSites ||
                PrimaryCoreSites != null &&
                PrimaryCoreSites.SequenceEqual(other.PrimaryCoreSites)
            ) &&
            (
                SecondaryCoreSites == other.SecondaryCoreSites ||
                SecondaryCoreSites != null &&
                SecondaryCoreSites.SequenceEqual(other.SecondaryCoreSites)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            if (Managed != null)
            {
                hash = hash * 59 + Managed.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Enabled != null)
            {
                hash = hash * 59 + Enabled.GetHashCode();
            }

            if (MediaModel != null)
            {
                hash = hash * 59 + MediaModel.GetHashCode();
            }

            if (EdgeList != null)
            {
                hash = hash * 59 + EdgeList.GetHashCode();
            }

            if (CoreSite != null)
            {
                hash = hash * 59 + CoreSite.GetHashCode();
            }

            if (PrimaryCoreSites != null)
            {
                hash = hash * 59 + PrimaryCoreSites.GetHashCode();
            }

            if (SecondaryCoreSites != null)
            {
                hash = hash * 59 + SecondaryCoreSites.GetHashCode();
            }

            return hash;
        }
    }
}
