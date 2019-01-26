﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The home panel.
/// </summary>
public class HomePanel : MonoBehaviour
{
    /// <summary>
    /// The values panel.
    /// </summary>
    public ValuesPanel ValuesPanel;

    /// <summary>
    /// The game manager.
    /// </summary>
    public GameManager GameManager;

    /// <summary>
    /// The val energie slider before hover.
    /// </summary>
    public int valEnergieSliderBeforeHover;

    public int valMotivationSliderBeforeHover;

    public int valDysphoriaSliderBeforeHover;

    public int valWorkSliderBeforeHover;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start () {
		
	}

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update () {
		
	}

    /// <summary>
    /// The back to home button click.
    /// </summary>
    public void backToHomeButtonClick()
    {
        this.valEnergieSliderBeforeHover = this.GameManager.energieDispo;
        this.valWorkSliderBeforeHover = this.GameManager.workDispo;
        this.ValuesPanel.UpdateEnergie(5);
        this.ValuesPanel.UpdateWork(-1);
    }

    /// <summary>
    /// The hover back home button.
    /// </summary>
    public void hoverBackHomeButton()
    {

        this.valEnergieSliderBeforeHover = this.GameManager.energieDispo;
        this.ValuesPanel.UpdateEnergieHover(this.GameManager.energieDispo + 5);

        this.valWorkSliderBeforeHover = this.GameManager.workDispo;
        this.ValuesPanel.UpdateWorkHover(this.GameManager.workDispo - 1);
    }

    /// <summary>
    /// The unhover back home button.
    /// </summary>
    public void UnhoverBackHomeButton()
    {
        this.ValuesPanel.UpdateEnergieHover(this.valEnergieSliderBeforeHover);
        this.ValuesPanel.UpdateWorkHover(this.valWorkSliderBeforeHover);
    }

}
