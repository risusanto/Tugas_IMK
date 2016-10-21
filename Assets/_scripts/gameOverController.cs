using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameOverController : MonoBehaviour {
    private Text score;
    private int sekor;
    void Awake()
    {
        sekor = PlayerPrefs.GetInt("score");
        score = GameObject.Find("score_text").GetComponent<Text>();
        score.text = string.Format("Your Score: {0}",sekor.ToString());
    }
    public void btn_home()
    {
        SceneManager.LoadScene("Main_Menu");
    }
    
    public void btn_retry()
    {
        SceneManager.LoadScene("Main_Game");
    }
}
