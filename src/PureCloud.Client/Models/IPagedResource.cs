namespace PureCloud.Client.Models;

///<Summary>
/// Interface for Paged Resource
///</Summary>
///
[Obsolete("This interface should not be used instead use PagedResource<T>.")]
public interface IPagedResource<T>
{
    ///<Summary>
    /// Page Size
    ///</Summary>
    int? PageSize { get; set; }

    ///<Summary>
    /// Page Number
    ///</Summary>
    int? PageNumber { get; set; }

    ///<Summary>
    /// Total
    ///</Summary>
    long? Total { get; set; }

    ///<Summary>
    /// Self Uri
    ///</Summary>
    string SelfUri { get; set; }

    ///<Summary>
    /// First Uri
    ///</Summary>
    string FirstUri { get; set; }

    ///<Summary>
    /// Previous Uri
    ///</Summary>
    string PreviousUri { get; set; }

    ///<Summary>
    /// Next Uri
    ///</Summary>
    string NextUri { get; set; }

    ///<Summary>
    /// Last Uri
    ///</Summary>
    string LastUri { get; set; }

    ///<Summary>
    /// Page Count
    ///</Summary>
    int? PageCount { get; set; }

    ///<Summary>
    /// Entities
    ///</Summary>
    IEnumerable<T> Entities { get; set; }
}
