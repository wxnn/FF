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
    private float _height = -1;
    public int upPos = 5;


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
            if (select && value)
            {
                return;
            }
            select = value;
            Vector3 pos = model.transform.position;
            if (value)
            {
                pos.y = upPos;
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

    public float height
    {
        get
        {
            if(_height == -1) { 
                Renderer render = model.GetComponent<Renderer>();
                if(render == null)
                {
                    foreach(Transform child in model.transform)
                    {
                        render = child.GetComponent<Renderer>();
                        _height = Math.Max(_height, render.bounds.size.y);
                    }
                }else
                {
                    _height = render.bounds.size.y;
                }
            }
            return _height;
        }
    }

    private void AddMoveToolUI()
    {
        MoveToolUI.Instance.target = this;
    }

    private void RemoveMoveToolUI()
    {
        MoveToolUI.Instance.target = null;
    }
}
