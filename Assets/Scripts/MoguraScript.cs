using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class MoguraScript : MonoBehaviour /*IPointerClickHandler*/
{
    private GameControllerScript gameController;
    void Start()
    {
        gameController = GameObject.FindWithTag("GameController").GetComponent<GameControllerScript>();
    }


    void Update()
    {
        Destroy(gameObject, 4f);
    }

    public void OnClicked()
    {
        Destroy(gameObject);
        gameController.AddScore(10);
    }

    public void DestroyAll()
    {
        Destroy(gameObject);
    }
}
