using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float forceEmpuje;
    private Quaternion rotation;
    [SerializeField] private float speedRotation;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
    }


    private void QuaternionRotation()
    {
       
        //rb.rotation = transform.rotation * Quaternion.Euler(Vector3.forward * )
    }
    public void pushUP()
    {

        rb.AddForce(Vector3.up * forceEmpuje, ForceMode.Impulse);
        Physics.gravity = new Vector3(0, -10, 0);
        rotation = Quaternion.Euler(0, 0, speedRotation * Time.deltaTime);
        transform.rotation = rotation * transform.rotation;

    }

    public void pushDown()
    {
        rb.AddForce(Vector3.down * forceEmpuje);
        Physics.gravity = new Vector3(0, 10, 0);
        speedRotation *= -1;
    }

    
}
