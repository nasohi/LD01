using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;

public class GoToQuizBdg : MonoBehaviour
{
    public GameObject CanvasQuiz, win, lose;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (CrossPlatformInputManager.GetButtonDown("Button_A"))
        {
            Debug.Log("Check Google dong");
            Invoke("FunctionLose", 1);
            lose.SetActive(true);

        }
        else if (CrossPlatformInputManager.GetButtonDown("Button_B"))
        {
            Debug.Log("Menang");
            Invoke("FunctionWin", 1);
            win.SetActive(true);

            //  Load
            UnityEngine.SceneManagement.SceneManager.LoadScene("category");

        }
        else if (CrossPlatformInputManager.GetButtonDown("Button_C"))
        {
            Debug.Log("Check Google dong");
            Invoke("FunctionLose", 1);
            lose.SetActive(true);
        }
        else if (CrossPlatformInputManager.GetButtonDown("Button_D"))
        {
            Debug.Log("Check Google dong");
            Invoke("FunctionLose", 1);
            lose.SetActive(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {   
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Soal");
            //CanvasQuiz.SetActive(true);
        }
    }
    private void FunctionWin()
    {
        CanvasQuiz.SetActive(false);
        SceneManager.LoadScene("category");
    }
    private void FunctionLose()
    {
        CanvasQuiz.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
