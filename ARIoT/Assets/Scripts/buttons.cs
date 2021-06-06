using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class buttons : MonoBehaviour
{ 
    public GameObject onBtn;
    public GameObject offBtn;
    public GameObject textbox;

    void Start()
    {

    }

    public void onButton()
    {
        Debug.Log("ON pressed");
    }
    public void offButton()
    {
        Debug.Log("Off pressed");
    }
    
}
