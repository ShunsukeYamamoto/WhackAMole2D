using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoguraScript : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Destroy(gameObject);
        }
        Destroy(gameObject,4f);   
    }
}
