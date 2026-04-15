using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{
    [SerializeField] TMP_Dropdown jumpkeyInput;

    [SerializeField] Slider volumeSlider;
    private void Start()
    {
        jumpkeyInput.value = PlayerPrefs.GetInt("JumpKey", 0);
        volumeSlider.value = PlayerPrefs.GetFloat("Volume", 0.5f);
    }

    public void SaveSettings()
    {
        PlayerPrefs.SetInt("JumpKey", jumpkeyInput.value);
        PlayerPrefs.SetFloat("Volume", volumeSlider.value);
        PlayerPrefs.Save();
    }
}