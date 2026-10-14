using UnityEngine;
using TMPro;

public class ProfileSettings : MonoBehaviour
{
    public TMP_InputField nameField;
    public TMP_Dropdown colorDropdown;

    public void SaveName(string value)
    {
        PlayerPrefs.SetString("PlayerName", value);
    }

    public void SaveColor(int index)
    {
        PlayerPrefs.SetInt("PlayerColor", index);
    }

}