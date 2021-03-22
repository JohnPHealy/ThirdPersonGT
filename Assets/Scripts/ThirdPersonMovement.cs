using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]

public class ThirdPersonMovement : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float rotationSmoothing = 0.1f;
    
    private Vector3 movement;
    private CharacterController myController;
    private float rotateVelocity;
    // Start is called before the first frame update
    void Start()
    {
        myController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float angle = Mathf.Atan2(movement.x, movement.z) * Mathf.Rad2Deg;

        angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, angle, ref rotateVelocity, rotationSmoothing);
        
        transform.rotation = Quaternion.Euler(0f, angle, 0f);
        
        myController.Move(movement.normalized * (speed * Time.deltaTime));
    }

    public void Move(InputAction.CallbackContext context)
    {
        var moveInput = context.ReadValue<Vector2>();
        movement = new Vector3(moveInput.x, 0f, moveInput.y).normalized;
        
    }
}
