using UnityEngine;
using System.Collections;
using LuaFramework;

public class StartUpCommand : BaseCommand {

    public override void Execute(IMessage message) {

        //-----------------初始化管理器-----------------------
        AppFacade.Instance.AddManager<LuaManager>(ManagerName.Lua);
        AppFacade.Instance.AddManager<PanelManager>(ManagerName.Panel);
        AppFacade.Instance.AddManager<SoundManager>(ManagerName.Sound);
        AppFacade.Instance.AddManager<TimerManager>(ManagerName.Timer);
        AppFacade.Instance.AddManager<DataManager>(ManagerName.MyData);
        AppFacade.Instance.AddManager<DataManager>(ManagerName.FriendData);
        //AppFacade.Instance.AddManager<NetworkManager>(ManagerName.Network);
        AppFacade.Instance.AddManager<ResourceManager>(ManagerName.Resource);
        AppFacade.Instance.AddManager<HttpManager>(ManagerName.Http);
        //AppFacade.Instance.AddManager<ThreadManager>(ManagerName.Thread);
        //AppFacade.Instance.AddManager<ObjectPoolManager>(ManagerName.ObjectPool);

        AppFacade.Instance.AddManager<GameManager>(ManagerName.Game);

        AppFacade.Instance.SendMessageCommand(CommandConst.UPDATE_RESOURCE_CMD);
        AppFacade.Instance.RemoveCommand(CommandConst.UPDATE_RESOURCE_CMD);
    }
}