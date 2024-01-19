using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour
{

    public void MainToUpgradeScene() {
        SceneManager.LoadScene("UpgradePC");
    }
    public void ToMainScene () {
        SceneManager.LoadScene("MainScene");
    }
    public void MainToLanguageScene() {
        SceneManager.LoadScene("UpgradeLanguage");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
