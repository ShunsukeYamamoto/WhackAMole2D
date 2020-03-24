using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleScript : MonoBehaviour
{
    public GameObject mogura;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(
            mogura,
            new Vector3(transform.position.x, transform.position.y + 1,0f),
            transform.rotation
            );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
