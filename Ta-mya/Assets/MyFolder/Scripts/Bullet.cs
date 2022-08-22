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
        // 弾の移動
        this.transform.position = Vector3.MoveTowards(this.transform.position, touchWorldPosition, MoveSpeed * Time.deltaTime);
    }

    public void OnMouseDown()
    {
        // 一回だけ
        if(OnceCheck == true)
        {
            // マウスのポジションをVector3に代入
            Vector3 touchScreenPosition = Input.mousePosition;
            // 奥行きの追加
            touchScreenPosition.z = 60f;
            Camera camera = Camera.main;
            touchWorldPosition = camera.ScreenToWorldPoint(touchScreenPosition);
            OnceCheck = false;
        }

    }
}
