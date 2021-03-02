using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public Text textBox;
    public float timeStart = 30;

    void Start ()
    {
        textBox.text = timeStart.ToString();
    }

    void Update ()
    {
        timeStart -= Time.deltaTime;
        textBox.text = Mathf.Round(timeStart).ToString();
    }
}
