using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Basic : MonoBehaviour
// 키보드 및 마우스로 Object 이동
// Transform : Object형태에 대한 기본 Component
/**
 입력 행동 구분 : 1) Key를 눌렀을 때 => Down
                 2) Key를 누르고 있을 때 => Stay
                 3) Key를 떼었을 때 => Up
 **/
{
    void Start()
    {

    }

    void Update()
    {
        // Input : 게임 내 입력 관리하는 Class
        // anyKeyDown : 아무 입력을 최초로 받을 때 true
        // anyKey : 아무 입력을 받으면  true
        // GetKey : 키보드 버튼 입력을 받으면 true
        
        Vector3 vec = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"),0);  // 벡터 값(Vector)
         
        //Translate() : Vector값을 현재 위치에 더하는 함수
        transform.Translate(vec);

        /**
        if (Input.anyKeyDown)
        {
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");
        }
        if(Input.GetButton("Horizontal"))
        // GetAxis : 수평이나 수직 버튼 입력 받으면 float값 반환
        // Object는 변수 transform을 항상 소유
        {
            //Debug.Log("횡이동중..." + Input.GetAxis("Horizontal"));
            Debug.Log("횡이동중..." + Input.GetAxisRaw("Horizontal"));
        }
        **/
        /**
        if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("아이템을 구입하였습니다.");
            // enter키 입력 시 반응
            // ESC키 => KeyCode.Escape
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("좌측으로 이동");
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("우측으로 이동");
        }
        **/
        /**
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("공격!");
        }
        if (Input.GetMouseButton(0))
        {
            Debug.Log("공격차지!");
        }
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("특수공격!");
        }
        **/
        /**
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("점프!");
        }
        if (Input.GetButton("Jump"))
        {
            Debug.Log("점프차지!");
        }
        if (Input.GetButtonUp("Jump"))
        {
            Debug.Log("특수점프!");
        }
        **/
    }
}
