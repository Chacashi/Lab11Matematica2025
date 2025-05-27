using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonScene : MonoBehaviour
{
    [SerializeField] Button myButton;
    [SerializeField] string newScene;

    private void Awake()
    {
        myButton = GetComponent<Button>();
    }
    void start()
    {
        Time.timeScale = 1.0f; 
    }

    private void Start()
    {
        myButton.onClick.AddListener(ChangueScene);
    }

    void ChangueScene()
    {
        SceneManager.LoadScene(newScene);
        Time.timeScale = 1.0f;
    }
}
