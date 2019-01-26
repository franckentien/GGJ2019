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
        this.valEnergieSliderBeforeHover = this.GameManager.energieDispo;
        this.valMotivationSliderBeforeHover = this.GameManager.motivationDispo;
        this.valDysphoriaSliderBeforeHover = this.GameManager.dysphoriaDispo;
        this.valWorkSliderBeforeHover = this.GameManager.workDispo;

        this.ValuesPanel.UpdateEnergie(-1);
        this.ValuesPanel.UpdateMotivation(-1);
        this.ValuesPanel.UpdateDysphoria(2);
        this.ValuesPanel.UpdateWork(3);
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
