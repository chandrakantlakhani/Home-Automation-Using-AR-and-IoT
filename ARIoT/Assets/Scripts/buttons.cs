using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttons : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject onBtn;
    public GameObject offBtn;
    //public GameObject sphere;
    void Start()
    {

        //sphere.SetActive(false);
    }

    // Update is called once per frame
    public void disable()
    {
        /*onBtn.SetActive(false);
        offBtn.SetActive(false);*/
        //sphere.SetActive(false);
    }

    public void onButton()
    {
        disable();
        //offBtn.SetActive(true);
        //sphere.SetActive(true);
        Debug.Log("ON pressed");
        
    }

    public void offButton()
    {
        //disable();
        //onBtn.SetActive(true);
        //sphere.SetActive(false);
        Debug.Log("Off pressed");

    }
    
}
