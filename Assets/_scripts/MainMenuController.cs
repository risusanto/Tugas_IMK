using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {
    public void btn_Play()
    {
        SceneManager.LoadScene("Main_Game");
    }
}
