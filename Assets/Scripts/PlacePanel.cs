using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlacePanel : MonoBehaviour
{
    /// <summary>
    /// The self confidence slider.
    /// </summary>
    public Slider SelfConfidenceSlider;

    /// <summary>
    /// The selfconfidence slider text.
    /// </summary>
    public Text SelfconfidenceSliderText;

    /// <summary>
    /// The values allies text.
    /// </summary>
    public Text ValuesAlliesText;

    /// <summary>
    /// The game manager.
    /// </summary>
    public GameManager GameManager;

    public void UpdateSliderAmount(float amount)
    {
        this.GameManager.selfConfidence += amount;

        if (this.GameManager.selfConfidence > 1)
        {
            this.GameManager.selfConfidence = 1;
        }
        else if (this.GameManager.selfConfidence < 0)
        {
            this.GameManager.selfConfidence = 0;
        }

        this.SelfconfidenceSliderText.text = (this.GameManager.selfConfidence * 100).ToString();
        this.SelfConfidenceSlider.value = this.GameManager.selfConfidence;
    }

    public void UpdateAlliesAmount(int amount)
    {
        this.GameManager.alliesNumber += amount;
        this.ValuesAlliesText.text = this.GameManager.alliesNumber.ToString();
    }

    
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
}
