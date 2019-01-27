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

    /// <summary>
    /// The energie slider image.
    /// </summary>
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
    /// The motivation slider image.
    /// </summary>
    public Image MotivationSliderImage;

    /// <summary>
    /// The slider dysphoria.
    /// </summary>
    public Slider sliderDysphoria;

    /// <summary>
    /// The value slider dysphoria text.
    /// </summary>
    public Text valueSliderDysphoriaText;

    /// <summary>
    /// The dysphoria slider image.
    /// </summary>
    public Image DysphoriaSliderImage;

    /// <summary>
    /// The slider dysphoria.
    /// </summary>
    public Slider sliderWork;

    /// <summary>
    /// The value slider work text.
    /// </summary>
    public Text valueSliderWorkText;

    /// <summary>
    /// The workslider image.
    /// </summary>
    public Image WorksliderImage;

    #endregion

    public HomePanel HomePanel;

    public GameManager GameManager;

    public PlacePanel PlacePanel;

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

        this.EnergieSliderImage.color = this.GameManager.Purplecolor;
        this.MotivationSliderImage.color = this.GameManager.Purplecolor;
        this.DysphoriaSliderImage.color = this.GameManager.Purplecolor;
        this.WorksliderImage.color = this.GameManager.Purplecolor;

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

    /// <summary>
    /// The update energie with hover.
    /// </summary>
    /// <param name="value">
    /// The value.
    /// </param>
    public void UpdateEnergieHover(int value)
    {

        if (this.EnergieSliderImage.color == this.GameManager.Purplecolor)
        {
            if (value > this.GameManager.energieDispo)
            {
                this.EnergieSliderImage.color = this.GameManager.GreenColor;
            }
            else if (value < this.GameManager.energieDispo)
            {
                this.EnergieSliderImage.color = this.GameManager.RedColor;
            }
        }
        else
        {
            this.EnergieSliderImage.color = this.GameManager.Purplecolor;
        }

        this.GameManager.energieDispo = value;

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
            this.PlacePanel.UpdateAlliesAmount(amount);
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
    /// The update motivation with hover.
    /// </summary>
    /// <param name="value">
    /// The value.
    /// </param>
    public void UpdateMotivationHover(int value)
    {

        if (this.MotivationSliderImage.color == this.GameManager.Purplecolor)
        {
            if (value > this.GameManager.motivationDispo)
            {
                this.MotivationSliderImage.color = this.GameManager.GreenColor;
            }
            else if (value < this.GameManager.motivationDispo)
            {
                this.MotivationSliderImage.color = this.GameManager.RedColor;
            }
        }
        else
        {
            this.MotivationSliderImage.color = this.GameManager.Purplecolor;
        }

        this.GameManager.motivationDispo = value;

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
            this.PlacePanel.UpdateSliderAmount(0.05f);
            this.GameManager.dysphoriaDispo = 0;
        }

        this.valueSliderDysphoriaText.text = this.GameManager.dysphoriaDispo.ToString() + " / " + this.GameManager.dysphoriaMax + "\t";
        this.sliderDysphoria.value = (float)this.GameManager.dysphoriaDispo / this.GameManager.dysphoriaMax;
    }

    /// <summary>
    /// The update dysphoria hover.
    /// </summary>
    /// <param name="value">
    /// The value.
    /// </param>
    public void UpdateDysphoriaHover(int value)
    {

        if (this.DysphoriaSliderImage.color == this.GameManager.Purplecolor)
        {
            if (value > this.GameManager.dysphoriaDispo)
            {
                this.DysphoriaSliderImage.color = this.GameManager.RedColor;
            }
            else if (value < this.GameManager.dysphoriaDispo)
            {
                this.DysphoriaSliderImage.color = this.GameManager.GreenColor;
            }
        }
        else
        {
            this.DysphoriaSliderImage.color = this.GameManager.Purplecolor;
        }

        this.GameManager.dysphoriaDispo = value;

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

    public void UpdateWorkHover(int value)
    {

        if (this.WorksliderImage.color == this.GameManager.Purplecolor)
        {
            if (value > this.GameManager.workDispo)
            {
                this.WorksliderImage.color = this.GameManager.GreenColor;
            }
            else if (value < this.GameManager.workDispo)
            {
                this.WorksliderImage.color = this.GameManager.RedColor;
            }
        }
        else
        {
            this.WorksliderImage.color = this.GameManager.Purplecolor;
        }

        this.GameManager.workDispo = value;

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
