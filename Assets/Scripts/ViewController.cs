using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 控制摄像机
public class ViewController : MonoBehaviour {
	
	public float translateSpeed = 25; // 视角移动速度
	public float scaleSpeed = 500; // 视角缩放速度
    public float sensitivityX = 1f;
    public float sensitivityY = 1f;

    void Update () 
	{
		// 方向按键控制视角前后左右移动
		float h = Input.GetAxis("Horizontal") * translateSpeed;
		float v = Input.GetAxis("Vertical") * translateSpeed;

		// 鼠标滑轮控制视角的远近
		float mouse = Input.GetAxis("Mouse ScrollWheel") * scaleSpeed;

        if ( h * v > 0)
        {
            //如果有兩個按鍵
            transform.Rotate(0, h * sensitivityY, -v * sensitivityX);
        }
        else
        {
            // 视角按照世界坐标系统，这样不受自身旋转影响
            transform.Translate(new Vector3(h, mouse, v) * Time.deltaTime, Space.World);
        }

        //单指控制摄像头旋转  
        if (Input.touchCount == 1)
        {
            float rotationX = Input.GetAxis("Mouse X") * sensitivityX;
            float rotationY = Input.GetAxis("Mouse Y") * sensitivityY;
            transform.Rotate(-rotationY, rotationX, 0);

        }

        //双指控制摄像头移动  
        if (Input.touchCount == 2)
        {
            transform.position += transform.forward * Time.deltaTime * 20;
        }
    }



}
