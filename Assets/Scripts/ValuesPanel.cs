using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The values panel.
/// </summary>
public class ValuesPanel : MonoBehaviour
{
    #region Variable

    /// <summary>
    /// The energie dispo.
    /// </summary>
    public int energieDispo;

    /// <summary>
    /// The energie.
    /// </summary>
    public int energieMax;

    /// <summary>
    /// The motivation.
    /// </summary>
    public int motivationDispo;

    /// <summary>
    /// The motivation max.
    /// </summary>
    public int motivationMax;

    /// <summary>
    /// The disphoria.
    /// </summary>
    public int dysphoriaDispo;

    /// <summary>
    /// The dysphoria max.
    /// </summary>
    public int dysphoriaMax;

    /// <summary>
    /// The work.
    /// </summary>
    public int workDispo;

    public int workMax;

    /// <summary>
    /// The purplecolor.
    /// </summary>
    public Color Purplecolor;

    /// <summary>
    /// The green color.
    /// </summary>
    public Color GreenColor;

    /// <summary>
    /// The red color.
    /// </summary>
    public Color RedColor;

    #endregion

    #region SliderObject

    /// <summary>
    /// The slider energie.
    /// </summary>
    public Slider sliderEnergie;

    /// <summary>
    /// The value slider energie.
    /// </summary>
    public Text valueSliderEnergieText;

    public Image EnergieSliderImage;

    /// <summary>
    /// The slider motivation.
    /// </summary>
    public Slider sliderMotivation;

    /// <summary>
    /// The value slider motivation text.
    /// </summary>
    public Text valueSliderMotivationText;

    /// <summary>
    /// The slider dysphoria.
    /// </summary>
    public Slider sliderDysphoria;

    /// <summary>
    /// The value slider dysphoria text.
    /// </summary>
    public Text valueSliderDysphoriaText;

    /// <summary>
    /// The slider dysphoria.
    /// </summary>
    public Slider sliderWork;

    /// <summary>
    /// The value slider work text.
    /// </summary>
    public Text valueSliderWorkText;

    #endregion

    /// <summary>
    /// The hover script.
    /// </summary>
    public HoverScript HoverScript;

    // Use this for initialization
    private void Start ()
    {
        this.valueSliderEnergieText.text = this.energieDispo.ToString() + " / " + this.energieMax + "\t";
        this.sliderEnergie.value = (float)this.energieDispo / this.energieMax;
        
        this.valueSliderMotivationText.text = this.motivationDispo.ToString() + " / " + this.motivationMax + "\t";
        this.sliderMotivation.value = (float)this.motivationDispo / this.motivationMax;

        this.valueSliderDysphoriaText.text = this.dysphoriaDispo.ToString() + " / " + this.dysphoriaMax + "\t";
        this.sliderDysphoria.value = (float)this.dysphoriaDispo / this.dysphoriaMax;

        this.valueSliderWorkText.text = this.workDispo.ToString() + " / " + this.workMax + "\t";
        this.sliderWork.value = (float)this.workDispo / this.workMax;

    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    private void Update()
    {
    }

    /// <summary>
    /// The update energie.
    /// </summary>
    /// <param name="amount">
    /// The amount.
    /// </param>
    public void UpdateEnergie(int amount)
    {
        this.energieDispo += amount;

        if (this.energieDispo > this.energieMax)
        {
            this.energieDispo = this.energieMax;
        }
        else if (this.energieDispo < 0)
        {
            this.energieDispo = 0;
        }
        
        this.HoverScript.PressedHomeButton(this.energieDispo);
        this.valueSliderEnergieText.text = this.energieDispo.ToString() + " / " + this.energieMax + "\t";
        this.sliderEnergie.value = (float)this.energieDispo / this.energieMax;

    }

    public void UpdateEnergieWithHover(int value)
    {
        this.energieDispo = value;
        this.valueSliderEnergieText.text = this.energieDispo.ToString() + " / " + this.energieMax + "\t";
        this.sliderEnergie.value = (float)this.energieDispo / this.energieMax;

        this.EnergieSliderImage.color = this.GreenColor;
    }

    public void UpdateEnergieWithUnHover(int value)
    {
        this.energieDispo = value;
        this.valueSliderEnergieText.text = this.energieDispo.ToString() + " / " + this.energieMax + "\t";
        this.sliderEnergie.value = (float)this.energieDispo / this.energieMax;

        this.EnergieSliderImage.color = this.Purplecolor;

    }

    /// <summary>
    /// The update motivation.
    /// </summary>
    /// <param name="amount">
    /// The amount.
    /// </param>
    public void UpdateMotivation(int amount)
    {
        this.motivationDispo += amount;

        if (this.motivationDispo > this.motivationMax)
        {
            this.motivationDispo = this.motivationMax;
        }
        else if (this.motivationDispo < 0)
        {
            this.motivationDispo = 0;
        }

        this.valueSliderMotivationText.text = this.motivationDispo.ToString() + " / " + this.motivationMax + "\t";
        this.sliderMotivation.value = (float)this.motivationDispo / this.motivationMax;
    }

    /// <summary>
    /// The update dysphoria.
    /// </summary>
    /// <param name="amount">
    /// The amount.
    /// </param>
    public void UpdateDysphoria(int amount)
    {
        this.dysphoriaDispo += amount;

        if (this.dysphoriaDispo > this.dysphoriaMax)
        {
            this.dysphoriaDispo = this.dysphoriaMax;
        }
        else if (this.dysphoriaDispo < 0)
        {
            this.dysphoriaDispo = 0;
        }

        this.valueSliderDysphoriaText.text = this.dysphoriaDispo.ToString() + " / " + this.dysphoriaMax + "\t";
        this.sliderDysphoria.value = (float)this.dysphoriaDispo / this.dysphoriaMax;

    }

    /// <summary>
    /// The update work.
    /// </summary>
    /// <param name="amount">
    /// The amount.
    /// </param>
    public void UpdateWork(int amount)
    {
        this.workDispo += amount;

        if (this.workDispo > this.workMax)
        {
            this.workDispo = this.workMax;
        }
        else if (this.workDispo < 0)
        {
            this.workDispo = 0;
        }

        this.valueSliderWorkText.text = this.workDispo.ToString() + " / " + this.workMax + "\t";
        this.sliderWork.value = (float)this.workDispo / this.workMax;

    }

}
