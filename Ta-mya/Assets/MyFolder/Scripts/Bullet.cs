using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public bool OnceCheck = true;
    private Vector3 mousePos;
    public float MoveSpeed = 2.0f;
    private Vector3 touchWorldPosition;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // �e�̈ړ�
        this.transform.position = Vector3.MoveTowards(this.transform.position, touchWorldPosition, MoveSpeed * Time.deltaTime);
    }

    public void OnMouseDown()
    {
        // ��񂾂�
        if(OnceCheck == true)
        {
            // �}�E�X�̃|�W�V������Vector3�ɑ��
            Vector3 touchScreenPosition = Input.mousePosition;
            // ���s���̒ǉ�
            touchScreenPosition.z = 60f;
            Camera camera = Camera.main;
            touchWorldPosition = camera.ScreenToWorldPoint(touchScreenPosition);
            OnceCheck = false;
        }

    }
}
