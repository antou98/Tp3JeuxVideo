using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSettingsPanel : MonoBehaviour
{
    public GameObject Panel;
    public Slider VolumeSlider;
    public Slider DifficulteSlider;
    public Toggle ParticuleToogle;

    private bool isPanelOpen;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(InitializeSettings());
    }

    // Attend le chargement des enfants avant d initialiser les variables
    private IEnumerator InitializeSettings()
    {
        yield return null;

        // Initialisation des handles
        VolumeSlider.value = GameSettings.VolumeMusique;
        DifficulteSlider.value = GameSettings.Difficulte;
        ParticuleToogle.isOn = GameSettings.ActivateParticule;

        Panel.SetActive(false);
        isPanelOpen = false;
    }

    // On change l etat ouvert ferme du panel de settings
    public void openPanel() { 
        isPanelOpen = !isPanelOpen;
        Panel.SetActive(isPanelOpen);
    }

    public void updateVolume(float volume) { 
        GameSettings.VolumeMusique = volume;
    }

    public void updateParticules(bool actif) { 
        GameSettings.ActivateParticule = actif;
    }

    public void updateDifficulte(float difficulte) {
        GameSettings.Difficulte = (int)difficulte;
    }
}
