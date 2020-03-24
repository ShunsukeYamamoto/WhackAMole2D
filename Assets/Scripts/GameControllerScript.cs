using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScript : MonoBehaviour
{
    public GameObject mogura;
    public GameObject hole;
    float space = 4f;

    // Start is called before the first frame update
    void Start()
    {
        for(int x = 0; x < 3; x++)
        {
            for(int y = 0; y < 2; y++)
            {
                Instantiate(
                    hole,
                    new Vector3(-4f + space * x, -3.3f * y, 0f),
                    transform.rotation);

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
