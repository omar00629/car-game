using UnityEngine;

public class CarController : MonoBehaviour
{
    public float speed = 10f;
    public float turnSpeed = 50f;
    public bool useTiltControl = false;

    private void Update()
    {
        float move = speed * Time.deltaTime;
        float steer = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

        if (useTiltControl)
            steer = Input.acceleration.x * turnSpeed * Time.deltaTime;

        transform.Translate(0, 0, move);
        transform.Rotate(0, steer, 0);
    }
}