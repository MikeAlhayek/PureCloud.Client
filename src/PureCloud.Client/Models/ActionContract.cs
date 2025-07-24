using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// This resource contains all of the schemas needed to define the inputs and outputs, of a single Action.
/// </summary>
public sealed class ActionContract
{
    // The output to expect when executing this action.
    public ActionOutput Output { get; set; }

    // The input required when executing this action.
    public ActionInput Input { get; set; }
}
