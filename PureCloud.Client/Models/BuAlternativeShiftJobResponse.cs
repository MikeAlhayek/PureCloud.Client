using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuAlternativeShiftJobResponse
/// </summary>
[DataContract]
public partial class BuAlternativeShiftJobResponse : IEquatable<BuAlternativeShiftJobResponse>
{
    /// <summary>
    /// The status of the alternative shift job
    /// </summary>
    /// <value>The status of the alternative shift job</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Processing for "Processing"
        /// </summary>
        [EnumMember(Value = "Processing")]
        Processing,

        /// <summary>
        /// Enum Complete for "Complete"
        /// </summary>
        [EnumMember(Value = "Complete")]
        Complete,

        /// <summary>
        /// Enum Error for "Error"
        /// </summary>
        [EnumMember(Value = "Error")]
        Error
    }
    /// <summary>
    /// The type of job
    /// </summary>
    /// <value>The type of job</value>
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
        /// Enum Listoffers for "ListOffers"
        /// </summary>
        [EnumMember(Value = "ListOffers")]
        Listoffers,

        /// <summary>
        /// Enum Searchoffers for "SearchOffers"
        /// </summary>
        [EnumMember(Value = "SearchOffers")]
        Searchoffers,

        /// <summary>
        /// Enum Listusertrades for "ListUserTrades"
        /// </summary>
        [EnumMember(Value = "ListUserTrades")]
        Listusertrades,

        /// <summary>
        /// Enum Searchtrades for "SearchTrades"
        /// </summary>
        [EnumMember(Value = "SearchTrades")]
        Searchtrades,

        /// <summary>
        /// Enum Bulkupdatetrades for "BulkUpdateTrades"
        /// </summary>
        [EnumMember(Value = "BulkUpdateTrades")]
        Bulkupdatetrades
    }
    /// <summary>
    /// The status of the alternative shift job
    /// </summary>
    /// <value>The status of the alternative shift job</value>
    [DataMember(Name = "status", EmitDefaultValue = false)]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// The type of job
    /// </summary>
    /// <value>The type of job</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TypeEnum? Type { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="BuAlternativeShiftJobResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected BuAlternativeShiftJobResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="BuAlternativeShiftJobResponse" /> class.
    /// </summary>
    /// <param name="Status">The status of the alternative shift job (required).</param>
    /// <param name="Type">The type of job (required).</param>
    /// <param name="DownloadUrl">The URL where completed results are available, only set if status &#x3D;&#x3D; &#39;Complete&#39;.</param>
    /// <param name="Error">Any error information, only set if the status &#x3D;&#x3D; &#39;Error&#39;.</param>
    /// <param name="ViewOffersResults">Schema template for deserializing data returned from the downloadUrl. Use if type &#x3D;&#x3D; &#39;ListOffers&#39; or &#39;SearchOffers&#39;.</param>
    /// <param name="ViewTradesResults">Schema template for deserializing data returned from the downloadUrl. Use if type &#x3D;&#x3D; &#39;ListUserTrades&#39; or &#39;SearchTrades&#39;.</param>
    /// <param name="BulkUpdateTradesResults">Schema template for deserializing data returned from the downloadUrl. Use if type &#x3D;&#x3D; &#39;BulkUpdateTrades&#39;.</param>
    public BuAlternativeShiftJobResponse(StatusEnum? Status = null, TypeEnum? Type = null, string DownloadUrl = null, ErrorBody Error = null, AlternativeShiftOffersViewResponseTemplate ViewOffersResults = null, AlternativeShiftTradesViewResponseTemplate ViewTradesResults = null, AlternativeShiftBulkUpdateTradesResponseTemplate BulkUpdateTradesResults = null)
    {
        this.Status = Status;
        this.Type = Type;
        this.DownloadUrl = DownloadUrl;
        this.Error = Error;
        this.ViewOffersResults = ViewOffersResults;
        this.ViewTradesResults = ViewTradesResults;
        this.BulkUpdateTradesResults = BulkUpdateTradesResults;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }







    /// <summary>
    /// The URL where completed results are available, only set if status &#x3D;&#x3D; &#39;Complete&#39;
    /// </summary>
    /// <value>The URL where completed results are available, only set if status &#x3D;&#x3D; &#39;Complete&#39;</value>
    [DataMember(Name = "downloadUrl", EmitDefaultValue = false)]
    public string DownloadUrl { get; set; }



    /// <summary>
    /// Any error information, only set if the status &#x3D;&#x3D; &#39;Error&#39;
    /// </summary>
    /// <value>Any error information, only set if the status &#x3D;&#x3D; &#39;Error&#39;</value>
    [DataMember(Name = "error", EmitDefaultValue = false)]
    public ErrorBody Error { get; set; }



    /// <summary>
    /// Schema template for deserializing data returned from the downloadUrl. Use if type &#x3D;&#x3D; &#39;ListOffers&#39; or &#39;SearchOffers&#39;
    /// </summary>
    /// <value>Schema template for deserializing data returned from the downloadUrl. Use if type &#x3D;&#x3D; &#39;ListOffers&#39; or &#39;SearchOffers&#39;</value>
    [DataMember(Name = "viewOffersResults", EmitDefaultValue = false)]
    public AlternativeShiftOffersViewResponseTemplate ViewOffersResults { get; set; }



    /// <summary>
    /// Schema template for deserializing data returned from the downloadUrl. Use if type &#x3D;&#x3D; &#39;ListUserTrades&#39; or &#39;SearchTrades&#39;
    /// </summary>
    /// <value>Schema template for deserializing data returned from the downloadUrl. Use if type &#x3D;&#x3D; &#39;ListUserTrades&#39; or &#39;SearchTrades&#39;</value>
    [DataMember(Name = "viewTradesResults", EmitDefaultValue = false)]
    public AlternativeShiftTradesViewResponseTemplate ViewTradesResults { get; set; }



    /// <summary>
    /// Schema template for deserializing data returned from the downloadUrl. Use if type &#x3D;&#x3D; &#39;BulkUpdateTrades&#39;
    /// </summary>
    /// <value>Schema template for deserializing data returned from the downloadUrl. Use if type &#x3D;&#x3D; &#39;BulkUpdateTrades&#39;</value>
    [DataMember(Name = "bulkUpdateTradesResults", EmitDefaultValue = false)]
    public AlternativeShiftBulkUpdateTradesResponseTemplate BulkUpdateTradesResults { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuAlternativeShiftJobResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
        sb.Append("  Error: ").Append(Error).Append("\n");
        sb.Append("  ViewOffersResults: ").Append(ViewOffersResults).Append("\n");
        sb.Append("  ViewTradesResults: ").Append(ViewTradesResults).Append("\n");
        sb.Append("  BulkUpdateTradesResults: ").Append(BulkUpdateTradesResults).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as BuAlternativeShiftJobResponse);
    }

    /// <summary>
    /// Returns true if BuAlternativeShiftJobResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of BuAlternativeShiftJobResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuAlternativeShiftJobResponse other)
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
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                DownloadUrl == other.DownloadUrl ||
                DownloadUrl != null &&
                DownloadUrl.Equals(other.DownloadUrl)
            ) &&
            (
                Error == other.Error ||
                Error != null &&
                Error.Equals(other.Error)
            ) &&
            (
                ViewOffersResults == other.ViewOffersResults ||
                ViewOffersResults != null &&
                ViewOffersResults.Equals(other.ViewOffersResults)
            ) &&
            (
                ViewTradesResults == other.ViewTradesResults ||
                ViewTradesResults != null &&
                ViewTradesResults.Equals(other.ViewTradesResults)
            ) &&
            (
                BulkUpdateTradesResults == other.BulkUpdateTradesResults ||
                BulkUpdateTradesResults != null &&
                BulkUpdateTradesResults.Equals(other.BulkUpdateTradesResults)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (DownloadUrl != null)
            {
                hash = hash * 59 + DownloadUrl.GetHashCode();
            }

            if (Error != null)
            {
                hash = hash * 59 + Error.GetHashCode();
            }

            if (ViewOffersResults != null)
            {
                hash = hash * 59 + ViewOffersResults.GetHashCode();
            }

            if (ViewTradesResults != null)
            {
                hash = hash * 59 + ViewTradesResults.GetHashCode();
            }

            if (BulkUpdateTradesResults != null)
            {
                hash = hash * 59 + BulkUpdateTradesResults.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
