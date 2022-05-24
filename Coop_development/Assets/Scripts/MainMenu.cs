using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public bool isStart;
    public bool isEnd;

    private void OnMouseUp()
    {
        if (isStart)
        {
            Application.LoadLevel(1);
        }
        if (isEnd)
        {
            Application.Quit();
        }
    }
}