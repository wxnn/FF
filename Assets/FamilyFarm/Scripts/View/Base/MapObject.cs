using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LitJson;
//using FluorineFx;
using UnityEngine;

public class MapObject:Base
{
    public static T Create<T>(Hashtable data) where T : MapObject
    {
        GameObject go = new GameObject();
        T obj = go.AddComponent<T>();
        obj.init(data);
        return obj;
    }

    private JsonData conf;
    private GameObject model;
    private bool select = false;
    public int sizeX;
    public int sizeZ;
    private GameObject moveToolUIPrefab;
    private GameObject moveUI;
    private GameObject canvas3D;

    public void init(Hashtable data)
    {
        JsonData conf = ResManager.GetItemConf((string)data["itemid"]);
        this.name = (string)conf["name"];
        sizeX = (int)conf["size_x"];
        sizeZ = (int)conf["size_y"];
        object flipped = 0;
        if (data.ContainsKey("flipped"))
        {
            flipped = data["flipped"];
            if (Convert.ToInt16(flipped) == 1)
            {
                sizeZ = (int)conf["size_x"];
                sizeX = (int)conf["size_y"];
            }
        }
        int sizeY = Math.Min(sizeX, sizeZ);
        this.transform.localScale = new Vector3((float)sizeX, (float)sizeY, (float)sizeZ);
        this.transform.position = new Vector3(Convert.ToSingle(data["x"]), 0, Convert.ToSingle(data["y"]));
        createModel((string)conf["url"]);
    }

    private void createModel(string url)
    {
        GameObject prefab = (GameObject)Resources.Load("model/"+url);
        model = (GameObject)Instantiate(prefab);
        model.transform.SetParent(this.transform,false);
        model.name = "model";
    }

    public bool isSelect
    {
        set
        {
            if (select)
            {
                return;
            }
            select = value;
            Vector3 pos = model.transform.position;
            if (value)
            {
                pos.y = 5;
                AddMoveToolUI();
            }
            else
            {
                pos.y = 0;
                RemoveMoveToolUI();
            }
            model.transform.position = pos;
        }
        get{
            return select;
        }
    }

    private void AddMoveToolUI()
    {
        if(moveToolUIPrefab == null)
        {
            moveToolUIPrefab = (GameObject) Resources.Load("MoveToolUI");
        }
        moveUI = (GameObject)Instantiate(moveToolUIPrefab);
        canvas3D = GameObject.Find("Canvas3D");
        moveUI.transform.SetParent(canvas3D.transform);
        moveUI.transform.localRotation = new Quaternion(0, 45, 0, 0);
        moveUI.transform.position = this.transform.position;
    }

    private void RemoveMoveToolUI()
    {
        if (moveUI)
        {
            Destroy(moveUI.gameObject);
        }
    }
}
