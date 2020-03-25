using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class MoguraScript : MonoBehaviour /*IPointerClickHandler*/
{
    void Start()
    {
        
    }


    void Update()
    {
        Destroy(gameObject, 4f);
        
    }

    public void OnClicked()
    {
        Destroy(gameObject);
    }
}
