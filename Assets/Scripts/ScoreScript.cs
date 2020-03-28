using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    [SerializeField]
    RectTransform score = null;
    void Start()
    {
        var scoreArray = PlayerPrefs.GetString("scores").Split(',');
        var dateArray = PlayerPrefs.GetString("dates").Split(',');

        for (int i = 0; i < scoreArray.Length; i++)
        {
            var date = System.DateTime.FromBinary(System.Convert.ToInt64(dateArray[i]));
            var year = date.Year;
            var month = date.Month;
            var day = date.Day;
            var hour = date.Hour;
            var minute = date.Minute;

            var item = GameObject.Instantiate(score) as RectTransform;
            item.SetParent(transform, false);

            var text = item.GetComponentInChildren<Text>();
            text.text = $"{i+1}、 {year}/{month}/{day} {hour}:{minute}  {scoreArray[i]}点";
        }
    }

}
