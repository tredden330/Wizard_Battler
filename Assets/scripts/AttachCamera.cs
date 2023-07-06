using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class AttachCamera : NetworkBehaviour
{
    [SerializeField] float camHeight = 3;
    GameObject cam;
    // Start is called before the first frame update
    void Start()
    {
        //make sure that this player owns this pawn
        if (IsOwner)
        {
            if (UnityEngine.XR.XRSettings.enabled)
            {
                Debug.Log("camera attached!");
                cam = GameObject.Find("XR Origin (XR Rig)");
                cam.transform.position = this.transform.position + new Vector3(0.28f, camHeight, 0f);
                cam.transform.eulerAngles = new Vector3(0f, 0f, 0f);
                cam.transform.SetParent(this.transform);
            } 
            else
            {
                Debug.Log("camera attached!");
                cam = GameObject.Find("/Main Camera");
                cam.transform.position = this.transform.position + new Vector3(0.28f, camHeight, 0f);
                cam.transform.eulerAngles = new Vector3(0f, 0f, 0f);
                cam.transform.SetParent(this.transform);
            }
            
        }
    }
}
