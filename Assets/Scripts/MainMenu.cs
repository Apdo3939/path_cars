using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject creditsPanel;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void loadSceneByName(string sceneName = null)
    {
        if (sceneName == null)
        {
            Debug.LogWarning("Informe o nome da cena!!!");
            return;
        }
        SceneManager.LoadScene(sceneName);
    }

    public void ShowCredits(bool show = true){
        creditsPanel.SetActive(show);
    }

    public void exitGame(){
        Application.Quit();
    }
}
