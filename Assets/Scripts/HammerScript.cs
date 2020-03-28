using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerScript : MonoBehaviour
{
    public AudioSource hammerSE;
    private Vector3 position;
    private Vector3 screenToWorldPointPosition;

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            //UnityEditor.EditorApplication.isPlaying = false;
            Application.Quit();
        }
        position = Input.mousePosition;
        position.x += 30f;
        position.y += 50f;
        position.z = 10f;
        transform.position = Camera.main.ScreenToWorldPoint(position);
        if (Input.GetMouseButtonDown(0))
        {
            transform.Rotate(new Vector3(0f, 0f, 45f));
            hammerSE.Play();
        }

        if (Input.GetMouseButtonUp(0))
        {
            transform.Rotate(new Vector3(0f, 0f, -45f));

        }

    }
}
