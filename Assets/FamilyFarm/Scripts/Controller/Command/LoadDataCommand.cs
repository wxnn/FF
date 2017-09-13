using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using LuaFramework;
//using FluorineFx;


public class LoadDataCommand:BaseCommand
{
    //HttpManager.HttpReponseCallBack LoadCallBack;
    public override void Execute(IMessage message)
    {
        //base.Execute(message);

        if (PlayerPrefs.GetString("uuid").Equals(""))
        {
            //等在登录界面，这个执行消息有可能是UpateCommand内资源加载完以后发来的。
            return;
        }
        facade.SendMessageCommand(NotiConst.UPDATE_LOAD_DATA, 0.9);
        GetManager<GameManager>(ManagerName.Game).currentState(StateConst.PLAY_STATE);
        //LoadCallBack = LoadDataCallBack;

        List<object> list = new List<object>();
        list.Add("retrieve_data");
        Hashtable table = new Hashtable();
        table.Add("sgnSession", "3b009ac212fc47efeb681ae1376412ca");
        table.Add("sgnKey", "123456789ab");
        table.Add("loginSession", "funplus123");
        table.Add("swf_version", "WIN 23,0,0,185");
        table.Add("cur_sceneid", 0);
        table.Add("lang", "en_US");
        table.Add("fb_sig_user", "11301133160002");
        list.Add(table);
        list.Add("retrieve");

        //GetManager<HttpManager>(ManagerName.Http).AddHttpEvent(list, LoadCallBack);

    }

    //private void LoadDataCallBack(ASObject content)
    //{
    //    ASObject data = (ASObject)content["data"];
    //    GetManager<DataManager>(ManagerName.MyData).init(data);
    //    GetManager<GameManager>(ManagerName.Game).currentState(StateConst.PLAY_STATE);
    //}
}

