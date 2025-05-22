using UnityEngine;

public class JumpPlate : MonoBehaviour
{
    public GameObject spring;
    public float jumpForce = 200f;

    private void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
        if (rb != null)
        {
            //rb.velocity = Vector3.zero;  // force = 0
            rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.z);
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
