using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public static Bullet instance;

    public Quaternion firstRotation;
    public float speedY = 100;

    public float deleteTime;

    private Rigidbody rb;
    public float MoveSpeed = 2.0f;
    public GameObject BulletObj;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        firstRotation = transform.rotation;
        Rigidbody rigidbody = GetComponent<Rigidbody>();

        Vector3 movementSpeed = new Vector3(0, speedY, 0);

        movementSpeed = firstRotation * movementSpeed;

        rigidbody.AddForce(movementSpeed);
    }

    // Update is called once per frame
    void Update()
    {

        // íeÇÃà⁄ìÆ
        rb.velocity = transform.forward * MoveSpeed;

        Destroy(gameObject, deleteTime);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
            Debug.Log("Ç∑ÇËî≤ÇØÇΩÅI");
    }

}
