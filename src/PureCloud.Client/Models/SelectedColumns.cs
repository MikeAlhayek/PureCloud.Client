using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class SelectedColumns
{
    /// <summary>
    /// Indicates the order/position of the selected column
    /// </summary>
    public int? ColumnOrder { get; set; }

    /// <summary>
    /// Indicates enum name of the column from the export view
    /// </summary>
    /// <value>Indicates enum name of the column from the export view</value>
    public string ColumnName { get; set; }
}
