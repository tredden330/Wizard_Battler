using Unity.Netcode;
using UnityEngine;

public class PlayerMovement : NetworkBehaviour
{
    [SerializeField] float speed = 0.01f;

    public Vector2 turn;

    public Vector3 camForward;
    public Vector3 camUp;
    public Vector3 camRight;

    void Start()
    {
        //lock cursor
        Cursor.lockState = CursorLockMode.Locked;

        //start player at origin
        this.transform.position = Vector3.zero;
    }

    private void Update()
    {
        //leave if you dont own this character
        if (!IsOwner) return;

        //rotate based on mouse input
        turn.x += Input.GetAxis("Mouse X");
        turn.y += Input.GetAxis("Mouse Y");
        this.transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);

        //movement relative to camera rotation
        camForward = Camera.main.transform.forward;
        camRight = Camera.main.transform.right;
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position += camRight * speed;
        } 
        if (Input.GetKey(KeyCode.A)) 
        {
            this.transform.position -= camRight * speed;
        } 
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position += camForward * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position -= camForward * speed;
        }
    }
}
