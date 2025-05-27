using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManagerController : MonoBehaviour
{

    [SerializeField] GameObject PanelWin;
    [SerializeField] GameObject PanelLose;

    [SerializeField] float timeToWin;
    private float timer = 0f;


    private void Update()
    {

        timer += Time.deltaTime;

        if (timer >= timeToWin)
        {
            Win();
            return;
        }
    }


    private void OnEnable()
    {
        playerController.OnDestroyPlayer += Lose;
    }
    private void OnDisable()
    {
        playerController.OnDestroyPlayer -= Lose;
    }

    void Win()
    {
        Time.timeScale = 0.0f;
        PanelWin.SetActive(true);
    }

    void Lose()
    {
        Time.timeScale = 0.0f;
        PanelLose.SetActive(true);
    }
}
