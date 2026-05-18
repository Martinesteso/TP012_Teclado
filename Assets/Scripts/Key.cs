using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{

    bool pressed = false;
    float pressOff = 1f;
    void OnMouseDown()
    {
        Debug.Log("Click en " + gameObject.name);
        transform.Translate(0,-1,0);
    }

    void OnMouseExist(){


    }

    void OnMouseUp(){
        transform.Translate(0,pressOff,0);
    }
}
