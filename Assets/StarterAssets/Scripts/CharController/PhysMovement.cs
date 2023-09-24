using System.Collections;
using UnityEngine;

public class PhysMovement : MonoBehaviour
{
    private Rigidbody rb;
    private SurfaceSlider surfaceSlider;

    [SerializeField]
    private float speed;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        surfaceSlider = GetComponent<SurfaceSlider>();
    }

    public void Move(Vector3 direction)
    {
        Vector3 directionAlongSurface = surfaceSlider.Project(direction.normalized);
        Vector3 offset = directionAlongSurface * (speed * Time.deltaTime);

        rb.MovePosition(rb.position + offset);
    }
}
