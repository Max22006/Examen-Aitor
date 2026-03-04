using UnityEngine;

public class GroundSensor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public bool isGrounded;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        isGrounded = GetComponentInChildren<GroundSensor>();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            isGrounded = true;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            isGrounded = false;
        }
    }
}
