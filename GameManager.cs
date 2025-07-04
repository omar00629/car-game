using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void LoadRaceMode() => SceneManager.LoadScene("RaceMode");
    public void LoadParkingMode() => SceneManager.LoadScene("ParkingMode");
    public void GoToMainMenu() => SceneManager.LoadScene("MainMenu");
}