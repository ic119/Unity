using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{
    Rigidbody rigid;
    void Start()
    {
        rigid = GetComponent<Rigidbody>();

        //rigid.AddForce(Vector3.up * 5,ForceMode.Impulse);
        // 주로 캐릭터 점프할 때 사용
        // ForceMode(가속, 무게 반영)
        
    }
    void FixedUpdate()
        // rigid관련 함수사용
    {
        // 1. 속도 올리기
        // rigid.velocity = new Vector3(3, 0, 0);

        // 2. 힘 가하기
        
        if(Input.GetButtonDown("Jump"))
            // 캐릭터 더블점프 사용 예제
        {
            rigid.AddForce(Vector3.up * 0.1f, ForceMode.Impulse);
        }
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        rigid.AddForce(vec, ForceMode.Impulse);
    
        // 3. 회전력 올리기
        // AddTorque(Vec) : Vec방향 축으로 회전력 생성
        //rigid.AddTorque(Vector3.back);
    }



    /**
    Collider 충돌로 발생하는 Event
    void OnTriggerEnter(Collider other) {}
    void OnTriggerStay(Collider other) {}
    void OnTriggerExit(Collider other) {}
    **/
    private void OnTriggerStay(Collider other)
        // OnTriggerStay() => Collider가 계속 충돌하고 있을 때 호출
    {
        if(other.name == "EventCube")
        {
            rigid.AddForce(Vector3.up * 2, ForceMode.Impulse);
            // 에어본 효과
        }
    }

    public void Jump()
    {
        rigid.AddForce(Vector3.up * 10, ForceMode.Impulse);
    }
}
