using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The home panel.
/// </summary>
public class FamilyPanel : MonoBehaviour
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
    public void VisitFamilyButtonClick()
    {
        if (this.valEnergieSliderBeforeHover - 1 < 0)
        {
            this.InfoPanel.UpdateTextLogContent("You want to sleep, it's too risky to drive.\n" + "You maybe need to sleep a little before.");
        }
        else if (this.valWorkSliderBeforeHover - 1 < 0)
        {
            this.InfoPanel.UpdateTextLogContent("You want to visit your family but you have to many work.\n" + "You may finish the important task before.");
        }
        else
        {
            this.valEnergieSliderBeforeHover = this.GameManager.energieDispo;
            this.valMotivationSliderBeforeHover = this.GameManager.motivationDispo;
            this.valDysphoriaSliderBeforeHover = this.GameManager.dysphoriaDispo;
            this.valWorkSliderBeforeHover = this.GameManager.workDispo;

            this.ValuesPanel.UpdateEnergie(-1);
            this.ValuesPanel.UpdateMotivation(1);
            this.ValuesPanel.UpdateDysphoria(-1);
            this.ValuesPanel.UpdateWork(-1);

            this.InfoPanel.UpdateTextLogContent("Your family love you.\n" + "Your are more motivated and you are less disphoric");
        }
    }

    /// <summary>
    /// The hover back home button.
    /// </summary>
    public void hoverVisitFamilyButton()
    {
        this.valEnergieSliderBeforeHover = this.GameManager.energieDispo;
        this.valMotivationSliderBeforeHover = this.GameManager.motivationDispo;
        this.valDysphoriaSliderBeforeHover = this.GameManager.dysphoriaDispo;
        this.valWorkSliderBeforeHover = this.GameManager.workDispo;

        this.ValuesPanel.UpdateEnergieHover(this.GameManager.energieDispo - 1);
        this.ValuesPanel.UpdateMotivationHover(this.GameManager.motivationDispo + 1);
        this.ValuesPanel.UpdateDysphoriaHover(this.GameManager.dysphoriaDispo - 1);
        this.ValuesPanel.UpdateWorkHover(this.GameManager.workDispo - 1);
    }

    /// <summary>
    /// The unhover back home button.
    /// </summary>
    public void UnhoverVisitFamilyButton()
    {
        this.ValuesPanel.UpdateEnergieHover(this.valEnergieSliderBeforeHover);
        this.ValuesPanel.UpdateMotivationHover(this.valMotivationSliderBeforeHover);
        this.ValuesPanel.UpdateDysphoriaHover(this.valDysphoriaSliderBeforeHover);
        this.ValuesPanel.UpdateWorkHover(this.valWorkSliderBeforeHover);
    }

}
