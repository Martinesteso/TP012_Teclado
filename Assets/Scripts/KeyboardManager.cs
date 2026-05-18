using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardManager : MonoBehaviour
{

    public Key[] keys;

    // Start is called
    //  before the first frame update
    void Start()
    {
        keys = GameObject.FindObjectsOfType<Key>();

    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.Space))
    {
        int i = Random.Range(0, keys.Length);
        Destroy(keys[i].gameObject);
    }
}}
