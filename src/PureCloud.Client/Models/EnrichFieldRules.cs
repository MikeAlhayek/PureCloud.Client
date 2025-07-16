using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class EnrichFieldRules
{
    /// <summary>
    /// Default behavior for combining data from the submitted request with any entity found in the database. The default behavior if unspecified is `PreferProvided`, meaning any non-null fields in the submitted request will override data in the database, but all null fields will remain unchanged. Omitting a field in the request payload means that it will be treated as null.
    /// </summary>
    /// <value>Default behavior for combining data from the submitted request with any entity found in the database. The default behavior if unspecified is `PreferProvided`, meaning any non-null fields in the submitted request will override data in the database, but all null fields will remain unchanged. Omitting a field in the request payload means that it will be treated as null.</value>
    public EnrichFieldRulesDefaultActionEnum? DefaultAction { get; set; }

    /// <summary>
    /// Default behavior for combining items in array field from the submitted request with any array entity found in the database. The default behavior if unspecified is `fill`, meaning the field value will always be the partial concatenation of both the array in the Database and the array in the contact body, up to the size limit of the array
    /// </summary>
    /// <value>Default behavior for combining items in array field from the submitted request with any array entity found in the database. The default behavior if unspecified is `fill`, meaning the field value will always be the partial concatenation of both the array in the Database and the array in the contact body, up to the size limit of the array</value>
    public EnrichFieldRulesDefaultArrayActionEnum? DefaultArrayAction { get; set; }

    /// <summary>
    /// Field-specific behaviors for how to combine data from different sources. For example, you can set a &#x60;defaultAction&#x60; of &#x60;PreferProvided&#x60;, but use different behaviors such as &#x60;AlwaysUseProvided&#x60; or &#x60;PreferExisting&#x60; for specific fields.
    /// </summary>
    /// <value>Field-specific behaviors for how to combine data from different sources. For example, you can set a &#x60;defaultAction&#x60; of &#x60;PreferProvided&#x60;, but use different behaviors such as &#x60;AlwaysUseProvided&#x60; or &#x60;PreferExisting&#x60; for specific fields.</value>
    public IEnumerable<EnrichFieldRule> Rules { get; set; }
}
