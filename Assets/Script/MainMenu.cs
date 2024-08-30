using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void ToMp()
    {
        SceneManager.LoadScene("MusicPlay");
    }

     public void ToSp()
    {
        SceneManager.LoadScene("StoryPlay");
    }

     public void ToMm()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void ToSetting()
    {
        SceneManager.LoadScene("Setting");
    }
   
}
