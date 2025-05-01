using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WhatsAppConfig
/// </summary>
[DataContract]
public partial class WhatsAppConfig : IEquatable<WhatsAppConfig>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="WhatsAppConfig" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WhatsAppConfig() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WhatsAppConfig" /> class.
    /// </summary>
    /// <param name="WhatsAppColumns">The contact list columns specifying the WhatsApp address(es) of the contact. (required).</param>
    /// <param name="WhatsAppIntegration">The WhatsApp integration used to send message to the contact. (required).</param>
    /// <param name="ContentTemplate">The content template used to formulate the WhatsApp message to send to the contact. (required).</param>
    public WhatsAppConfig(List<string> WhatsAppColumns = null, AddressableEntityRef WhatsAppIntegration = null, DomainEntityRef ContentTemplate = null)
    {
        this.WhatsAppColumns = WhatsAppColumns;
        this.WhatsAppIntegration = WhatsAppIntegration;
        this.ContentTemplate = ContentTemplate;

    }



    /// <summary>
    /// The contact list columns specifying the WhatsApp address(es) of the contact.
    /// </summary>
    /// <value>The contact list columns specifying the WhatsApp address(es) of the contact.</value>
    [DataMember(Name = "whatsAppColumns", EmitDefaultValue = false)]
    public List<string> WhatsAppColumns { get; set; }



    /// <summary>
    /// The WhatsApp integration used to send message to the contact.
    /// </summary>
    /// <value>The WhatsApp integration used to send message to the contact.</value>
    [DataMember(Name = "whatsAppIntegration", EmitDefaultValue = false)]
    public AddressableEntityRef WhatsAppIntegration { get; set; }



    /// <summary>
    /// The content template used to formulate the WhatsApp message to send to the contact.
    /// </summary>
    /// <value>The content template used to formulate the WhatsApp message to send to the contact.</value>
    [DataMember(Name = "contentTemplate", EmitDefaultValue = false)]
    public DomainEntityRef ContentTemplate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WhatsAppConfig {\n");

        sb.Append("  WhatsAppColumns: ").Append(WhatsAppColumns).Append("\n");
        sb.Append("  WhatsAppIntegration: ").Append(WhatsAppIntegration).Append("\n");
        sb.Append("  ContentTemplate: ").Append(ContentTemplate).Append("\n");
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
        return Equals(obj as WhatsAppConfig);
    }

    /// <summary>
    /// Returns true if WhatsAppConfig instances are equal
    /// </summary>
    /// <param name="other">Instance of WhatsAppConfig to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WhatsAppConfig other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                WhatsAppColumns == other.WhatsAppColumns ||
                WhatsAppColumns != null &&
                WhatsAppColumns.SequenceEqual(other.WhatsAppColumns)
            ) &&
            (
                WhatsAppIntegration == other.WhatsAppIntegration ||
                WhatsAppIntegration != null &&
                WhatsAppIntegration.Equals(other.WhatsAppIntegration)
            ) &&
            (
                ContentTemplate == other.ContentTemplate ||
                ContentTemplate != null &&
                ContentTemplate.Equals(other.ContentTemplate)
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
            if (WhatsAppColumns != null)
            {
                hash = hash * 59 + WhatsAppColumns.GetHashCode();
            }

            if (WhatsAppIntegration != null)
            {
                hash = hash * 59 + WhatsAppIntegration.GetHashCode();
            }

            if (ContentTemplate != null)
            {
                hash = hash * 59 + ContentTemplate.GetHashCode();
            }

            return hash;
        }
    }
}
