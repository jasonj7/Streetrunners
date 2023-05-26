using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharingBar : MonoBehaviour
{
    private PlayerController playerController;
    public GameObject Player;
    public Slider Charingbar;
    private float currenttime;
    // Start is called before the first frame update
    void Start()
    {
        playerController = Player.GetComponent<PlayerController>();
        Charingbar.maxValue = playerController.timedJump;
        currenttime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Charingbar.value = currenttime;

        if (Input.GetKey(KeyCode.Space))
        {
            currenttime += Time.deltaTime;
        }  else
        {
            currenttime = 0;
        }

    }


}
