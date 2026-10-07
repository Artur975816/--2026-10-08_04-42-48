using UnityEngine;

public class GameSettingsController : MonoBehaviour
{
    public GameObject settingsPanel;
    public AudioSource bgSound;

    public void OpenSettings()
    {
        settingsPanel.SetActive(true);
    }

    public void CloseSettings()
    {
        settingsPanel.SetActive(false);
    }

    public void SetVolume(float value)
    {
        bgSound.volume = value;
    }
}