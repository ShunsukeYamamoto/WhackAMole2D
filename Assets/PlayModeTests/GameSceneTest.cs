using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Tests
{
    public class GameSceneTest
    {
        GameObject[] holes;
        GameObject[] mogura;
        Text scoreText;


        [SetUp]
        public void SetUp()
        {
            SceneManager.LoadScene("GameScene");
            mogura = GameObject.FindGameObjectsWithTag("Mogura");
        }

        [Test]
        public void CountHoles()
        {
            holes = GameObject.FindGameObjectsWithTag("hole");
            Assert.That(holes.Length, Is.EqualTo(6));
        }

        [Test]
        public void CountMogura()
        {
            Assert.That(mogura.Length, Is.EqualTo(1));
        }


        [Test]
        public void InitScoreText()
        {
            scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
            Debug.Log(scoreText.text);
            Assert.That(scoreText.text, Is.EqualTo("Score:0"));
        }

        [Test]
        public void AddScoreText()
        {
            GameObject mogura1 = GameObject.FindGameObjectWithTag("Mogura");
            mogura1.GetComponent<MoguraScript>().OnClicked();
        }
    }
}
