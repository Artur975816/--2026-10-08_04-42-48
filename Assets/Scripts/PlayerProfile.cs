using UnityEngine;
using TMPro;

public class PlayerProfile : MonoBehaviour
{
    public TMP_Text playerNameText;
    public Color[] colors = { Color.red, Color.green, Color.blue,  };

    void Start()
    {
        playerNameText.text = PlayerPrefs.GetString("PlayerName", "Player");

        int colorIndex = PlayerPrefs.GetInt("PlayerColor", 0);
        GetComponent<Renderer>().material.color = colors[colorIndex];
    }

    public void UpdateName(string value)
    {
        playerNameText.text = value;
    }

    public void UpdateColor(int index)
    {
        GetComponent<Renderer>().material.color = colors[index];
    }
}