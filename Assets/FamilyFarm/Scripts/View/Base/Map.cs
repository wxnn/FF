using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Map :View
{
    private Dictionary<string, MapObject> mapDic = new Dictionary<string, MapObject>();
    private Tool currentTool;
    private MapObject currentMapObj;
    private Dictionary<ToolType, Tool> toolDic;
    private float touchDelay = 0;
    private bool startLongTouch = false;

    List<string> MessageList
    {
        get
        {
            return new List<string>()
            {
                NotiConst.USE_TOOL,
            };
        }
    }

    void Awake()
    {
        RemoveMessage(this, MessageList);
        RegisterMessage(this, MessageList);
    }

    public override void OnMessage(IMessage message)
    {
        //base.OnMessage(message);
        switch (message.Name)
        {
            case NotiConst.USE_TOOL:
                ChangeTool((ToolType)message.Body);
                break;
        }
    }

    public void InitMap()
    {
        Hashtable[] objs = MyDataManager.getMapObjectsData();
        for (int i = 0; i < objs.Length; i++)
        {
            Hashtable obj = (Hashtable)objs[i];
            MapObject mapObj = MapObject.Create<MapObject>(obj);
            Vector3 mapPos = mapObj.transform.position;
            for (int m = (int)mapPos.x; m < mapPos.x + mapObj.sizeX; m++)
            {
                for (int n = (int)mapPos.z; n < mapPos.z + mapObj.sizeZ; n++)
                {
                    mapDic.Remove(m + "_" + n);
                    mapDic.Add(m + "_" + n, mapObj);
                }
            }
            mapObj.transform.SetParent(this.transform);
        }
        toolDic = new Dictionary<ToolType, Tool>();

        ChangeTool(ToolType.NORMAL_TOOL);
    }

    public MapObject GetMapObject(int hitX, int hitZ)
    {
        MapObject hitMap;
        mapDic.TryGetValue(hitX + "_" + hitZ, out hitMap);
        return hitMap;
    }

    public void ChangeTool(ToolType type)
    {
        Tool useTool;
        toolDic.TryGetValue(type, out useTool);
        if(useTool == null){
            switch (type)
            {
                case ToolType.NORMAL_TOOL:
                    useTool = new NormalTool();
                    break;
                case ToolType.MOVE_TOOL:
                    useTool = new MoveTool();
                    break;
                case ToolType.ENLARGETOOL:
                    useTool = new EnlargeTool();
                    break;
                default:
                    useTool = new NormalTool();
                    break;
               // case Tool.ToolType.
            }
            useTool.Init(this);
        }

        if (currentTool != null)
        {
            currentTool.Cancel();
        }
        currentTool = useTool;
        currentTool.Active();
    }

    void Update()
    {
        if (currentTool == null)
        {
            return;
        }
        if (TouchUtil.TouchBegin)
        {
            currentTool.OnMouseDown();
            if (currentTool.target)
            {
                startLongTouch = true;
                touchDelay = 0;
            }
        }
        else if(TouchUtil.TouchingNotMove && startLongTouch){
            touchDelay += Time.deltaTime;
            if (touchDelay > 1)
            {
                ChangeTool(ToolType.MOVE_TOOL);
                currentTool.OnMouseDown();
            }
        }
        else if (TouchUtil.TouchMoving)
        {
            currentTool.OnMouseMove();
            touchDelay = 0;
        }
        else if (TouchUtil.TouchEnd)
        {
            currentTool.OnMouseUp();
            touchDelay = 0;
            startLongTouch = false;
        }
        TouchUtil.lastPos = Input.mousePosition;
    }
}
