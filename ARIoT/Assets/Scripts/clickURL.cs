using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.Networking;


public class clickURL : MonoBehaviour
{
    public string url;
    public GameObject textbox;
    public UnityEngine.Networking.CertificateHandler certificateHandler = null;
    public void open()
    {
        StartCoroutine(GetRequest(url));
    }

    IEnumerator GetRequest(string uri)
    {
        UnityWebRequest webRequest = UnityWebRequest.Get(uri);
        yield return webRequest.SendWebRequest();
        if (webRequest.error != null)
        {
            Debug.Log(webRequest.error);
            textbox.GetComponent<UnityEngine.UI.Text>().text = ("false");
        }
        else
        {
            textbox.GetComponent<UnityEngine.UI.Text>().text = ("true");
        }
    }
}
