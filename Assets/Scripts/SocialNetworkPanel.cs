using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The home panel.
/// </summary>
public class SocialNetworkPanel : MonoBehaviour
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
    void Start()
    {

    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {

    }

    /// <summary>
    /// The back to home button click.
    /// </summary>
    public void GoOnlineButtonClick()
    {
        if (this.valEnergieSliderBeforeHover - 1 < 0)
        {
            this.InfoPanel.UpdateTextLogContent("You try to open twitter but you fall asleep.\n" + "Turn off your phone and try to sleep");
        }
        else if (this.valDysphoriaSliderBeforeHover >= this.GameManager.dysphoriaMax)
        {
            this.InfoPanel.UpdateTextLogContent("Last time you see some content who trigger you.\n" + "You don't want to open Social network for the moment.");
        }
        if (this.valWorkSliderBeforeHover - 1 < 0)
        {
            this.InfoPanel.UpdateTextLogContent("When you take a look on your notifications you see your boss call you 5 times.\n" + "You should try to recall it before.");
        }

        else
        {
            this.valEnergieSliderBeforeHover = this.GameManager.energieDispo;
            this.valMotivationSliderBeforeHover = this.GameManager.motivationDispo;
            this.valDysphoriaSliderBeforeHover = this.GameManager.dysphoriaDispo;
            this.valWorkSliderBeforeHover = this.GameManager.workDispo;

            this.ValuesPanel.UpdateEnergie(-1);
            this.ValuesPanel.UpdateMotivation(1);
            this.ValuesPanel.UpdateDysphoria(1);
            this.ValuesPanel.UpdateWork(-1);

            this.InfoPanel.UpdateTextLogContent("You see some lolcats on facebook\n" + "Your motivation increase but you see some post who hurt you.");

            this.InfoPanel.UpdateDateToNextDay();
        }
    }

    /// <summary>
    /// The hover back home button.
    /// </summary>
    public void hoverGoOnlineButton()
    {
        this.valEnergieSliderBeforeHover = this.GameManager.energieDispo;
        this.valMotivationSliderBeforeHover = this.GameManager.motivationDispo;
        this.valDysphoriaSliderBeforeHover = this.GameManager.dysphoriaDispo;
        this.valWorkSliderBeforeHover = this.GameManager.workDispo;

        this.ValuesPanel.UpdateEnergieHover(this.GameManager.energieDispo - 1);
        this.ValuesPanel.UpdateMotivationHover(this.GameManager.motivationDispo + 1);
        this.ValuesPanel.UpdateDysphoriaHover(this.GameManager.dysphoriaDispo + 1);
        this.ValuesPanel.UpdateWorkHover(this.GameManager.workDispo - 1);
    }

    /// <summary>
    /// The unhover back home button.
    /// </summary>
    public void UnhoverGoOnlineButton()
    {
        this.ValuesPanel.UpdateEnergieHover(this.valEnergieSliderBeforeHover);
        this.ValuesPanel.UpdateMotivationHover(this.valMotivationSliderBeforeHover);
        this.ValuesPanel.UpdateDysphoriaHover(this.valDysphoriaSliderBeforeHover);
        this.ValuesPanel.UpdateWorkHover(this.valWorkSliderBeforeHover);
    }

}
