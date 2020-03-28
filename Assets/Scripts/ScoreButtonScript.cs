using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreButtonScript : MonoBehaviour
{

    public void OnClicked()
    {
        SceneManager.LoadScene("ScoreScene");
    }
}
