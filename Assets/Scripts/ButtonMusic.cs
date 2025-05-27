using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ButtonMusic : MonoBehaviour
{
    Button myButton;
    public static event Action OnClickButtonOpc;
    private void Awake()
    {
        myButton = GetComponent<Button>();
    }

    private void Start()
    {
        myButton.onClick.AddListener(Interactue);
    }

    void Interactue()
    {
        OnClickButtonOpc?.Invoke();
        SingletonBasic.instance.Open();
        
    }
}
