using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LuaFramework;
using UnityEngine;
using System.IO;
//using FluorineFx;
//using FluorineFx.AMF3;
//using FluorineFx.Messaging;
//using FluorineFx.Messaging.Messages;
//using FluorineFx.IO;

public class HttpManager:Manager<HttpManager>
{
    //public delegate void HttpReponseCallBack(ASObject data);

    //public class HttpEvent{
    //    public List<object> parms;
    //    public HttpReponseCallBack ResponseCallBack;
    //    public HttpEvent(List<object> list, HttpReponseCallBack _callback)
    //    {
    //        parms = list;
    //        ResponseCallBack = _callback;
    //    }
    //}

    //private Queue<HttpEvent> EventQuene;
    //private bool isWaiting = false;
    //Dictionary<string, string> dic = new Dictionary<string, string>();
    

    //void Awake()
    //{
    //    dic.Add("Content-type", "application/x-amf");
    //    EventQuene = new Queue<HttpEvent>();
    //}

    //void Update()
    //{
    //    if (isWaiting)
    //    {
    //        return;
    //    }
    //    if (EventQuene.Count == 0)
    //    {
    //        return;
    //    }

    //    HttpEvent evt = EventQuene.Dequeue();
    //    AMFMessage amfMessage = new AMFMessage();
    //    AMFBody body = new AMFBody("DataHandler.handle", "/1", evt.parms);
    //    amfMessage.AddBody(body);
    //    MemoryStream _Memory = new MemoryStream();//内存流
    //    AMFSerializer _Serializer = new AMFSerializer(_Memory);//序列化
    //    _Serializer.WriteMessage(amfMessage);//将消息写入
    //    byte[] _buffer = _Memory.ToArray();
    //    string url = "http://farm-devtt.socialgamenet.com/gateway.php?s=dfd_" + AppConst.PlayerUUID;
    //    StartCoroutine(SendWWW(url, _buffer, evt.ResponseCallBack));
    //}

    //public IEnumerator SendWWW(string url, byte[] param, HttpReponseCallBack callback)
    //{
    //    isWaiting = true;
    //    WWW www = new WWW(url, param, dic);
    //    yield return www;
    //    MemoryStream ms = new MemoryStream(www.bytes);
    //    AMFDeserializer deserializer = new AMFDeserializer(ms);
    //    AMFMessage message = deserializer.ReadAMFMessage();
    //    AMFBody rBody = message.GetBodyAt(0);
    //    ASObject content = (ASObject)rBody.Content;
    //    callback(content);
    //}

    //public void AddHttpEvent(List<object> list, HttpReponseCallBack _callBack)
    //{
    //    EventQuene.Enqueue(new HttpEvent(list, _callBack));
    //}

}

