using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class PlayGame : MonoBehaviour
{
    public TextMeshProUGUI OyunSuresi;

    private void Update()
    {
        OyunSuresi.text = "Oyun Süresi: " + ((int)Time.time).ToString() +" sn";
    }
    public void Restart()
    {
        SceneManager.LoadScene(1);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
