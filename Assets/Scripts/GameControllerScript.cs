using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class GameControllerScript : MonoBehaviour
{
    public GameObject mogura;
    public GameObject hole;
    float space = 4f;
    private int score;
    public Text scoreText;

    private float time;
    public Text timeText;

    void Start()
    {
        score = 0;
        time = 5f;
        UpdateScoreText();


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
        time -= Time.deltaTime;
        timeText.text = $"{(int)time+1 }";
        if (time < 0)
        {
            StopCoroutine("SpawnMogura");
        }
    }

    public void AddScore(int scoreAdd)
    {
        score += scoreAdd;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score:" + score;
    }
}
