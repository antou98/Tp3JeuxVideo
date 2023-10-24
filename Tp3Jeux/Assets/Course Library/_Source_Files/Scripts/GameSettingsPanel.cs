using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSettingsPanel : MonoBehaviour
{
    public GameObject PanelSettings;
    public Slider VolumeSlider;
    public Slider DifficulteSlider;
    public Toggle ParticuleToogle;

    // Start is called before the first frame update
    void Start()
    {
        // On desactive le paneau de parametres
        PanelSettings.SetActive(false);
    }
}
