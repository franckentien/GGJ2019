using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The values panel.
/// </summary>
public class ValuesPanel : MonoBehaviour
{


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

    public HomePanel HomePanel;

    public GameManager GameManager;

    // Use this for initialization
    private void Start ()
    {
        this.valueSliderEnergieText.text = this.GameManager.energieDispo.ToString() + " / " + this.GameManager.energieMax + "\t";
        this.sliderEnergie.value = (float)this.GameManager.energieDispo / this.GameManager.energieMax;
        
        this.valueSliderMotivationText.text = this.GameManager.motivationDispo.ToString() + " / " + this.GameManager.motivationMax + "\t";
        this.sliderMotivation.value = (float)this.GameManager.motivationDispo / this.GameManager.motivationMax;

        this.valueSliderDysphoriaText.text = this.GameManager.dysphoriaDispo.ToString() + " / " + this.GameManager.dysphoriaMax + "\t";
        this.sliderDysphoria.value = (float)this.GameManager.dysphoriaDispo / this.GameManager.dysphoriaMax;

        this.valueSliderWorkText.text = this.GameManager.workDispo.ToString() + " / " + this.GameManager.workMax + "\t";
        this.sliderWork.value = (float)this.GameManager.workDispo / this.GameManager.workMax;

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
        this.GameManager.energieDispo += amount;

        if (this.GameManager.energieDispo > this.GameManager.energieMax)
        {
            this.GameManager.energieDispo = this.GameManager.energieMax;
        }
        else if (this.GameManager.energieDispo < 0)
        {
            this.GameManager.energieDispo = 0;
        }
        
        this.valueSliderEnergieText.text = this.GameManager.energieDispo.ToString() + " / " + this.GameManager.energieMax + "\t";
        this.sliderEnergie.value = (float)this.GameManager.energieDispo / this.GameManager.energieMax;

    }

    public void UpdateEnergieWithHover(int value)
    {
        this.GameManager.energieDispo = value;
        this.valueSliderEnergieText.text = this.GameManager.energieDispo.ToString() + " / " + this.GameManager.energieMax + "\t";
        this.sliderEnergie.value = (float)this.GameManager.energieDispo / this.GameManager.energieMax;

        this.EnergieSliderImage.color = this.GameManager.GreenColor;
    }

    public void UpdateEnergieWithUnHover(int value)
    {
        this.GameManager.energieDispo = value;
        this.valueSliderEnergieText.text = this.GameManager.energieDispo.ToString() + " / " + this.GameManager.energieMax + "\t";
        this.sliderEnergie.value = (float)this.GameManager.energieDispo / this.GameManager.energieMax;

        this.EnergieSliderImage.color = this.GameManager.Purplecolor;

    }

    /// <summary>
    /// The update motivation.
    /// </summary>
    /// <param name="amount">
    /// The amount.
    /// </param>
    public void UpdateMotivation(int amount)
    {
        this.GameManager.motivationDispo += amount;

        if (this.GameManager.motivationDispo > this.GameManager.motivationMax)
        {
            this.GameManager.motivationDispo = this.GameManager.motivationMax;
        }
        else if (this.GameManager.motivationDispo < 0)
        {
            this.GameManager.motivationDispo = 0;
        }

        this.valueSliderMotivationText.text = this.GameManager.motivationDispo.ToString() + " / " + this.GameManager.motivationMax + "\t";
        this.sliderMotivation.value = (float)this.GameManager.motivationDispo / this.GameManager.motivationMax;
    }

    /// <summary>
    /// The update dysphoria.
    /// </summary>
    /// <param name="amount">
    /// The amount.
    /// </param>
    public void UpdateDysphoria(int amount)
    {
        this.GameManager.dysphoriaDispo += amount;

        if (this.GameManager.dysphoriaDispo > this.GameManager.dysphoriaMax)
        {
            this.GameManager.dysphoriaDispo = this.GameManager.dysphoriaMax;
        }
        else if (this.GameManager.dysphoriaDispo < 0)
        {
            this.GameManager.dysphoriaDispo = 0;
        }

        this.valueSliderDysphoriaText.text = this.GameManager.dysphoriaDispo.ToString() + " / " + this.GameManager.dysphoriaMax + "\t";
        this.sliderDysphoria.value = (float)this.GameManager.dysphoriaDispo / this.GameManager.dysphoriaMax;

    }

    /// <summary>
    /// The update work.
    /// </summary>
    /// <param name="amount">
    /// The amount.
    /// </param>
    public void UpdateWork(int amount)
    {
        this.GameManager.workDispo += amount;

        if (this.GameManager.workDispo > this.GameManager.workMax)
        {
            this.GameManager.workDispo = this.GameManager.workMax;
        }
        else if (this.GameManager.workDispo < 0)
        {
            this.GameManager.workDispo = 0;
        }

        this.valueSliderWorkText.text = this.GameManager.workDispo.ToString() + " / " + this.GameManager.workMax + "\t";
        this.sliderWork.value = (float)this.GameManager.workDispo / this.GameManager.workMax;

    }

}
