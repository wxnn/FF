using UnityEngine;
using System.Collections;

public class EnlargeTool:Tool
{
    public override void OnMouseDown()
    {
        //base.OnMouseDown();
    }

    public override void OnMouseUp()
    {
        base.OnMouseUp();
        AppFacade.Instance.SendMessageCommand(NotiConst.RETURN_TO_MAP);
    }
}
