using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Switch : MonoBehaviour
{
    public GameObject light;

    void Update()
    {
        try{
            if(MouseClick.objectName.Equals("entrance_Light"))
            {
                
            }
            else if(MouseClick.objectName == gameObject.name) {
                if(light.activeInHierarchy)
                {
                    light.SetActive(false);
                }
                else
                {
                    light.SetActive(true);
                }
                MouseClick.objectName = null;
            }
        }catch(Exception ex){
            Debug.Log("Switch : " + ex);
        }
    }
}
