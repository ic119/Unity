using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
/**
 Unity LifeCycle => 초기화  >  물리(프레임)  >  게임로직(프레임) > 해체
                           ||              ||      
                         활성화     <    비활성화
 **/
{
    void Awake()   // 초기화part => Game Object 생성 시, 최초 실행 함수
    {
        Debug.Log("플레이어의 데이터를 불러옵니다.");
    }
    void OnEnable()  // 활성화part => Game Object가 활성화 되었을 때 실행되는 함수
    {
        Debug.Log("플레이어가 로그인하였습니다.");
    }
    void Start()   // 초기화part => Update 시작 직전, 최초 실행 함수
    {
        Debug.Log("던전 준비를 마쳤습니다.");
    }

    private void FixedUpdate()  // 물리part => 물리 연산 Update함수
    // FixedUpdate() 특징 : 고정된 실행 주기로 CPU사용多 (약 1초에 50회 실행)
    {
        Debug.Log("해당 던전으로 이동...");
    }
    void Update()  // 게임로직part => 게임 로직 Update
    // Update() 특징 : 물리연산로직을 제외한 주기적인 로직 사용(환경에 따라 실행주기 변동)
    {
        Debug.Log("사냥 시작!");
    }

    void LateUpdate()  // 모든 Update 끝난 후 실행되는 함수
    // LateUpdate() 특징 : 모든 Update영역 로직이 끝난 후 호출됨(ex : 로직후처리, 캐릭터시점처리)
    {
        Debug.Log("경험치 획득");
    }
    void OnDisable()  // 비활성화part => Game Object가 비활성화 또는 삭제될 때 실행
    {
        Debug.Log("플레이어가 로그아웃하였습니다.");
    }

    void OnDestroy()  // 해체part =>Game Object가 삭제될 때 실행되는 함수
    // OnDestroy() 특징 : Object 삭제 시 무언가를 남기고 삭제
    {
        Debug.Log("플레이어의 데이터를 종료합니다.");
    }
}
