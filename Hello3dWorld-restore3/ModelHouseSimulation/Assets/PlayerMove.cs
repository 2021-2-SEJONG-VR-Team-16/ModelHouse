using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    void Update() {
        Vector3 vec = new Vector3(
            Input.GetAxis("Horizontal")*Time.deltaTime*5,
            0,
            Input.GetAxis("Vertical")*Time.deltaTime*5);

        transform.Translate(vec);
    }
}
