using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class GameControllerScript : MonoBehaviour
{
    public GameObject mogura;
    public GameObject hole;
    public int totalscore;
    float space = 4f;

    void Start()
    {
        mogura.AddComponent<EventTrigger>();
        EventTrigger trigger = mogura.GetComponent<EventTrigger>();
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerDown;
        entry.callback.AddListener((eventDate) => { Debug.Log("dddd"); });
        trigger.triggers.Add(entry);

        for (int x = 0; x < 3; x++)
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

    

    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

        //    if (hit.collider != null)
        //    {
        //        if (hit.collider.gameObject.name == "mogura") { Destroy(gameObject); }
        //    }
        //}
    }
}
