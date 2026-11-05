using UnityEngine;

public class Lesson09 : MonoBehaviour
{
    public int attack = 10;  // 필드
    int killCount = 0;       // 필드

    [ContextMenu("처치")]
    void CountKill()
    {
        int defense = 3;     // 지역 변수
        killCount = killCount + 1;
        Debug.Log(attack - defense);
        Debug.Log(killCount);
    }

    public int gold = 100;
    public int potion = 3;
    [ContextMenu("골드 보기")]
    void ShowGold()
    {
        Debug.Log(gold);
    }

    [ContextMenu("예측 1")]
    void Predict1()
    {
        int hp = 10;
        hp = hp - 3;
        Debug.Log(hp);
        hp = 20;
        Debug.Log(hp);
        int maxHp = hp;
        hp = 5;
        Debug.Log(maxHp);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
