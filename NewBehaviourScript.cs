using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
    // MonoBehaviour => 유니티 게임오브젝트 클래스
{
    // 전역변수(= 멤버변수) => 함수 바깥에 선언된 변수
    int health = 50;
    int mana = 50;
    int level = 1;
    void Start()
    {
        // 1. 변수선언 및 초기화
        // 지역변수 => 함수 내에 선언된 변수
        float strength= 10.0f;
        string playerName = "Player1";
        bool isFullLevel = false;

        /**
        Debug.Log("플레이어 이름은?");
        Debug.Log(playerName);
        Debug.Log("플레이어 레벨은?");
        Debug.Log(level);
        Debug.Log("플레이어 스탯은?");
        Debug.Log(strength);
        Debug.Log("플레이어는 최대레벨인가?");
        Debug.Log(isFullLevel);
        **/
        // 2. 그룹형 변수
        string[] monsters = { "슬라임", "더스트스네이크", "발록" };
        int[] monsterLevel = new int[3];
        monsterLevel[0] = 5;
        monsterLevel[1] = 15;
        monsterLevel[2] = 80;

        /** 
         Debug.Log("출현 몬스터와 레벨");
         Debug.Log(monsters[0] + monsterLevel[0]);
         Debug.Log(monsters[1] + monsterLevel[1]);
         Debug.Log(monsters[2] + monsterLevel[2]);
        **/

        //3. 제네릭
        List<string> items = new List<string>();
        items.Add("체력포션 30");
        items.Add("마나포션 30");
        items.Add("롱소드");

        //items.RemoveAt(1);
        // 리스트 목록 삭제

        /**
        Debug.Log("소유아이템 목록");
        Debug.Log(items[0]);
        Debug.Log(items[1]);
        Debug.Log(items[2]);
        **/

        //4. 연산자
        
        /**
        Debug.Log("플레이어 경험치?");
        Debug.Log(exp);
        Debug.Log("플레이어 레벨은?");
        Debug.Log(level);
        Debug.Log("플레이어 힘 스탯은?");
        Debug.Log(strength);
        Debug.Log("다음 레벨까지 남은 경험치는?");
        Debug.Log(nextExp);
        **/

        /**
        string title = "베타테스터";
        Debug.Log("플레이어 타이틀은?");
        Debug.Log(title + " " + playerName);
        **/

        int fullLevel = 100;
        isFullLevel = level == fullLevel;
        Debug.Log("플레이어는 최대레벨인가?" + isFullLevel);

        // 10레벨 초과 튜토리얼 클리어
        bool isEndTutorial = level > 10;
        Debug.Log("튜토리얼이 끝난 레벨인가요?" + isEndTutorial);

        /**
        bool isBadCondition = health <= 50 && mana <= 20;
        Debug.Log("플레이어 상태는?" + isBadCondition);
        **/
        bool isBadCondition = health <= 50 || mana <= 20;

        string condition = isBadCondition ? "나쁨" : "좋음";
        // ?A:B: true일때 A, false일때 B출력 =>삼항연산자
        Debug.Log("플레이어 상태는?" + condition);

        // 5. 키워드 : 프로그래밍 언어를 구성하는 특별한 의미

        // 6. 조건문 if
        
        if (condition == "나쁨")
        {
            Debug.Log("캐릭터 체력이 없으니 아이템을 사용하세요!");
        } else
        {
            Debug.Log("아이템을 사용할 필요가 없습니다.");
        }
        
        if(isBadCondition && items[0] == "체력포션 30")
        {
            items.RemoveAt(0);
            health += 30;
            Debug.Log("체력포션 30(을)를 사용" + "현재 체력 : " + health);
        } else if (isBadCondition && items[1] == "마나포션 30")
        {
            items.RemoveAt(0);
            mana += 50;
            Debug.Log("마나포션 30(을)를 사용" + "현재 마나 : " + mana);
        }

        // 6-2. 조건문 switch, case
        switch(monsters[2]) {
            case "슬라임" :
                Debug.Log("소형몬스터 출현");
                break;
            case "더스트스네이크":
                Debug.Log("중형몬스터 출현");
                break;
            case "발록":
                Debug.Log("필드보스 몬스터 출현!");
                break;
            default :
                Debug.Log("???몬스터 출현");
                break;
        }

        // 7. 반복문 while
        while(health > 0)
        {
            health--;
            if (health > 0)
                Debug.Log("독에 중독되었습니다." + "현재 체력 : " + health);
            else
                Debug.Log("Game Over");
            if (health == 10)
                Debug.Log("해독제 (을)를 사용");
            break;
        }
        
        // 7-2. 반복문 for
        for(int count = 0; count < 10; count++)
        {
            health++;
            Debug.Log("체력 회복중... +" + count + health);
        }
        
        // 그룹형변수 길이 : .Longth => 배열, .Count => 리스트
        for(int index=0; index < monsters.Length; index++)
        {
            Debug.Log("이 지역에 있는 몬스터 : " + monsters[index]);
        }

        // 7-3. 반복문 foreach => for문의 그룹형변수 탐색 특화
        foreach(string monseter in monsters)
        {
            Debug.Log("출현가능 몬스터 : " + monseter);
        }

        // 함수 호출 후 사용
        health = Heal(health);
        Heal2();

        for (int index = 0; index < monsters.Length; index++)
        {
            Debug.Log("플레이어는 " + monsters[index] + " 에게 " + Battle(monsterLevel[index]));
        }

        // 9. 클래스 => 하나의 오브젝트와 대응하는 로직
        Player player = new Player();   // 상속관계 성립
        // 인스턴스 => 정의된 클래스를 변수초기화로 실체화
        player.id = 0001;
        player.name = "HORI";
        player.level = 20;
        player.strength = 25.0f;
        player.title = "BetaTester";
        player.weapon = "롱소드";
        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());

        player.LevelUp();
        Debug.Log(player.name + "의 레벨은 " + player.level + "입니다.");
        Debug.Log(player.login());

    }
    // 8. 함수 => 여러가지 기능을 편리하게 사용하도록 구성된 영역
    int Heal(int currentHealth)
    {
        currentHealth += 10;
        Debug.Log("힐링효과발동 : " + currentHealth);
        return currentHealth;
    }

    void Heal2()
    {
        health += 10;
        Debug.Log("힐을 받았습니다. : " + health);
    }

    string Battle(int monsterLevel)
    {
        string result;
        if (level >= monsterLevel)
            result = "전투 승리";
        else
            result = "전투 패배";
        return result;
    }
}
