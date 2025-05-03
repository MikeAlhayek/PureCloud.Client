using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Details about a Web Deployment
/// </summary>

public partial class ExpandableWebDeployment : IEquatable<ExpandableWebDeployment>
{
    /// <summary>
    /// The current status of the deployment
    /// </summary>
    /// <value>The current status of the deployment</value>
    
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
        /// Enum Pending for "Pending"
        /// </summary>
        [EnumMember(Value = "Pending")]
        Pending,

        /// <summary>
        /// Enum Active for "Active"
        /// </summary>
        [EnumMember(Value = "Active")]
        Active,

        /// <summary>
        /// Enum Inactive for "Inactive"
        /// </summary>
        [EnumMember(Value = "Inactive")]
        Inactive,

        /// <summary>
        /// Enum Error for "Error"
        /// </summary>
        [EnumMember(Value = "Error")]
        Error,

        /// <summary>
        /// Enum Deleting for "Deleting"
        /// </summary>
        [EnumMember(Value = "Deleting")]
        Deleting
    }
    /// <summary>
    /// The current status of the deployment
    /// </summary>
    /// <value>The current status of the deployment</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ExpandableWebDeployment" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ExpandableWebDeployment() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ExpandableWebDeployment" /> class.
    /// </summary>
    /// <param name="Name">The deployment name (required).</param>
    /// <param name="Description">The description of the config.</param>
    /// <param name="AllowAllDomains">Property indicates whether all domains are allowed or not. allowedDomains must be empty when this is set as true..</param>
    /// <param name="AllowedDomains">The list of domains that are approved to use this deployment; the list will be added to CORS headers for ease of web use..</param>
    /// <param name="SupportedContent">The supported content profile for a deployment.</param>
    /// <param name="Flow">A reference to the inboundshortmessage flow used by this deployment.</param>
    /// <param name="Status">The current status of the deployment.</param>
    /// <param name="Configuration">The config version this deployment uses (required).</param>
    public ExpandableWebDeployment(string Name = null, string Description = null, bool? AllowAllDomains = null, List<string> AllowedDomains = null, SupportedContentReference SupportedContent = null, WebDeploymentFlowEntityRef Flow = null, StatusEnum? Status = null, WebDeploymentConfigurationVersionResponse Configuration = null)
    {
        this.Name = Name;
        this.Description = Description;
        this.AllowAllDomains = AllowAllDomains;
        this.AllowedDomains = AllowedDomains;
        this.SupportedContent = SupportedContent;
        this.Flow = Flow;
        this.Status = Status;
        this.Configuration = Configuration;

    }



    /// <summary>
    /// The deployment ID
    /// </summary>
    /// <value>The deployment ID</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// The deployment name
    /// </summary>
    /// <value>The deployment name</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The description of the config
    /// </summary>
    /// <value>The description of the config</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// Property indicates whether all domains are allowed or not. allowedDomains must be empty when this is set as true.
    /// </summary>
    /// <value>Property indicates whether all domains are allowed or not. allowedDomains must be empty when this is set as true.</value>
    [JsonPropertyName("allowAllDomains")]
    public bool? AllowAllDomains { get; set; }



    /// <summary>
    /// The list of domains that are approved to use this deployment; the list will be added to CORS headers for ease of web use.
    /// </summary>
    /// <value>The list of domains that are approved to use this deployment; the list will be added to CORS headers for ease of web use.</value>
    [JsonPropertyName("allowedDomains")]
    public List<string> AllowedDomains { get; set; }



    /// <summary>
    /// The supported content profile for a deployment
    /// </summary>
    /// <value>The supported content profile for a deployment</value>
    [JsonPropertyName("supportedContent")]
    public SupportedContentReference SupportedContent { get; set; }



    /// <summary>
    /// Javascript snippet used to load the config
    /// </summary>
    /// <value>Javascript snippet used to load the config</value>
    [JsonPropertyName("snippet")]
    public string Snippet { get; private set; }



    /// <summary>
    /// The date the deployment was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the deployment was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; private set; }



    /// <summary>
    /// The date the deployment was most recently modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the deployment was most recently modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; private set; }



    /// <summary>
    /// A reference to the user who most recently modified the deployment
    /// </summary>
    /// <value>A reference to the user who most recently modified the deployment</value>
    [JsonPropertyName("lastModifiedUser")]
    public AddressableEntityRef LastModifiedUser { get; private set; }



    /// <summary>
    /// A reference to the inboundshortmessage flow used by this deployment
    /// </summary>
    /// <value>A reference to the inboundshortmessage flow used by this deployment</value>
    [JsonPropertyName("flow")]
    public WebDeploymentFlowEntityRef Flow { get; set; }





    /// <summary>
    /// The config version this deployment uses
    /// </summary>
    /// <value>The config version this deployment uses</value>
    [JsonPropertyName("configuration")]
    public WebDeploymentConfigurationVersionResponse Configuration { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ExpandableWebDeployment {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  AllowAllDomains: ").Append(AllowAllDomains).Append("\n");
        sb.Append("  AllowedDomains: ").Append(AllowedDomains).Append("\n");
        sb.Append("  SupportedContent: ").Append(SupportedContent).Append("\n");
        sb.Append("  Snippet: ").Append(Snippet).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  LastModifiedUser: ").Append(LastModifiedUser).Append("\n");
        sb.Append("  Flow: ").Append(Flow).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Configuration: ").Append(Configuration).Append("\n");
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
        return Equals(obj as ExpandableWebDeployment);
    }

    /// <summary>
    /// Returns true if ExpandableWebDeployment instances are equal
    /// </summary>
    /// <param name="other">Instance of ExpandableWebDeployment to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ExpandableWebDeployment other)
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
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                AllowAllDomains == other.AllowAllDomains ||
                AllowAllDomains != null &&
                AllowAllDomains.Equals(other.AllowAllDomains)
            ) &&
            (
                AllowedDomains == other.AllowedDomains ||
                AllowedDomains != null &&
                AllowedDomains.SequenceEqual(other.AllowedDomains)
            ) &&
            (
                SupportedContent == other.SupportedContent ||
                SupportedContent != null &&
                SupportedContent.Equals(other.SupportedContent)
            ) &&
            (
                Snippet == other.Snippet ||
                Snippet != null &&
                Snippet.Equals(other.Snippet)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                LastModifiedUser == other.LastModifiedUser ||
                LastModifiedUser != null &&
                LastModifiedUser.Equals(other.LastModifiedUser)
            ) &&
            (
                Flow == other.Flow ||
                Flow != null &&
                Flow.Equals(other.Flow)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                Configuration == other.Configuration ||
                Configuration != null &&
                Configuration.Equals(other.Configuration)
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

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (AllowAllDomains != null)
            {
                hash = hash * 59 + AllowAllDomains.GetHashCode();
            }

            if (AllowedDomains != null)
            {
                hash = hash * 59 + AllowedDomains.GetHashCode();
            }

            if (SupportedContent != null)
            {
                hash = hash * 59 + SupportedContent.GetHashCode();
            }

            if (Snippet != null)
            {
                hash = hash * 59 + Snippet.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (LastModifiedUser != null)
            {
                hash = hash * 59 + LastModifiedUser.GetHashCode();
            }

            if (Flow != null)
            {
                hash = hash * 59 + Flow.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (Configuration != null)
            {
                hash = hash * 59 + Configuration.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
