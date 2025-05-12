using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ExternalContactsUnresolvedContactChangedTopicContact
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public ExternalContactsUnresolvedContactChangedTopicContactTypeEnum? Type { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Division
    /// </summary>
    public ExternalContactsUnresolvedContactChangedTopicDivision Division { get; set; }

    /// <summary>
    /// Gets or Sets ExternalOrganization
    /// </summary>
    public ExternalContactsUnresolvedContactChangedTopicExternalOrganization ExternalOrganization { get; set; }

    /// <summary>
    /// Gets or Sets FirstName
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// Gets or Sets MiddleName
    /// </summary>
    public string MiddleName { get; set; }

    /// <summary>
    /// Gets or Sets LastName
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// Gets or Sets Salutation
    /// </summary>
    public string Salutation { get; set; }

    /// <summary>
    /// Gets or Sets Title
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Gets or Sets WorkPhone
    /// </summary>
    public ExternalContactsUnresolvedContactChangedTopicPhoneNumber WorkPhone { get; set; }

    /// <summary>
    /// Gets or Sets CellPhone
    /// </summary>
    public ExternalContactsUnresolvedContactChangedTopicPhoneNumber CellPhone { get; set; }

    /// <summary>
    /// Gets or Sets HomePhone
    /// </summary>
    public ExternalContactsUnresolvedContactChangedTopicPhoneNumber HomePhone { get; set; }

    /// <summary>
    /// Gets or Sets OtherPhone
    /// </summary>
    public ExternalContactsUnresolvedContactChangedTopicPhoneNumber OtherPhone { get; set; }

    /// <summary>
    /// Gets or Sets WorkEmail
    /// </summary>
    public string WorkEmail { get; set; }

    /// <summary>
    /// Gets or Sets PersonalEmail
    /// </summary>
    public string PersonalEmail { get; set; }

    /// <summary>
    /// Gets or Sets OtherEmail
    /// </summary>
    public string OtherEmail { get; set; }

    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    public ExternalContactsUnresolvedContactChangedTopicContactAddress Address { get; set; }

    /// <summary>
    /// Gets or Sets SurveyOptOut
    /// </summary>
    public bool? SurveyOptOut { get; set; }

    /// <summary>
    /// Gets or Sets ExternalSystemUrl
    /// </summary>
    public string ExternalSystemUrl { get; set; }

    /// <summary>
    /// Gets or Sets TwitterId
    /// </summary>
    public ExternalContactsUnresolvedContactChangedTopicTwitterId TwitterId { get; set; }

    /// <summary>
    /// Gets or Sets LineId
    /// </summary>
    public ExternalContactsUnresolvedContactChangedTopicLineId LineId { get; set; }

    /// <summary>
    /// Gets or Sets WhatsAppId
    /// </summary>
    public ExternalContactsUnresolvedContactChangedTopicWhatsAppId WhatsAppId { get; set; }

    /// <summary>
    /// Gets or Sets FacebookId
    /// </summary>
    public ExternalContactsUnresolvedContactChangedTopicFacebookId FacebookId { get; set; }

    /// <summary>
    /// Gets or Sets InstagramId
    /// </summary>
    public ExternalContactsUnresolvedContactChangedTopicInstagramId InstagramId { get; set; }

    /// <summary>
    /// Gets or Sets ExternalIds
    /// </summary>
    public IEnumerable<ExternalContactsUnresolvedContactChangedTopicExternalId> ExternalIds { get; set; }

    /// <summary>
    /// Gets or Sets CanonicalContactId
    /// </summary>
    public string CanonicalContactId { get; set; }

    /// <summary>
    /// Gets or Sets Schema
    /// </summary>
    public ExternalContactsUnresolvedContactChangedTopicDataSchema Schema { get; set; }

    /// <summary>
    /// Gets or Sets CustomFields
    /// </summary>
    public Dictionary<string, object> CustomFields { get; set; }

    /// <summary>
    /// Gets or Sets MergeSet
    /// </summary>
    public IEnumerable<string> MergeSet { get; set; }

    /// <summary>
    /// Gets or Sets MergedFrom
    /// </summary>
    public IEnumerable<string> MergedFrom { get; set; }

    /// <summary>
    /// Gets or Sets MergedTo
    /// </summary>
    public string MergedTo { get; set; }

    /// <summary>
    /// Gets or Sets MergeOperation
    /// </summary>
    public ExternalContactsUnresolvedContactChangedTopicMergeOperation MergeOperation { get; set; }

    /// <summary>
    /// Gets or Sets CreateDate
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Gets or Sets ModifyDate
    /// </summary>
    public DateTime? ModifyDate { get; set; }
}
