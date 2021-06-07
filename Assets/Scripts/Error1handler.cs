using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Error1handler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Please Wait")
        {
            StartCoroutine(PleaseWaitScene());
        }
    }

    public IEnumerator PleaseWaitScene()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(3);
    }

    public void ReloadButton()
    {
        SceneManager.LoadScene(1);
    }

    public void ReinstallButton()
    {
        SceneManager.LoadScene(2);
    }

    public void BackButton()
    {
        SceneManager.LoadScene(0);
    }

    public void CloseButtonn()
    {
        Application.Quit();
    }
}
