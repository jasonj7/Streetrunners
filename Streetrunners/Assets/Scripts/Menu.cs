using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField]
    private GameObject Settings;
    
    [SerializeField]
    private GameObject MainMenu;
    
    [SerializeField]
    private GameObject PauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        Settings.SetActive(false);
        MainMenu.SetActive(true);
        PauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Pause();
        }
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void OpenGame()
    {
        SceneManager.LoadScene("test");
    }

    public void SettingButton()
    {
        Settings.SetActive(true);
        MainMenu.SetActive(false);
        PauseMenu.SetActive(false);
    }

    public void BackButton()
    {
        Settings.SetActive(false);
        MainMenu.SetActive(true);
        PauseMenu.SetActive(true);
    }
    public void Resume()
        {
            Time.timeScale = 1;
            PauseMenu.SetActive(false);
            //PlayerController.isPaused = false;
        }
    private void Pause()
    {
        Time.timeScale = 0;
        PauseMenu.SetActive(true);
        // PlayerController.isPaused = true;
    }

    

    
}
