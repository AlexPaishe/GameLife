using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private Text _debugText;

    public void Play()
    {
        Debug.Log("Play");
        _debugText.text = "Clicked: Play";
    }

    public void OpenSettings()
    {
        Debug.Log("OpenSettings");
        _debugText.text = "Clicked: OpenSettings";
    }

    public void OpenShop()
    {
        Debug.Log("OpenShop");
        _debugText.text = "Clicked: OpenShop";
    }
}
