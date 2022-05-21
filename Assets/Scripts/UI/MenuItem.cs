using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuItem : MonoBehaviour
{
    [SerializeField()]
    public string Id;

    [SerializeField()]
    public Color MouseOverColor;

    protected Material material;
    protected Color baseColor;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("MenuObject created");

        material = GetComponent<Renderer>().material;
        baseColor = material.color;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnMouseOver()
    {
        // Debug.Log("Mouse is over GameObject.");
    }

    void OnMouseEnter() {
        Debug.Log($"Mouse enter: {ToString()}");
    
        material.SetColor("_Color", MouseOverColor);
    }

    void OnMouseExit()
    {
        Debug.Log($"Mouse exit: {ToString()}");

        material.SetColor("_Color", baseColor);
    }

    void OnMouseDown()
    {
        Debug.Log($"Clicked on button '{Id}'");
    }
}
