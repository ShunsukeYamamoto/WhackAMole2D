﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoguraScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("SpawnMogura");
    }

    void OnMouseDown()
    {
        Destroy(this.gameObject);
    }
}
