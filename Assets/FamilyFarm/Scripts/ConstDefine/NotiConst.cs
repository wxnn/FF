using UnityEngine;
using System.Collections;

public class NotiConst
{
    /// <summary>
    /// Controller层消息通知
    /// </summary>
    public const string DISPATCH_MESSAGE = "DispatchMessage";       //派发信息

    /// <summary>
    /// View层消息通知
    /// </summary>
    public const string UPDATE_MESSAGE = "udpatemessage";
    public const string UPDATE_FILE_LIST = "Updatefilelist";           //更新消息
    public const string UPDATE_EXTRACT = "UpdateExtract";           //更新解包
    public const string UPDATE_DOWNLOAD = "UpdateDownload";         //更新下载
    public const string UPDATE_PROGRESS = "UpdateProgress";         //更新进度
    public const string UPDATE_LOAD_DATA = "UpdateLoadData";        //加载玩家数据

    public const string SHOW_PANEL = "show_panel";
    public const string HIDE_PANEL = "hide_panel";

    public const string MOVE_TO_TARGET_MAPOBJECT = "move_to_target_mapobject";
    public const string USE_TOOL = "use_tool";
    public const string RETURN_TO_MAP = "return_to_map";
    public const string ACTIVE_DRAG_SCREEN = "active_drag_screen";
}
