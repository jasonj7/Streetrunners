using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private float timer;
    public TMP_Text Starttimer;
    private int Showtimer;

    private PlayerController playerController;
    public GameObject Player;
    private float acttimer;
    public float timeRemaining = 3;
    // Start is called before the first frame update
    void Start()
    {
        
        playerController = Player.GetComponent<PlayerController>();

    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.unscaledDeltaTime;
            Time.timeScale = 0;
            Showtimer = (Mathf.RoundToInt(timeRemaining));
            if (Showtimer != 0)
            {
                Starttimer.text = Showtimer.ToString();
            }
            else
            {
                Starttimer.text = "Go";
            }
        }

        else
        {
            Time.timeScale = 1;
            Starttimer.text = "";
        }
    }
}
