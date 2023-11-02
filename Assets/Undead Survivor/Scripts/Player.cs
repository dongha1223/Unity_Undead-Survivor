using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public Vector2 inputVec;
    public float speed;

    Rigidbody2D rigid;
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
    }

    void FixedUpdate()
    {
        ControlRaw();
    }

    void OnMove(InputValue value) 
    {
        inputVec = value.Get<Vector2>();
    }
    void ControlRaw()
    {
        Vector2 nextVec = inputVec * speed * Time.fixedDeltaTime;

        rigid.MovePosition(rigid.position + nextVec); //위치이동 방식 (기존 위치 + inputVec을 더하여 원하는 위치로 이동)
    }
}
