using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The home panel.
/// </summary>
public class HomePanel : MonoBehaviour
{
    public ValuesPanel valuesPanel;



    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start () {
		
	}

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update () {
		
	}

    /// <summary>
    /// The back to home button click.
    /// </summary>
    public void backToHomeButtonClick()
    {
        this.valuesPanel.UpdateEnergie(5);
    }
}
