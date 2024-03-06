using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Vector2 direction;
    private Vector2 mouseCurrent;
    void Update()
    {
        mouseCurrent = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (mouseCurrent.y > 8)
        {
            return;
        }
        if (Input.GetMouseButtonDown(0))
        {
            direction = mouseCurrent;
        }

        if (Input.GetMouseButton(0))
        {
            if (mouseCurrent.x > direction.x)
            {
                transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x + 0.1f,
                    transform.position.y,
                    transform.position.z), 20);
            }else if (mouseCurrent.x < direction.x)
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
        }

        if (Input.GetMouseButtonUp(0))
        {
            transform.position = transform.position;
        }
    }
    
}
