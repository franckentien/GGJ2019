using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The values panel.
/// </summary>
public class ValuesPanel : MonoBehaviour
{
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
    /// The slider energie.
    /// </summary>
    public Slider sliderEnergie;

    /// <summary>
    /// The value slider energie.
    /// </summary>
    public Text valueSliderEnergieText;

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
        this.valueSliderEnergieText.text = this.energieDispo.ToString() + " / " + this.energieMax + "\t";
        this.sliderEnergie.value = (float)this.energieDispo / this.energieMax;
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
        this.valueSliderWorkText.text = this.workDispo.ToString() + " / " + this.workMax + "\t";
        this.sliderWork.value = (float)this.workDispo / this.workMax;

    }

}
