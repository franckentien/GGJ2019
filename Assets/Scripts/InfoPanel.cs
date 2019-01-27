using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The info panel.
/// </summary>
public class InfoPanel : MonoBehaviour
{
    /// <summary>
    /// The date time.
    /// </summary>
    public DateTime dateTime;

    /// <summary>
    /// The date text.
    /// </summary>
    public Text DateText;

    /// <summary>
    /// The log story text.
    /// </summary>
    public Text LogStoryText;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {
        this.dateTime = new DateTime(2019,01,27);
        this.DateText.text = this.dateTime.ToString("D");


        this.LogStoryText.text = "In this game you play an Asexual character who try to accept his own sexuality orientation.\n"
                                 + "Your Goal is to make some activities to increase your Self-confidence";
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {

    }

    /// <summary>
    /// The update date to next day.
    /// </summary>
    public void UpdateDateToNextDay()
    {
        Debug.Log(this.dateTime.ToString("D"));
        this.dateTime = this.dateTime.AddDays(1);
        Debug.Log(this.dateTime.ToString("D"));
        this.DateText.text = this.dateTime.ToString("D");
    }

    /// <summary>
    /// The update text log content.
    /// </summary>
    /// <param name="textContent">
    /// The text content.
    /// </param>
    public void UpdateTextLogContent(string textContent)
    {
        this.LogStoryText.text = textContent;
    }
}
