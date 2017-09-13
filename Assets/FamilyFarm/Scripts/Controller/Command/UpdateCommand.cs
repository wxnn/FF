using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Net;
using LuaFramework;
using UnityEngine;


public class UpdateCommand:BaseCommand, ITimerBehaviour
{
    
    private List<string> downloadFiles = new List<string>();
    private string DOWN_VERSION_FILE = "downversionfile";
    private string DOWN_RESOURCE = "downresource";
    private Queue<string> downList = new Queue<string>();
    private int downloadCount = 0;
    private int downloadMax = 5;
    private int downloadTotal;
    private int downloadCompleteCount = 0;
    private delegate void CallBack(string type, string url);
    private CallBack _downloadCallBack;
    private Dictionary<string, Thread> threadDic = new Dictionary<string, Thread>();
    private TimerInfo checkTimer;

    public UpdateCommand()
    {
        _downloadCallBack = DownloadCallBack;
    }

    public override void Execute(IMessage message)
    {
        if (!Directory.Exists(Util.DataPath))
        {
            Directory.CreateDirectory(Util.DataPath);
        }
        facade.SendMessageCommand(NotiConst.UPDATE_FILE_LIST, 0);
        DownLoadVersionFile();
    }

    private void DownLoadVersionFile()
    {
        string downUrl = AppConst.HOST + AppConst.AssetDir +"/"+ AppConst.FileListName + "?v=" + Util.randomTimer;
        string savePath = Util.DataPath + AppConst.FileListName;
        Download dt =new Download(DOWN_VERSION_FILE, savePath, downUrl,_downloadCallBack);
        dt.StartDown();
    }

    private void ExtractResource()
    {
        string message = "正在解包文件:>files.txt";
        string fileListPath = Util.DataPath + AppConst.FileListName;
        string[] files = File.ReadAllLines(fileListPath);
        string localfile;
        string version;
        int index = 0;
        int total = files.Count();

        downList.Enqueue("en_US.config");

        foreach (var file in files)
        {
            index++;
            string[] fs = file.Split('|');
            string fileName = fs[0];
            localfile = Util.DataPath + fileName;
            version = fs[1];

            message = "正在解包文件:>" + fs[0];
            Debug.Log("正在解包文件:>" + localfile);
            float progress = (float)(index / total);
            facade.SendMessageCommand(NotiConst.UPDATE_EXTRACT, progress);

            string dir = Path.GetDirectoryName(localfile);
            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
            bool canUpdate = !File.Exists(localfile);
            if (!canUpdate)
            {
                string remoteMd5 = version.Trim();
                string localMd5 = Util.md5file(localfile);
                canUpdate = !remoteMd5.Equals(localMd5);
            }
            if (canUpdate) {
                downList.Enqueue(fileName);
            }
        }
        downloadTotal = downList.Count;
        if(downList.Count > 0)
        {
            UpdateResource();
            checkTimer = new TimerInfo("UpdateCommand", this);
            GetManager<TimerManager>(ManagerName.Timer).AddTimerEvent(checkTimer);
        }else
        {
            OnResourceInited();
        }
        
    }

    private void UpdateResource()
    {
        Debug.Log("UpdateResource");
        while(downloadCount < downloadMax && downList.Count>0)
        {
            downloadCount++;
            string fileName = downList.Dequeue();
            string savePath = Util.DataPath + fileName;
            string webUrl = AppConst.HOST +AppConst.AssetDir +"/"+ fileName + "?v=" + Util.randomTimer;
            Download down = new Download(DOWN_RESOURCE, savePath, webUrl, _downloadCallBack);
            Thread thread = new Thread(new ThreadStart(down.StartDown));
            thread.Start();
            threadDic.Add(savePath, thread);
        }
    }

    private void DownloadCallBack(string type,string url)
    {
        if (type.Equals(DOWN_VERSION_FILE))
        {
            Debug.Log("download " + AppConst.FileListName + " is OK");
            facade.SendMessageCommand(NotiConst.UPDATE_FILE_LIST, 1);
            ExtractResource();
        }else if (type.Equals(DOWN_RESOURCE))
        {
            downloadCount--;
            downloadCompleteCount++;

            Thread thread;
            bool result = threadDic.TryGetValue(url,out thread);
            if (result)
            {
                Debug.Log("销毁线程");
                thread.Abort();
            }
        }    
    }

    public void TimerUpdate()
    {
        string _message = string.Format("正在下载资源{0}/{1}", downloadCompleteCount, downloadTotal);
        Hashtable table = new Hashtable();
        table.Add("downCount", downloadCompleteCount);
        table.Add("downTotal", downloadTotal);
        facade.SendMessageCommand(NotiConst.UPDATE_DOWNLOAD, table);
        if (downloadCompleteCount == downloadTotal)
        {
            OnResourceInited();
            GetManager<TimerManager>(ManagerName.Timer).RemoveTimerEvent(checkTimer);
        }
        else
        {
           UpdateResource();
        }
    }

    private class Download{
        private string downType;
        private string savePath;
        private string downUrl;
        private CallBack callBack;
        public Download(string type, string name, string url, CallBack call)
        {
            downType = type;
            savePath = name;
            downUrl = url;
            callBack = call;
        }

        public void StartDown()
        {
            FileStream fs;
            if (File.Exists(savePath))
            {
                
                File.Delete(savePath);
            }

            fs = new FileStream(savePath, FileMode.Create);

            try
            {
                long DownloadByte = 0;
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(downUrl);                               
                Stream ns = request.GetResponse().GetResponseStream();
                byte[] nbytes = new byte[1024];
                int nReadSize = 0;
                nReadSize = ns.Read(nbytes, 0, 1024);
                while (nReadSize > 0)
                {
                    fs.Write(nbytes, 0, nReadSize);
                    nReadSize = ns.Read(nbytes, 0, 1024);
                    DownloadByte = DownloadByte + nReadSize;
                    //Debug.Log(DownloadByte);
                }
                fs.Close();
                ns.Close();
                //Debug.Log("Loading complete");
                callBack(downType,savePath);
            }
            catch (Exception ex)
            {
                fs.Close();
                Debug.Log(downUrl + ex.ToString());
                //callBack(downType, savePath);
            }
        }
    }
 
    /// <summary>
    /// 资源初始化结束
    /// </summary>
    public void OnResourceInited()
    {
        GetManager<ResourceManager>(ManagerName.Resource).Initialize();
        facade.SendMessageCommand(CommandConst.LOAD_DATA_CMD);
        //this.OnInitialize();
        //GetManager<GameManager>(ManagerName.Game).OnResourceInited();
    }
}

