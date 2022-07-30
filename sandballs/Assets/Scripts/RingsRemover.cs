using UnityEngine;

[RequireComponent(typeof(Collider))]
public class RingsRemover : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ring"))
        {
            Destroy(other.gameObject);
        }
    }
}
