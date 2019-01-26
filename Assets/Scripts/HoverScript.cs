using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HoverScript : MonoBehaviour
{

    public ValuesPanel ValuesPanel;

    public Slider EnergieSlider;

    public int valEnergieSliderBeforeHover;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    /// <summary>
    /// The hover back home button.
    /// </summary>
    public void hoverBackHomeButton()
    {
        
        this.valEnergieSliderBeforeHover = this.ValuesPanel.energieDispo;
        this.ValuesPanel.UpdateEnergieWithHover(10);
    }

    /// <summary>
    /// The unhover back home button.
    /// </summary>
    public void UnhoverBackHomeButton()
    {
        this.ValuesPanel.UpdateEnergieWithUnHover(this.valEnergieSliderBeforeHover);
    }

    /// <summary>
    /// The pressed home button.
    /// </summary>
    public void PressedHomeButton(int newVal)
    {
        this.valEnergieSliderBeforeHover = newVal;
    }
}
