using Unity.Netcode;
using UnityEngine;

public class PlayerMovement : NetworkBehaviour
{
    [SerializeField] float speed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (!IsOwner) return;

        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position += new Vector3(speed,0f,0f);
        } else if (Input.GetKey(KeyCode.A)) {
            this.transform.position -= new Vector3(speed,0f,0f);
        } else if (Input.GetKey(KeyCode.W))
        {
            this.transform.position += new Vector3(0f, 0f, speed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            this.transform.position -= new Vector3(0f, 0f, speed);
        }
    }
}
