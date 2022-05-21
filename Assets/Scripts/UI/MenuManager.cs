using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    protected Text debugText;

    // Start is called before the first frame update
    void Start()
    {
        //Transform transform = this.Tran
        GameObject debugTextObject = transform.Find("DebugText").gameObject;
        debugText = debugTextObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Play()
    {
        Debug.Log("Play");
        debugText.text = "Clicked: Play";
    }

    public void OpenSettings()
    {
        Debug.Log("OpenSettings");
        debugText.text = "Clicked: OpenSettings";
    }

    public void OpenShop()
    {
        Debug.Log("OpenShop");
        debugText.text = "Clicked: OpenShop";
    }
}
