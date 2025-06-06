using System.ComponentModel;

namespace PureCloud.Client;

///<Summary>
/// Enumeration of Genesys Cloud regions with their Platform API hosts
///</Summary>
public enum PureCloudRegionHosts
{
    ///<Summary>
    /// us_east_1 Region
    ///</Summary>
    [Description("https://api.mypurecloud.com")]
    us_east_1,

    ///<Summary>
    /// eu_west_1 Region
    ///</Summary>
    [Description("https://api.mypurecloud.ie")]
    eu_west_1,

    ///<Summary>
    /// eu_central_1 Region
    ///</Summary>
    [Description("https://api.mypurecloud.de")]
    eu_central_1,

    ///<Summary>
    /// ap_northeast_1 Region
    ///</Summary>
    [Description("https://api.mypurecloud.jp")]
    ap_northeast_1,

    ///<Summary>
    /// ap_southeast_2 Region
    ///</Summary>
    [Description("https://api.mypurecloud.com.au")]
    ap_southeast_2,

    ///<Summary>
    /// us_west_2 Region
    ///</Summary>
    [Description("https://api.usw2.pure.cloud")]
    us_west_2,

    ///<Summary>
    /// ca_central_1 Region
    ///</Summary>
    [Description("https://api.cac1.pure.cloud")]
    ca_central_1,

    ///<Summary>
    /// ap_northeast_2 Region
    ///</Summary>
    [Description("https://api.apne2.pure.cloud")]
    ap_northeast_2,

    ///<Summary>
    /// eu_west_2 Region
    ///</Summary>
    [Description("https://api.euw2.pure.cloud")]
    eu_west_2,

    ///<Summary>
    /// ap_south_1 Region
    ///</Summary>
    [Description("https://api.aps1.pure.cloud")]
    ap_south_1,

    ///<Summary>
    /// us_east_2 Region
    ///</Summary>
    [Description("https://api.use2.us-gov-pure.cloud")]
    us_east_2,

    ///<Summary>
    /// sa_east_1 Region
    ///</Summary>
    [Description("https://api.sae1.pure.cloud")]
    sa_east_1,

    ///<Summary>
    /// me_central_1 Region
    ///</Summary>
    [Description("https://api.mec1.pure.cloud")]
    me_central_1,

    ///<Summary>
    /// ap_northeast_3 Region
    ///</Summary>
    [Description("https://api.apne3.pure.cloud")]
    ap_northeast_3,

    ///<Summary>
    /// eu_central_2 Region
    ///</Summary>
    [Description("https://api.euc2.pure.cloud")]
    eu_central_2,

}
