using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(SurfaceSlider))]
[RequireComponent(typeof(PhysMovement))]
[RequireComponent(typeof(KeyboardInput))]
public class PlayerMovement : MonoBehaviour
{
    private void Start()
    {
        Destroy(this);
    }
}
