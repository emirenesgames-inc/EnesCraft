using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject Uyari;
    public GameObject Menu;
    public GameObject TekOyunculu;

    private void Start()
    {
        Uyari.SetActive(true);
        Menu.SetActive(false);
    }

    public void Exit()
    {
        Uyari.SetActive(false);
        Menu.SetActive(false);

        Application.Quit();
    }

    public void UyariExit()
    {
        Uyari.SetActive(false);
        Menu.SetActive(true);
    }

    public void TekOyunculuGir()
    {
        Menu.SetActive(false);
        TekOyunculu.SetActive(true);
    }

    public void TekOyunculuExit()
    {
        Menu.SetActive(true);
        TekOyunculu.SetActive(false);
    }

    public void GameSpawn()
    {
        Menu.SetActive(false);
        TekOyunculu.SetActive(false);

        SceneManager.LoadScene(1);
        SceneManager.LoadSceneAsync(1);
    }
}
