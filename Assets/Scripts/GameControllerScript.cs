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
        time = 0f;
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
        StartCoroutine("SpawnMogura");
    }

    float time;


    IEnumerator SpawnMogura()
    {
        while (true)
        {
            int randomx = Random.Range(0, 3);
            int randomy = Random.Range(0, 2);
            Instantiate(
            mogura,
            new Vector3(-4f + 4 * randomx, -3.3f * randomy + 1, 0f),
            transform.rotation
            );
            yield return new WaitForSeconds(4f);   
        }
    }

    //IEnumerator DeleteMogura()
    //{
    //    Destroy(mogura.gameObject);
    //    Debug.Log("delete");
    //    yield return new WaitForSeconds(4f);
    //}

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > 4f)
        {
            Destroy(mogura.gameObject);
        }
    }
}
