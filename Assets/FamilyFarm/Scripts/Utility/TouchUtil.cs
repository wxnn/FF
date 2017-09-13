using UnityEngine;
using System.Collections;

public class TouchUtil 
{
    public static Vector3 lastPos;
    public static bool TouchBegin
    {
        get
        {
            if (Input.GetMouseButtonDown(0) && !Application.isMobilePlatform)
            {
                lastPos = Input.mousePosition;
                return true;
            }
            else if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Began)
            {
                return true;
            }
            return false;
        }
    }

    public static bool TouchEnd
    {
        get
        {
            if (Input.GetMouseButtonUp(0) && !Application.isMobilePlatform)
            {
                return true;
            }
            else if (Input.touchCount  == 1 && Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                return true;
            }
            return false;
        }

    }
   
    public static bool TouchMoving
    {
        get
        {
            if (Input.GetMouseButton(0) && !Application.isMobilePlatform)
            {
                return true;
            }
            else if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                return true;
            }
            return false;
        }
    }

    public static bool TouchingNotMove
    {
        get
        {
            if (Input.GetMouseButton(0) && !Application.isMobilePlatform)
            {
                return Input.mousePosition == lastPos;
            }
            else if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Stationary)
            {
                return true;
            }
            return false;
        }
    }
}
