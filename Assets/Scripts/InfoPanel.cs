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
    /// Use this for initialization
    /// </summary>
    void Start()
    {
        this.dateTime = new DateTime(2019,01,01);
        this.dateTime = System.DateTime.Now;
        this.DateText.text = this.dateTime.ToString("D");
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {

    }

    public void UpdateDateToNextDay()
    {
        this.dateTime.AddDays(1);
        this.DateText.text = this.dateTime.ToString("D");
    }
}
