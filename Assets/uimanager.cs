using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uimanager : MonoBehaviour {
    public Text txt;
    bool gameo;
    int score;
    public Button[] Buttons;
	// Use this for initialization
	void Start () {
        score = 0;
        gameo = false;
        InvokeRepeating("updates", 1f, .5f);
		
	}
	
	// Update is called once per frame
	void Update () {
        txt.text = "Score: " + score;
	}
    public void replay()
    {
        Application.LoadLevel("SampleScene");
    }

    public void menu() {
        Application.LoadLevel("menu");
    }
    public void exit() {
        Application.Quit();
    }
    void updates()
    {
        if (gameo == false)
        {
            score += 1;
           


        }
    }
    public void gm()
    {
        gameo = true;
        foreach (Button button in Buttons)
        {
            button.gameObject.SetActive(true);
        }
    }
  
    public void Pause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
}
