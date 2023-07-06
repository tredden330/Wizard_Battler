using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Management;

public class DetectXR : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //if XR headset is found on startup, disable main camera
        if (UnityEngine.XR.XRSettings.enabled)
        {
            Debug.Log("XR!!!");
            GameObject.Find("/Main Camera").SetActive(false);
            
        } 
        //if using XR, disable XR
        else
        {
            Debug.Log("not xr");
            GameObject.Find("XR Interaction Manager").SetActive(false);
            GameObject.Find("XR Origin (XR Rig)").SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
