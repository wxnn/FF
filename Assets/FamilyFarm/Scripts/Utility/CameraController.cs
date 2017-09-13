using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class CameraController:MonoBehaviour
{
    public Camera mainCamera;
    private int maxSize = 70;
    private int minSize = 25;

    private Vector2 oldPosition1 = new Vector2(0,0);
    private Vector2 oldPosition2 = new Vector2(0, 0);

    private bool lastTwoTouch = false;
    public bool canDragScreen = true;

    void Update()
    {
        Vector3 pos = mainCamera.transform.position;

        if(TouchUtil.TouchMoving && canDragScreen)
        {
            if (lastTwoTouch)
            {
                return;
            }
            float mx = Input.GetAxis("Mouse X");
            float my = Input.GetAxis("Mouse Y");
            pos.x += mx*0.8f;
            pos.z -= mx*0.8f;
            pos.y -= my*0.8f;
        }else if(Input.touchCount > 1)
        {
            lastTwoTouch = true;
            if(Input.GetTouch(0).phase == TouchPhase.Moved && Input.GetTouch(1).phase == TouchPhase.Moved)
            {
                if (isEnlarge(oldPosition1,oldPosition2,Input.GetTouch(0).position, Input.GetTouch(1).position))
                {
                    mainCamera.orthographicSize -= 0.8f;
                    mainCamera.orthographicSize = Math.Max(mainCamera.orthographicSize, 25);
                }else
                {  
                    mainCamera.orthographicSize += 0.8f;
                    mainCamera.orthographicSize = Math.Min(mainCamera.orthographicSize, 70);
                }      
            }
            oldPosition1 = Input.GetTouch(0).position;
            oldPosition2 = Input.GetTouch(1).position;
        }else
        {
            lastTwoTouch = false;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            mainCamera.orthographicSize++;
            mainCamera.orthographicSize = Math.Min(mainCamera.orthographicSize, 70);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            mainCamera.orthographicSize--;
            mainCamera.orthographicSize = Math.Max(mainCamera.orthographicSize, 25);
        }

        pos.x = Math.Max(pos.x, 190 - (maxSize - mainCamera.orthographicSize));
        pos.x = Math.Min(pos.x, 190 + (maxSize - mainCamera.orthographicSize));

        pos.z = Math.Max(pos.z, 190 - (maxSize - mainCamera.orthographicSize));
        pos.z = Math.Min(pos.z, 190 + (maxSize - mainCamera.orthographicSize));

        pos.y = Math.Max(pos.y, mainCamera.orthographicSize + 20);
        pos.y = Math.Min(pos.y, 160 - mainCamera.orthographicSize);
        mainCamera.transform.position = pos;
    }

    private bool isEnlarge(Vector2 oP1, Vector2 oP2, Vector2 nP1, Vector2 nP2)
    {
        // 函数传入上一次触摸两点的位置与本次触摸两点的位置计算出用户的手势  
        float leng1 = Mathf.Sqrt((oP1.x - oP2.x) * (oP1.x - oP2.x) + (oP1.y - oP2.y) * (oP1.y - oP2.y));
        float leng2 = Mathf.Sqrt((nP1.x - nP2.x) * (nP1.x - nP2.x) + (nP1.y - nP2.y) * (nP1.y - nP2.y));

        if (leng1 < leng2)
        {
            // 放大手势  
            return true;
        }
        else
        {
            // 缩小手势  
            return false;
        }
    }
}
