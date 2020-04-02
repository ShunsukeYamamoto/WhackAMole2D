using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

namespace Tests
{
    public class GameSceneTest
    {
        GameObject[] holes;
        GameObject[] mogura;

        [SetUp]
        public void SetUp()
        {
            SceneManager.LoadScene("GameScene");
        }

        [TearDown]
        public void Teardown()
        {
            
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
            mogura = GameObject.FindGameObjectsWithTag("Mogura");
            Assert.That(mogura.Length, Is.EqualTo(1));
        }

        [UnityTest]
        public IEnumerator CountMogura1()
        {
            mogura = GameObject.FindGameObjectsWithTag("Mogura");
            yield return null;
            Assert.IsTrue(mogura.Length <= 1);

        }



    }
}
