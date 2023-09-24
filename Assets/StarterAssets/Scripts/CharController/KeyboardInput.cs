using System.Collections;
using UnityEngine;

public class KeyboardInput : MonoBehaviour
{
    private PhysMovement movement;

    private Vector3 direction;

    private string HorizontalAxis = "Horizontal";
    private string VerticalAxis = "Vertical";

    private void Start()
    {
        direction = new Vector3();
        movement = GetComponent<PhysMovement>();
    }

    private void FixedUpdate()
    {
        direction.x = -Input.GetAxis(VerticalAxis);
        direction.y = 0;
        direction.z = Input.GetAxis(HorizontalAxis);
        movement.Move(direction);
    }
}
