using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    // Called when button is clicked.
    public void OnClick()
    {
        Debug.Log(gameObject.name + ".OnClick()");
        // Load first scene.
    }
}
