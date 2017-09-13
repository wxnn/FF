using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using LuaInterface;
using LuaFramework;
//using FluorineFx;


public class GameView:View,IState
{
    
    GameObject grass;
    GameObject uiRoot;
    public LayerMask mapLayerMask;
    
    public Camera mainCamera;
    private CameraController cameraController;
    public Camera mapCamera;
    private bool clicked = false;
    private GameUI gameUI;
    private Map map;
    List<string> MessageList
    {
        get
        {
            return new List<string>()
            {
                NotiConst.SHOW_PANEL,
                NotiConst.HIDE_PANEL,
                NotiConst.MOVE_TO_TARGET_MAPOBJECT,
                NotiConst.RETURN_TO_MAP,
                NotiConst.ACTIVE_DRAG_SCREEN,
            };
        }
    }

    public void OpenState()
    {
        Debug.Log("GameViewShow");
        InitView();
    }

    public void CloseState()
    {

    }

    void Awake()
    {
        RemoveMessage(this, MessageList);
        RegisterMessage(this, MessageList);

        GameObject mapObj = GameObject.Find("Root/Map");
        map = mapObj.AddComponent<Map>();
        grass = GameObject.Find("Root/Grass");
        uiRoot = GameObject.Find("UICanvas/UIRoot");
        mapCamera.enabled = false;
        mapCamera.transform.position = mainCamera.transform.position;
        mapCamera.transform.rotation = mainCamera.transform.rotation;
        cameraController = mainCamera.GetComponent<CameraController>();
        MeshRenderer render = grass.GetComponent<MeshRenderer>();
        render.material.SetTextureScale("_MainTex", new Vector2(grass.transform.localScale.x/2, grass.transform.localScale.z/2));
    }

    public override void OnMessage(IMessage message)
    {
        string name = message.Name;
        switch (name)
        {
            case NotiConst.SHOW_PANEL:
                this.enabled = false;
                this.gameUI.enabled = false;
                this.cameraController.enabled = false;
                this.map.enabled = false;
                break;
            case NotiConst.HIDE_PANEL:
                if (PanelManager.havePanelOpened() == false)
                {
                    this.enabled = true;
                    this.gameUI.enabled = true;
                    this.cameraController.enabled = true;
                    this.map.enabled = true;
                }               
                break;
            case NotiConst.MOVE_TO_TARGET_MAPOBJECT:
                MoveToTargetMapObj((MapObject) message.Body);
                break;
            case NotiConst.RETURN_TO_MAP:
                ReturnToMap();
                break;
            case NotiConst.ACTIVE_DRAG_SCREEN:
                cameraController.canDragScreen = (bool)message.Body;
                break;
        }
    }
    public void InitView()
    {
        LuaManager.InitStart();
        //LuaManager.DoFile("Logic/Game");  
        //Util.CallMethod("Game", "OnInitOK");     //初始化完成
        InitUI();
        map.InitMap();
    }
    private void InitUI()
    {
        GameObject gameUIPrefab =(GameObject) Resources.Load("GameUI");
        GameObject gameUIView = (GameObject) Instantiate(gameUIPrefab, uiRoot.transform,false);
        gameUI = gameUIView.AddComponent<GameUI>();
    }

    protected void MoveToTargetMapObj(MapObject hitMap)
    {
        mapCamera.enabled = true;
        mainCamera.enabled = false;
        Vector3 mapPos = hitMap.transform.position;
        Vector3 mapCam = mapCamera.transform.position;
        mapCam.x = mapPos.x + 100;
        mapCam.y = 68;
        mapCam.z = mapPos.z + 100;
        mapCamera.transform.position = mapCam;
        mapCamera.orthographicSize = Math.Max(hitMap.sizeX, hitMap.sizeZ) + 2;
        gameUI.gameObject.SetActive(false);
        facade.SendMessageCommand(NotiConst.USE_TOOL, ToolType.ENLARGETOOL);
    }

    protected void ReturnToMap()
    {
        mapCamera.enabled = false;
        mainCamera.enabled = true;
        gameUI.gameObject.SetActive(true);
        facade.SendMessageCommand(NotiConst.USE_TOOL, ToolType.NORMAL_TOOL);
    }

    void Update()
    {
        
    }
}

