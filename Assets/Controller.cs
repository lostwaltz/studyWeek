using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Controller : MonoBehaviour
{
    Vector2 mouseDelta;
    float curRotX;

    private void Update()
    {
        ApplyLook();
    }
    public void ApplyLook()
    {
        curRotX += mouseDelta.y * 20f * Time.deltaTime;
        curRotX = Mathf.Clamp(curRotX, -75f, 75f);

        transform.eulerAngles = new Vector3(-curRotX, transform.eulerAngles.y , 0);
        transform.eulerAngles += new Vector3(0, mouseDelta.x * 20f * Time.deltaTime, 0f);
    }

    public void MouseDelta(InputAction.CallbackContext context)
    {
        mouseDelta = context.ReadValue<Vector2>();
    }
}
