﻿using TS3QueryLib.Core.CommandHandling;

namespace TS3QueryLib.Core.Server
{
    public enum CommandName
    {
        Help,
        Login,
        Logout,
        Version,
        HostInfo,
        InstanceInfo,
        InstanceEdit,
        BindingList,
        ServerList,
        ServerIdGetByPort,
        ServerDelete,
        Servercreate,
        ServerStart,
        ServerStop,
        ServerProcessStop,
        ServerInfo,
        ServerRequestConnectionInfo,
        ServerEdit,
        ServerGroupList,
        ServerGroupAdd,
        ServerGroupDel,
        ServerGroupCopy,
        ServerGroupRename,
        ServerGroupPermList,
        ServerGroupAddPerm,
        ServerGroupDelPerm,
        ServerGroupAddClient,
        ServerGroupDelClient,
        ServerGroupClientList,
        ServerGroupsByClientId,
        ServerSnapshotCreate,
        ServerSnapshotDeploy,
        ServerNotifyRegister,
        ServerNotifyUnregister,
        Gm,
        SendTextMessage,
        LogView,
        LogAdd,
        ChannelList,
        ChannelInfo,
        ChannelFind,
        ChannelMove,
        ChannelCreate,
        ChannelEdit,
        ChannelDelete,
        ChannelPermList,
        ChannelAddPerm,
        ChannelDelPerm,
        ChannelGroupList,
        ChannelGroupAdd,
        ChannelGroupDel,
        ChannelGroupCopy,
        ChannelGroupRename,
        ChannelGroupAddPerm,
        ChannelGroupDelPerm,
        ChannelGroupPermList,
        ChannelGroupClientList,
        SetClientChannelGroup,
        ClientList,
        ClientInfo,
        ClientDbInfo,
        ClientFind,
        ClientEdit,
        ClientDbList,
        ClientDbFind,
        ClientDbEdit,
        ClientDbDelete,
        ClientGetIds,
        ClientGetDbIdFromUId,
        ClientGetNameFromUId,
        ClientGetNameFromDbId,
        ClientSetServerQueryLogin,
        ClientMove,
        ClientKick,
        ClientPoke,
        ClientPermList,
        ClientAddPerm,
        ClientDelPerm,
        ChannelClientPermList,
        ChannelClientAddPerm,
        ChannelClientDelPerm,
        PermissionList,
        PermIdGetByName,
        PermOverview,
        PermFind,
        PermReset,
        PermGet,
        PrivilegeKeyList,
        PrivilegeKeyAdd,
        PrivilegeKeyDelete,
        PrivilegeKeyUse,
        MessageList,
        MessageAdd,
        MessageGet,
        MessageUpdateFlag,
        MessageDel,
        ComplainList,
        ComplainAdd,
        ComplainDel,
        ComplainDelAll,
        BanClient,
        BanList,
        BanAdd,
        BanDel,
        BanDelAll,
        FtInitUpload,
        FtInitDownload,
        FtList,
        FtGetFileList,
        FtGetFileInfo,
        FtStop,
        FtDeleteFile,
        FtCreateDir,
        FtRenameFile,
        CustomSearch,
        CustomInfo
    }

    public static class CommandNameExtensions
    {
        public static Command CreateCommand(this CommandName commandName)
        {
            return new Command(commandName);
        }
    }
}