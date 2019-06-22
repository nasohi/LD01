using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadSceneJakarta()
    {
        SceneManager.LoadScene("Level");
    }

    public void LoadSceneBandung()
    {
        SceneManager.LoadScene("LevelTwo");
    }

    public void BackToPlay() {
        SceneManager.LoadScene("SampleScene");
    }
    public void GoToCategory() {
        SceneManager.LoadScene("Category");
    }
    public void GoToAceh()
    {
        SceneManager.LoadScene("LevelThree");
    }
}
