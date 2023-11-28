using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimeNow : MonoBehaviour
{
    [SerializeField] private TMP_Text text1;
    float time;
    void Update()
    {
        time += Time.deltaTime;
        TimeSet();
    }

    public void TimeSet()
    {
        text1.text = DateTime.Now.ToString("t");
    }

}
