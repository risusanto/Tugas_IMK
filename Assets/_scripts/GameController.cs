using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
    private InputField input;
    private Text soal,score,life, bestscore;
    private int a, b, hasil,state,sekor,heart,best;

    void Update()
    {
        if (sekor > best)
        {
            PlayerPrefs.SetInt("best", sekor);
        }
        if (heart == 0)
        {
            PlayerPrefs.SetInt("score", sekor);
            

            SceneManager.LoadScene("Game_Over");
        }
    }
    void Start()
    {
        sekor = 0;
        heart = 3;
        best = PlayerPrefs.GetInt("best");
        input = GameObject.Find("InputField").GetComponent<InputField>();
        soal = GameObject.Find("soal_text").GetComponent<Text>();
        life = GameObject.Find("heart_text").GetComponent<Text>();
        score = GameObject.Find("score_text").GetComponent<Text>();
        bestscore = GameObject.Find("best_text").GetComponent<Text>();
        buat_soal();
    }

    void buat_soal()
    {
        input.text = "";
        score.text = string.Format("Score: {0}", sekor.ToString());
        life.text = string.Format(heart.ToString());
        a = UnityEngine.Random.Range(0, 99);
        b = UnityEngine.Random.Range(0, 99);
        hasil = a + b;
        bestscore.text = string.Format("Best: {0}", best.ToString());
        soal.text = string.Format("{0} + {1} = ?", a.ToString(), b.ToString());
    }

    public void getInput(string guess)
    {   
        try
        {
            state = Convert.ToInt32(guess);
            Debug.Log(state.ToString());
        }
        catch
        {
            state = -1;
            Debug.Log("Salah");
        }
    }

    public void btn_cek()
    {
        if (state == hasil)
        {
            sekor += 10;
        }
        else
        {
            heart -= 1;
        }
        buat_soal();
    }

    public void btn_home()
    {
        SceneManager.LoadScene("Main_Menu");
    }
}
