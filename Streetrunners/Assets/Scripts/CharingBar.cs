using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharingBar : MonoBehaviour
{
    private PlayerController playerController;
    public GameObject Player;
    public Slider Charingbar;
    private float maxtime;
    private float currenttime;
    // Start is called before the first frame update
    void Start()
    {
        
        //maxtime = playerController.timedJump;
        Charingbar.maxValue = maxtime;
    }

    // Update is called once per frame
    void Update()
    {
        //currenttime = playerController.jumpTimer;
        Charingbar.value = currenttime;
    }
}
