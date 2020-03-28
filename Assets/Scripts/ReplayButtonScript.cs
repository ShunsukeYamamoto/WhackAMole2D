using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReplayButtonScript : MonoBehaviour
{
    void Start()
    {
        gameObject.SetActive(false);
    }

    
    public void OnClicked()
    {
        SceneManager.LoadScene("GameScene");
    }
}
