using UnityEngine;
using System.Collections;

public class NormalTool :Tool
{

    public override void OnMouseUp()
    {
        base.OnMouseUp();
        if (currentMapObj != null)
        {
            AppFacade.Instance.SendMessageCommand(NotiConst.MOVE_TO_TARGET_MAPOBJECT, currentMapObj);
        }
    }
}
