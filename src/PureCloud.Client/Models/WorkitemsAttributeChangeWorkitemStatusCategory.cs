using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WorkitemsAttributeChangeWorkitemStatusCategory
{
    /// <summary>
    /// New property value
    /// </summary>
    /// <value>New property value</value>
    public WorkitemsAttributeChangeWorkitemStatusCategoryNewValueEnum? NewValue { get; set; }

    /// <summary>
    /// Old property value
    /// </summary>
    /// <value>Old property value</value>
    public WorkitemsAttributeChangeWorkitemStatusCategoryOldValueEnum? OldValue { get; set; }
}
