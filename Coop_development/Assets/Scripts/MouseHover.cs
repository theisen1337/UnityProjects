using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHover : MonoBehaviour
{
    private Color basicColor = Color.white;
    private Color hoverColor = new Color(0.0f, 0.69f, 0.2f);

    private Renderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        System.Console.WriteLine("This is test");
    }

    void OnMouseEnter()
    {
        renderer.material.color = hoverColor;
        //GetComponent<Renderer>().material.color = Color.black;
    }

    void OnMouseExit()
    {
        renderer.material.color = basicColor;
        //GetComponent<Renderer>().material.color = Color.black;
    }
}
