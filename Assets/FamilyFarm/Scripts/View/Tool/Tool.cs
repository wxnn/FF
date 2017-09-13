using UnityEngine;
using System.Collections;
using System;

public enum ToolType{
        NORMAL_TOOL,
        MOVE_TOOL,
        HARVET_TOOL,
        PLANT_TOOL,
        ENLARGETOOL,
    }

public class Tool
{
    protected Map map;
    protected MapObject currentMapObj;
    

    public virtual void Init(Map _map)
    {
        map = _map;
        Active();
    }

    public virtual void Active()
    {

    }

    public MapObject target
    {
        set
        {
            currentMapObj = value;
        }
        get
        {
            return currentMapObj;
        }
    }


    public virtual void OnMouseDown(){
        Vector3 clickPos = Input.mousePosition;
        Ray ray = Camera.main.ScreenPointToRay(clickPos);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 1000))
        {
            //Debug.Log(hit.collider.gameObject.name + "--" + hit.point.x + "--" + hit.point.z);
            int hitX = (int)Math.Round(hit.point.x);
            int hitZ = (int)Math.Round(hit.point.z);
            target = map.GetMapObject(hitX, hitZ);          
        }
    }

    public virtual void OnMouseUp()
    {
    }

    public virtual void OnMouseMove()
    {

    }

    public virtual void Cancel()
    {

    }
}
