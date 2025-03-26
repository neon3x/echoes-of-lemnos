using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D RigidBody;
    public float moveSpeed;

    public InputActionReference moveInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //RigidBody.linearVelocity = new Vector2(moveSpeed, 0f);
        RigidBody.linearVelocity = moveInput.action.ReadValue<Vector2>().normalized * moveSpeed;
    }
}
