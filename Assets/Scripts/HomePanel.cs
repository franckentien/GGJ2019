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
    /// The energie slider.
    /// </summary>
    public Slider EnergieSlider;

    /// <summary>
    /// The game manager.
    /// </summary>
    public GameManager GameManager;

    /// <summary>
    /// The values panel.
    /// </summary>
    public ValuesPanel valuesPanel;

    /// <summary>
    /// The val energie slider before hover.
    /// </summary>
    public int valEnergieSliderBeforeHover;

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
        this.valuesPanel.UpdateEnergie(5);
    }

    /// <summary>
    /// The hover back home button.
    /// </summary>
    public void hoverBackHomeButton()
    {

        this.valEnergieSliderBeforeHover = this.GameManager.energieDispo;
        this.ValuesPanel.UpdateEnergieWithHover(this.GameManager.energieMax);
    }

    /// <summary>
    /// The unhover back home button.
    /// </summary>
    public void UnhoverBackHomeButton()
    {
        this.ValuesPanel.UpdateEnergieWithUnHover(this.valEnergieSliderBeforeHover);
    }

}
