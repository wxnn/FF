using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class AppFacade : Facade
{
    private static AppFacade _instance;

    public AppFacade() : base()
    {
    }

    public static AppFacade Instance
    {
        get{
            if (_instance == null) {
                _instance = new AppFacade();
            }
            return _instance;
        }
    }

    override protected void InitFramework()
    {
        base.InitFramework();
        RegisterCommand(CommandConst.START_UP, typeof(StartUpCommand));
        RegisterCommand(CommandConst.LOGIN_CMD, typeof(LoginCommand));
        RegisterCommand(CommandConst.UPDATE_RESOURCE_CMD, typeof(UpdateCommand));
        RegisterCommand(CommandConst.LOAD_DATA_CMD, typeof(LoadDataCommand));
    }

    /// <summary>
    /// 启动框架
    /// </summary>
    public void StartUp() {
        SendMessageCommand(CommandConst.START_UP);
        RemoveMultiCommand(CommandConst.START_UP);
    }
}

