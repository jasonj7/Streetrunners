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
        gameObject.SetActive(false);
        currenttime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //gameObject.SetActive(true);
            currenttime += Time.fixedDeltaTime;
            Charingbar.value = currenttime;
        } else if (Input.GetKeyUp(KeyCode.Space))
        {
            currenttime = 0;
            //gameObject.SetActive(false);
        }

        Debug.Log(currenttime);
    }
}
