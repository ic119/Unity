using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubBall : MonoBehaviour
{
    MeshRenderer mesh;
    Material mat;
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }

    private void OnCollisionEnter(Collision collision)
    // Collision => 충돌 정보 클래스
    // 물리적 충돌이 시작할 때 호출되는 함수

    /**
    실제 물리적인 충돌로 발생하는 이벤트
    void OnCollisionEnter(Collision collision) {}
    void OnCollisionStay(Collision collision) {}
    void OnCollisionExit(Collision collision) {}
     **/
    {
        if (collision.gameObject.name == "MainBall")
        {
            mat.color = new Color(0, 0, 0);
        }
        
    }
    private void OnCollisionExit(Collision collision)
    // 물리적 충돌이 끝났을 때 호출되는 함수
    {
        if (collision.gameObject.name == "MainBall")
        {
            mat.color = new Color(1, 1, 1);
        }
    }
    /**
    private void OnCollisionStay(Collision collision)
        // 물리적 충돌이 유지될 때 호출되는 함수
    {
        
    }
    **/
}
