using UnityEngine;

public class ParkingManager : MonoBehaviour
{
    public GameObject parkingZone;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") &&
            Vector3.Distance(other.transform.position, parkingZone.transform.position) < 2f)
        {
            Debug.Log("Perfect Parking!");
        }
    }
}