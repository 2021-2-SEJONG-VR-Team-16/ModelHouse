using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    public Camera getCamera;

    private RaycastHit hit;

    public string someObjectName;
    public static string objectName;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = getCamera.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit))
                someObjectName = hit.collider.gameObject.name;
        }
        if(Input.GetMouseButtonUp(0))
        {

            Ray ray = getCamera.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit))
                if(someObjectName == hit.collider.gameObject.name)
                    objectName = someObjectName;
                else
                    objectName = null;
        }
    }
}
