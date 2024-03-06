using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow_Phone : MonoBehaviour
{
    private Vector2 direction;
    private Touch touch;
    private Vector2 touchCurrent;
    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            touchCurrent = Camera.main.ScreenToWorldPoint(touch.position);
            if (touchCurrent.y < 8)
            {
                MoveCameraFollowTouch();
            }
        }       
    }

    private void MoveCameraFollowTouch()
    {
        switch (touch.phase)
        {
            case TouchPhase.Began:
                direction = touchCurrent;
                break;
            case TouchPhase.Moved:
                if (touchCurrent.x > direction.x)
                {
                    transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x + 0.1f,
                        transform.position.y,
                        transform.position.z), 20);
                }else if (touchCurrent.x < direction.x)
                {
                    transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x - 0.1f,
                        transform.position.y,
                        transform.position.z), 20);
                }

                if (transform.position.x < 0)
                {
                    transform.position = new Vector3(0, transform.position.y, transform.position.z);
                }else if (transform.position.x > 11.42f)
                {
                    transform.position = new Vector3(11.42f, transform.position.y, transform.position.z);
                }
                
                break;
            case TouchPhase.Ended:
                transform.position = transform.position;
                break;
        }
    }
}
