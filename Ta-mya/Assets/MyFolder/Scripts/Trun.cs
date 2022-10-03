using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trun : MonoBehaviour
{
    public float turnSpeed;
    private Rigidbody rb;
    private float turnInputValue;

    // 角度制限
    private float currentAngleY;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        var forSpeed = Vector3.Dot(rb.velocity, transform.forward).ToString("0");

        if (Input.GetKey(KeyCode.LeftShift))
        {
            rb.velocity += transform.forward * 0.3f;
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, 30);
        }

        if (Input.GetKey(KeyCode.RightShift))
        {
            rb.velocity -= transform.forward * 0.2f;
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            rb.velocity = Vector3.zero;
        }

        TankTurn();

        // 角度制限
        // 現在の角度の取得
        currentAngleY = transform.localEulerAngles.y;

        // 角度制限
        // 角度が-180〜180の範囲内になるように補正
        if (currentAngleY > 180)
        {
            currentAngleY = currentAngleY - 360;
        }

        // 角度制限
        // Clam関数を使って、-45度から45度の範囲内に制限
        currentAngleY = Mathf.Clamp(currentAngleY, -30, 30);
        transform.localEulerAngles = new Vector3(0, currentAngleY, 0);
    }

    void TankTurn()
    {
        //turnInputValue = Input.GetAxisRaw("Horizontal");

        //transform.Rotate(new Vector3(0, turnInputValue, 0));
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, 0.5f, 0));
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, -0.5f, 0));
        }
    }
}
