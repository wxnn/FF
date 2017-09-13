using UnityEngine;
using System.Collections;
using System;

public class MoveTool:Tool
{

    public override void Active()
    {
        base.Active();
        AppFacade.Instance.SendMessageCommand(NotiConst.ACTIVE_DRAG_SCREEN, false);
    }
    public override void OnMouseDown()
    {
        if (target)
        {
            target.isSelect = false;
        }

        base.OnMouseDown();
        if (target)
        {
            target.isSelect = true;
        }
    }

    public override void OnMouseMove()
    {
        base.OnMouseMove();
        if (currentMapObj == null)
        {
            return;
        }
        Vector3 clickPos = Input.mousePosition;
        Ray ray = Camera.main.ScreenPointToRay(clickPos);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 1000))
        {
            //Debug.Log(hit.collider.gameObject.name + "--" + hit.point.x + "--" + hit.point.z);
            int hitX = (int)Math.Round(hit.point.x);
            int hitZ = (int)Math.Round(hit.point.z);
            Vector3 newPos = new Vector3(hitX, currentMapObj.transform.position.y, hitZ);
            target.transform.position = newPos;
        }

        //Vector3 worldPos;
        //Vector3 screenpos = Camera.main.WorldToScreenPoint(target.transform.position);

        //worldPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, screenpos.y, Input.mousePosition.y));

        //target.transform.position = worldPos; 
    }


    public override void Cancel()
    {
        base.Cancel();
        AppFacade.Instance.SendMessageCommand(NotiConst.ACTIVE_DRAG_SCREEN, true);
    }
}
