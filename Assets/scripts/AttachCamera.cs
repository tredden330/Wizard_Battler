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

        if (IsOwner)
        {
            Debug.Log("camera attached!");
            cam = GameObject.Find("Main Camera");
            cam.transform.position = this.transform.position + new Vector3(0.28f, camHeight, 0f);
            cam.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            cam.transform.SetParent(this.transform);
        }
    }
}
