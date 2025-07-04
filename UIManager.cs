using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text coinText;

    void Update() =>
        coinText.text = "Coins: " + PlayerPrefs.GetInt("Coins", 0).ToString();
}