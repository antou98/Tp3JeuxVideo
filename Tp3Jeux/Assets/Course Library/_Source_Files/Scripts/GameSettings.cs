using UnityEngine;

public class GameSettings : MonoBehaviour
{
    /// <summary>
    /// Volume du jeu
    /// </summary>
    public static float VolumeMusique {
        get => PlayerPrefs.GetFloat("VolumeMusique", defaultValue: 1f);
        set => PlayerPrefs.SetFloat("VolumeMusique", value);
    }

    /// <summary>
    /// Activer les particules
    /// </summary>
    public static bool ActivateParticule {
        get => PlayerPrefs.GetInt("ActivateParticule", defaultValue: 0) == 1 ? true:false;
        set => PlayerPrefs.SetInt("ActivateParticule", value ? 1 : 0);
    }

    /// <summary>
    /// Choix de difficulte
    /// </summary>
    public static int Difficulte
    {
        get => PlayerPrefs.GetInt("Difficulte", defaultValue: 0);
        set => PlayerPrefs.SetInt("Difficulte", value);
    }

}
