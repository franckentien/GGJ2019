using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The home panel.
/// </summary>
public class WorkPanel : MonoBehaviour
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
    public void GoToWorkButtonClick()
    {
        
        if (this.valEnergieSliderBeforeHover - 1 < 0)
        {
            this.InfoPanel.UpdateTextLogContent("You don't have enough energy to work\n" + "You maybe need to sleep at home.");
        }
        else if (this.valMotivationSliderBeforeHover - 1 < 0)
        {
            this.InfoPanel.UpdateTextLogContent("You really don't want to work\n" + "You need to motive yourself before.");
        }
        else if (this.valDysphoriaSliderBeforeHover >= this.GameManager.dysphoriaMax)
        {
            this.InfoPanel.UpdateTextLogContent("You are paralyzed by stress\n" + "Try to change your mind before go to work again");
        }
        else if (this.valWorkSliderBeforeHover >= this.GameManager.workMax)
        {
            this.InfoPanel.UpdateTextLogContent("You open Outlook but you don't have new mails\n" + "Take a break and come back later !");
        }
        else
        {

            this.valEnergieSliderBeforeHover = this.GameManager.energieDispo;
            this.valMotivationSliderBeforeHover = this.GameManager.motivationDispo;
            this.valDysphoriaSliderBeforeHover = this.GameManager.dysphoriaDispo;
            this.valWorkSliderBeforeHover = this.GameManager.workDispo;

            this.ValuesPanel.UpdateEnergie(-1);
            this.ValuesPanel.UpdateMotivation(-1);
            this.ValuesPanel.UpdateDysphoria(2);
            this.ValuesPanel.UpdateWork(3);

            this.InfoPanel.UpdateTextLogContent("You work on a non friendly environment your dysphoria increase.\n" + "You lose somme energy and motivation.");

            this.InfoPanel.UpdateDateToNextDay();
        }

    }

    /// <summary>
    /// The hover back home button.
    /// </summary>
    public void hoverGoToWorkButton()
    {
        this.valEnergieSliderBeforeHover = this.GameManager.energieDispo;
        this.valMotivationSliderBeforeHover = this.GameManager.motivationDispo;
        this.valDysphoriaSliderBeforeHover = this.GameManager.dysphoriaDispo;
        this.valWorkSliderBeforeHover = this.GameManager.workDispo;

        this.ValuesPanel.UpdateEnergieHover(this.GameManager.energieDispo - 1);
        this.ValuesPanel.UpdateMotivationHover(this.GameManager.motivationDispo - 1);
        this.ValuesPanel.UpdateDysphoriaHover(this.GameManager.dysphoriaDispo + 2);
        this.ValuesPanel.UpdateWorkHover(this.GameManager.workDispo + 3);
    }

    /// <summary>
    /// The unhover back home button.
    /// </summary>
    public void UnhoverGoToWorkButton()
    {
        this.ValuesPanel.UpdateEnergieHover(this.valEnergieSliderBeforeHover);
        this.ValuesPanel.UpdateMotivationHover(this.valMotivationSliderBeforeHover);
        this.ValuesPanel.UpdateDysphoriaHover(this.valDysphoriaSliderBeforeHover);
        this.ValuesPanel.UpdateWorkHover(this.valWorkSliderBeforeHover);
    }

}
