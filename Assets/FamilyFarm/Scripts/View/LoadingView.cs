using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;


public class LoadingView:View, IState
{
    private GameObject loadingRoot;
    private Text loadingDesc;
    private Slider slider;
    public void OpenState()
    {
        loadingRoot = GameObject.Find("UICanvas/LoadingRoot");
        GameObject prefab = (GameObject)Resources.Load("LoadingUI");
        GameObject loadingUI = (GameObject)Instantiate(prefab);
        if (loadingUI != null)
        {
            loadingUI.transform.SetParent(loadingRoot.transform, false);
            loadingDesc = loadingUI.transform.FindChild("LoadingText").GetComponent<Text>();
            slider = loadingUI.GetComponentInChildren<Slider>();
        }
        Awake();

        if (ResManager.inited)
        {
            facade.SendMessageCommand(CommandConst.LOAD_DATA_CMD);//资源初始化完成，说明UpdateCommand在登录前已经更新完成
        }
    }

    public void CloseState()
    {
        loadingRoot.SetActive(false);
    }

    List<string> MessageList
    {
        get
        {
            return new List<string>()
            { 
                NotiConst.UPDATE_MESSAGE,
                NotiConst.UPDATE_FILE_LIST,
                NotiConst.UPDATE_EXTRACT,
                NotiConst.UPDATE_DOWNLOAD,
                NotiConst.UPDATE_PROGRESS,
                NotiConst.UPDATE_LOAD_DATA,
            };
        }
    }

    void Awake()
    {
        RemoveMessage(this, MessageList);
        RegisterMessage(this, MessageList);
    }

    /// <summary>
    /// 处理View消息
    /// </summary>
    /// <param name="message"></param>
    public override void OnMessage(IMessage message)
    {
        string name = message.Name;
        object body = message.Body;
        switch (name)
        {
            case NotiConst.UPDATE_FILE_LIST:      //更新消息
                loadingDesc.text = "正在更新文件列表";
                Debug.Log(body.GetType());
                slider.value = (float)Convert.ToDouble(body);
                break;
            case NotiConst.UPDATE_EXTRACT:      //更新解压
                loadingDesc.text = "正在解压文件....";
                slider.value = (float)Convert.ToDouble(body);
                break;
            case NotiConst.UPDATE_DOWNLOAD:     //更新下载
                Hashtable table = (Hashtable)body;
                int downCount = (int)(table["downCount"]);
                int downTotal = (int)(table["downTotal"]);
                loadingDesc.text = string.Format("正在更新资源{0}/{1}", downCount, downTotal);
                slider.value = (float)downCount / (float)downTotal;
                Debug.Log(slider.value);
                break;
            case NotiConst.UPDATE_LOAD_DATA:
                loadingDesc.text = "正在加载玩家数据....";
                slider.value = (float)Convert.ToDouble(body);
                break;
                //case NotiConst.UPDATE_PROGRESS:     //更新下载进度
                //    UpdateProgress(body.ToString());
                //    break;
        }
    }
}

