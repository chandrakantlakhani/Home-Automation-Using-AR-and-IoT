using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class clickURL : MonoBehaviour
{
    public string url;
    public void open()
    {
        StartCoroutine(GetRequest(url));
        //Debug.Log("IP is " + url);

    }

    IEnumerator GetRequest(string uri)
    {
        //Debug.Log("uri is " + uri);
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            // Request and wait for the desired page.
             
            yield return webRequest.SendWebRequest();
            
        }
    }
}
