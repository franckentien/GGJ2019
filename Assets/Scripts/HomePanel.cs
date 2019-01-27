using System.Collections;
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
    /// The info panel.
    /// </summary>
    public InfoPanel InfoPanel;

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
        this.ValuesPanel.UpdateEnergie(this.GameManager.energieMax / 2);
    }

    /// <summary>
    /// The hover back home button.
    /// </summary>
    public void hoverBackHomeButton()
    {
        this.valEnergieSliderBeforeHover = this.GameManager.energieDispo;
        this.ValuesPanel.UpdateEnergieHover(this.GameManager.energieDispo + (this.GameManager.energieMax / 2));
    }

    /// <summary>
    /// The unhover back home button.
    /// </summary>
    public void UnhoverBackHomeButton()
    {
        this.ValuesPanel.UpdateEnergieHover(this.valEnergieSliderBeforeHover);
    }

}
