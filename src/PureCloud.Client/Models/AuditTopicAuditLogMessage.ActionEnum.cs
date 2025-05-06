using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public partial class AuditTopicAuditLogMessage
{
    /// <summary>
    /// Gets or Sets Action
    /// </summary>

    public enum ActionEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum View for "View"
        /// </summary>
        [EnumMember(Value = "View")]
        View,

        /// <summary>
        /// Enum Create for "Create"
        /// </summary>
        [EnumMember(Value = "Create")]
        Create,

        /// <summary>
        /// Enum Update for "Update"
        /// </summary>
        [EnumMember(Value = "Update")]
        Update,

        /// <summary>
        /// Enum Delete for "Delete"
        /// </summary>
        [EnumMember(Value = "Delete")]
        Delete,

        /// <summary>
        /// Enum Move for "Move"
        /// </summary>
        [EnumMember(Value = "Move")]
        Move,

        /// <summary>
        /// Enum Copy for "Copy"
        /// </summary>
        [EnumMember(Value = "Copy")]
        Copy,

        /// <summary>
        /// Enum Download for "Download"
        /// </summary>
        [EnumMember(Value = "Download")]
        Download,

        /// <summary>
        /// Enum Shareadd for "ShareAdd"
        /// </summary>
        [EnumMember(Value = "ShareAdd")]
        Shareadd,

        /// <summary>
        /// Enum Shareremove for "ShareRemove"
        /// </summary>
        [EnumMember(Value = "ShareRemove")]
        Shareremove,

        /// <summary>
        /// Enum Fax for "Fax"
        /// </summary>
        [EnumMember(Value = "Fax")]
        Fax,

        /// <summary>
        /// Enum Versioncreate for "VersionCreate"
        /// </summary>
        [EnumMember(Value = "VersionCreate")]
        Versioncreate,

        /// <summary>
        /// Enum Tagadd for "TagAdd"
        /// </summary>
        [EnumMember(Value = "TagAdd")]
        Tagadd,

        /// <summary>
        /// Enum Tagremove for "TagRemove"
        /// </summary>
        [EnumMember(Value = "TagRemove")]
        Tagremove,

        /// <summary>
        /// Enum Tagupdate for "TagUpdate"
        /// </summary>
        [EnumMember(Value = "TagUpdate")]
        Tagupdate,

        /// <summary>
        /// Enum Add for "Add"
        /// </summary>
        [EnumMember(Value = "Add")]
        Add,

        /// <summary>
        /// Enum Remove for "Remove"
        /// </summary>
        [EnumMember(Value = "Remove")]
        Remove,

        /// <summary>
        /// Enum Memberadd for "MemberAdd"
        /// </summary>
        [EnumMember(Value = "MemberAdd")]
        Memberadd,

        /// <summary>
        /// Enum Memberupdate for "MemberUpdate"
        /// </summary>
        [EnumMember(Value = "MemberUpdate")]
        Memberupdate,

        /// <summary>
        /// Enum Memberremove for "MemberRemove"
        /// </summary>
        [EnumMember(Value = "MemberRemove")]
        Memberremove,

        /// <summary>
        /// Enum Authorize for "Authorize"
        /// </summary>
        [EnumMember(Value = "Authorize")]
        Authorize,

        /// <summary>
        /// Enum Deauthorize for "Deauthorize"
        /// </summary>
        [EnumMember(Value = "Deauthorize")]
        Deauthorize,

        /// <summary>
        /// Enum Authenticate for "Authenticate"
        /// </summary>
        [EnumMember(Value = "Authenticate")]
        Authenticate,

        /// <summary>
        /// Enum Changepassword for "ChangePassword"
        /// </summary>
        [EnumMember(Value = "ChangePassword")]
        Changepassword,

        /// <summary>
        /// Enum Authenticationfailed for "AuthenticationFailed"
        /// </summary>
        [EnumMember(Value = "AuthenticationFailed")]
        Authenticationfailed,

        /// <summary>
        /// Enum Revoke for "Revoke"
        /// </summary>
        [EnumMember(Value = "Revoke")]
        Revoke,

        /// <summary>
        /// Enum Checkin for "Checkin"
        /// </summary>
        [EnumMember(Value = "Checkin")]
        Checkin,

        /// <summary>
        /// Enum Checkout for "Checkout"
        /// </summary>
        [EnumMember(Value = "Checkout")]
        Checkout,

        /// <summary>
        /// Enum Deactivate for "Deactivate"
        /// </summary>
        [EnumMember(Value = "Deactivate")]
        Deactivate,

        /// <summary>
        /// Enum Debug for "Debug"
        /// </summary>
        [EnumMember(Value = "Debug")]
        Debug,

        /// <summary>
        /// Enum Publish for "Publish"
        /// </summary>
        [EnumMember(Value = "Publish")]
        Publish,

        /// <summary>
        /// Enum Revert for "Revert"
        /// </summary>
        [EnumMember(Value = "Revert")]
        Revert,

        /// <summary>
        /// Enum Save for "Save"
        /// </summary>
        [EnumMember(Value = "Save")]
        Save,

        /// <summary>
        /// Enum Transcode for "Transcode"
        /// </summary>
        [EnumMember(Value = "Transcode")]
        Transcode,

        /// <summary>
        /// Enum Upload for "Upload"
        /// </summary>
        [EnumMember(Value = "Upload")]
        Upload,

        /// <summary>
        /// Enum Wrapupcodeadd for "WrapupCodeAdd"
        /// </summary>
        [EnumMember(Value = "WrapupCodeAdd")]
        Wrapupcodeadd,

        /// <summary>
        /// Enum Wrapupcoderemove for "WrapupCodeRemove"
        /// </summary>
        [EnumMember(Value = "WrapupCodeRemove")]
        Wrapupcoderemove,

        /// <summary>
        /// Enum Read for "Read"
        /// </summary>
        [EnumMember(Value = "Read")]
        Read,

        /// <summary>
        /// Enum Execute for "Execute"
        /// </summary>
        [EnumMember(Value = "Execute")]
        Execute,

        /// <summary>
        /// Enum Abandon for "Abandon"
        /// </summary>
        [EnumMember(Value = "Abandon")]
        Abandon,

        /// <summary>
        /// Enum Archive for "Archive"
        /// </summary>
        [EnumMember(Value = "Archive")]
        Archive,

        /// <summary>
        /// Enum Export for "Export"
        /// </summary>
        [EnumMember(Value = "Export")]
        Export,

        /// <summary>
        /// Enum Restorerequest for "RestoreRequest"
        /// </summary>
        [EnumMember(Value = "RestoreRequest")]
        Restorerequest,

        /// <summary>
        /// Enum Restorecomplete for "RestoreComplete"
        /// </summary>
        [EnumMember(Value = "RestoreComplete")]
        Restorecomplete,

        /// <summary>
        /// Enum Updateretention for "UpdateRetention"
        /// </summary>
        [EnumMember(Value = "UpdateRetention")]
        Updateretention,

        /// <summary>
        /// Enum Applyprotection for "ApplyProtection"
        /// </summary>
        [EnumMember(Value = "ApplyProtection")]
        Applyprotection,

        /// <summary>
        /// Enum Revokeprotection for "RevokeProtection"
        /// </summary>
        [EnumMember(Value = "RevokeProtection")]
        Revokeprotection,

        /// <summary>
        /// Enum Rotate for "Rotate"
        /// </summary>
        [EnumMember(Value = "Rotate")]
        Rotate,

        /// <summary>
        /// Enum Deleteall for "DeleteAll"
        /// </summary>
        [EnumMember(Value = "DeleteAll")]
        Deleteall,

        /// <summary>
        /// Enum Reassign for "Reassign"
        /// </summary>
        [EnumMember(Value = "Reassign")]
        Reassign,

        /// <summary>
        /// Enum Unarchive for "Unarchive"
        /// </summary>
        [EnumMember(Value = "Unarchive")]
        Unarchive,

        /// <summary>
        /// Enum Activate for "Activate"
        /// </summary>
        [EnumMember(Value = "Activate")]
        Activate,

        /// <summary>
        /// Enum Assign for "Assign"
        /// </summary>
        [EnumMember(Value = "Assign")]
        Assign,

        /// <summary>
        /// Enum Unassign for "Unassign"
        /// </summary>
        [EnumMember(Value = "Unassign")]
        Unassign,

        /// <summary>
        /// Enum Reset for "Reset"
        /// </summary>
        [EnumMember(Value = "Reset")]
        Reset,

        /// <summary>
        /// Enum Reschedule for "Reschedule"
        /// </summary>
        [EnumMember(Value = "Reschedule")]
        Reschedule,

        /// <summary>
        /// Enum Complete for "Complete"
        /// </summary>
        [EnumMember(Value = "Complete")]
        Complete,

        /// <summary>
        /// Enum Cancel for "Cancel"
        /// </summary>
        [EnumMember(Value = "Cancel")]
        Cancel,

        /// <summary>
        /// Enum Unpublish for "Unpublish"
        /// </summary>
        [EnumMember(Value = "Unpublish")]
        Unpublish,

        /// <summary>
        /// Enum Purge for "Purge"
        /// </summary>
        [EnumMember(Value = "Purge")]
        Purge,

        /// <summary>
        /// Enum Processed for "Processed"
        /// </summary>
        [EnumMember(Value = "Processed")]
        Processed,

        /// <summary>
        /// Enum Enable for "Enable"
        /// </summary>
        [EnumMember(Value = "Enable")]
        Enable,

        /// <summary>
        /// Enum Disable for "Disable"
        /// </summary>
        [EnumMember(Value = "Disable")]
        Disable,

        /// <summary>
        /// Enum Recycle for "Recycle"
        /// </summary>
        [EnumMember(Value = "Recycle")]
        Recycle,

        /// <summary>
        /// Enum Append for "Append"
        /// </summary>
        [EnumMember(Value = "Append")]
        Append,

        /// <summary>
        /// Enum Contactsupdated for "ContactsUpdated"
        /// </summary>
        [EnumMember(Value = "ContactsUpdated")]
        Contactsupdated,

        /// <summary>
        /// Enum Contactsdeleted for "ContactsDeleted"
        /// </summary>
        [EnumMember(Value = "ContactsDeleted")]
        Contactsdeleted,

        /// <summary>
        /// Enum Restore for "Restore"
        /// </summary>
        [EnumMember(Value = "Restore")]
        Restore,

        /// <summary>
        /// Enum Block for "Block"
        /// </summary>
        [EnumMember(Value = "Block")]
        Block,

        /// <summary>
        /// Enum Unblock for "Unblock"
        /// </summary>
        [EnumMember(Value = "Unblock")]
        Unblock,

        /// <summary>
        /// Enum Open for "Open"
        /// </summary>
        [EnumMember(Value = "Open")]
        Open,

        /// <summary>
        /// Enum Approved for "Approved"
        /// </summary>
        [EnumMember(Value = "Approved")]
        Approved,

        /// <summary>
        /// Enum Rejected for "Rejected"
        /// </summary>
        [EnumMember(Value = "Rejected")]
        Rejected,

        /// <summary>
        /// Enum Rollback for "Rollback"
        /// </summary>
        [EnumMember(Value = "Rollback")]
        Rollback,

        /// <summary>
        /// Enum Implementingchange for "ImplementingChange"
        /// </summary>
        [EnumMember(Value = "ImplementingChange")]
        Implementingchange,

        /// <summary>
        /// Enum Changeimplemented for "ChangeImplemented"
        /// </summary>
        [EnumMember(Value = "ChangeImplemented")]
        Changeimplemented,

        /// <summary>
        /// Enum Implementingrollback for "ImplementingRollback"
        /// </summary>
        [EnumMember(Value = "ImplementingRollback")]
        Implementingrollback,

        /// <summary>
        /// Enum Rollbackimplemented for "RollbackImplemented"
        /// </summary>
        [EnumMember(Value = "RollbackImplemented")]
        Rollbackimplemented,

        /// <summary>
        /// Enum Write for "Write"
        /// </summary>
        [EnumMember(Value = "Write")]
        Write,

        /// <summary>
        /// Enum Replace for "Replace"
        /// </summary>
        [EnumMember(Value = "Replace")]
        Replace,

        /// <summary>
        /// Enum Updateinservice for "UpdateInService"
        /// </summary>
        [EnumMember(Value = "UpdateInService")]
        Updateinservice,

        /// <summary>
        /// Enum Updateoutofservice for "UpdateOutOfService"
        /// </summary>
        [EnumMember(Value = "UpdateOutOfService")]
        Updateoutofservice,

        /// <summary>
        /// Enum Cycle for "Cycle"
        /// </summary>
        [EnumMember(Value = "Cycle")]
        Cycle,

        /// <summary>
        /// Enum Scale for "Scale"
        /// </summary>
        [EnumMember(Value = "Scale")]
        Scale,

        /// <summary>
        /// Enum Asginservice for "AsgInservice"
        /// </summary>
        [EnumMember(Value = "AsgInservice")]
        Asginservice,

        /// <summary>
        /// Enum Awsoutofservice for "AwsOutofservice"
        /// </summary>
        [EnumMember(Value = "AwsOutofservice")]
        Awsoutofservice,

        /// <summary>
        /// Enum Asgterminate for "AsgTerminate"
        /// </summary>
        [EnumMember(Value = "AsgTerminate")]
        Asgterminate,

        /// <summary>
        /// Enum Detach for "Detach"
        /// </summary>
        [EnumMember(Value = "Detach")]
        Detach,

        /// <summary>
        /// Enum Terminate for "Terminate"
        /// </summary>
        [EnumMember(Value = "Terminate")]
        Terminate,

        /// <summary>
        /// Enum Blockupgrade for "BlockUpgrade"
        /// </summary>
        [EnumMember(Value = "BlockUpgrade")]
        Blockupgrade,

        /// <summary>
        /// Enum Unblockupgrade for "UnblockUpgrade"
        /// </summary>
        [EnumMember(Value = "UnblockUpgrade")]
        Unblockupgrade,

        /// <summary>
        /// Enum Asgswapinstancetype for "AsgSwapInstanceType"
        /// </summary>
        [EnumMember(Value = "AsgSwapInstanceType")]
        Asgswapinstancetype,

        /// <summary>
        /// Enum Recreateasg for "RecreateAsg"
        /// </summary>
        [EnumMember(Value = "RecreateAsg")]
        Recreateasg,

        /// <summary>
        /// Enum Deleteunconfigurededge for "DeleteUnconfiguredEdge"
        /// </summary>
        [EnumMember(Value = "DeleteUnconfiguredEdge")]
        Deleteunconfigurededge,

        /// <summary>
        /// Enum Getasglist for "GetAsgList"
        /// </summary>
        [EnumMember(Value = "GetAsgList")]
        Getasglist,

        /// <summary>
        /// Enum Getasg for "GetAsg"
        /// </summary>
        [EnumMember(Value = "GetAsg")]
        Getasg,

        /// <summary>
        /// Enum Upgradeorganizationsite for "UpgradeOrganizationSite"
        /// </summary>
        [EnumMember(Value = "UpgradeOrganizationSite")]
        Upgradeorganizationsite,

        /// <summary>
        /// Enum Updateawsconfig for "UpdateAwsConfig"
        /// </summary>
        [EnumMember(Value = "UpdateAwsConfig")]
        Updateawsconfig,

        /// <summary>
        /// Enum Getawsconfig for "GetAwsConfig"
        /// </summary>
        [EnumMember(Value = "GetAwsConfig")]
        Getawsconfig,

        /// <summary>
        /// Enum Deleteghostedgerecord for "DeleteGhostEdgeRecord"
        /// </summary>
        [EnumMember(Value = "DeleteGhostEdgeRecord")]
        Deleteghostedgerecord,

        /// <summary>
        /// Enum Upgradecleanup for "UpgradeCleanup"
        /// </summary>
        [EnumMember(Value = "UpgradeCleanup")]
        Upgradecleanup,

        /// <summary>
        /// Enum Ipallowlistclear for "IpAllowlistClear"
        /// </summary>
        [EnumMember(Value = "IpAllowlistClear")]
        Ipallowlistclear,

        /// <summary>
        /// Enum Addpairingrole for "AddPairingRole"
        /// </summary>
        [EnumMember(Value = "AddPairingRole")]
        Addpairingrole,

        /// <summary>
        /// Enum Verify for "Verify"
        /// </summary>
        [EnumMember(Value = "Verify")]
        Verify,

        /// <summary>
        /// Enum Restoredeleted for "RestoreDeleted"
        /// </summary>
        [EnumMember(Value = "RestoreDeleted")]
        Restoredeleted,

        /// <summary>
        /// Enum Restoreall for "RestoreAll"
        /// </summary>
        [EnumMember(Value = "RestoreAll")]
        Restoreall,

        /// <summary>
        /// Enum Approve for "Approve"
        /// </summary>
        [EnumMember(Value = "Approve")]
        Approve,

        /// <summary>
        /// Enum Reject for "Reject"
        /// </summary>
        [EnumMember(Value = "Reject")]
        Reject,

        /// <summary>
        /// Enum Reverse for "Reverse"
        /// </summary>
        [EnumMember(Value = "Reverse")]
        Reverse,

        /// <summary>
        /// Enum Send for "Send"
        /// </summary>
        [EnumMember(Value = "Send")]
        Send,

        /// <summary>
        /// Enum Harddelete for "HardDelete"
        /// </summary>
        [EnumMember(Value = "HardDelete")]
        Harddelete,

        /// <summary>
        /// Enum Softdelete for "SoftDelete"
        /// </summary>
        [EnumMember(Value = "SoftDelete")]
        Softdelete,

        /// <summary>
        /// Enum Submit for "Submit"
        /// </summary>
        [EnumMember(Value = "Submit")]
        Submit,

        /// <summary>
        /// Enum Enablecapture for "EnableCapture"
        /// </summary>
        [EnumMember(Value = "EnableCapture")]
        Enablecapture,

        /// <summary>
        /// Enum Downloadcapture for "DownloadCapture"
        /// </summary>
        [EnumMember(Value = "DownloadCapture")]
        Downloadcapture,

        /// <summary>
        /// Enum Succeeded for "Succeeded"
        /// </summary>
        [EnumMember(Value = "Succeeded")]
        Succeeded,

        /// <summary>
        /// Enum Failed for "Failed"
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed,

        /// <summary>
        /// Enum Initiate for "Initiate"
        /// </summary>
        [EnumMember(Value = "Initiate")]
        Initiate,

        /// <summary>
        /// Enum Reversemanually for "ReverseManually"
        /// </summary>
        [EnumMember(Value = "ReverseManually")]
        Reversemanually,

        /// <summary>
        /// Enum Calculate for "Calculate"
        /// </summary>
        [EnumMember(Value = "Calculate")]
        Calculate,

        /// <summary>
        /// Enum Provisioned for "Provisioned"
        /// </summary>
        [EnumMember(Value = "Provisioned")]
        Provisioned,

        /// <summary>
        /// Enum Updateaborted for "UpdateAborted"
        /// </summary>
        [EnumMember(Value = "UpdateAborted")]
        Updateaborted
    }
}
