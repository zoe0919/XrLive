using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoginScript : MonoBehaviour
{
    public Button button;


    private void Awake()
    {
        Logger.Init();
    }
    // Start is called before the first frame update
    void Start()
    {
        Logger.Log("LoginScene start");
        button.onClick.AddListener(SwitchScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SwitchScene()
    {
        Logger.Log("SwitchScene to MainScene");
        SceneManager.LoadScene("MainScene");
    }
}
