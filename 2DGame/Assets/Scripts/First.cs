using UnityEngine;      //使用 Unity API
//類別、類別名稱
public class First : MonoBehaviour
{
    [Header("金幣"),Range(300,9999)]
    public int coin = 300;        //整數
    [Header("數度"), Range(0.01f, 99.5f)]
    public float speed = 1.35f;    //浮點數
    [Header("物品"), Tooltip("還不喝藥水阿d1")]
    public string prop = "藥水";    //字串
    [Header("狀態"),Tooltip("你死了啦e04")]
    public bool dead = true;      //布林值

    private void Start()
    {
        print("開始遊戲,不要混了");
    }

    private void Update()
    {
        print("哈囉" + ",開始了");
    }
}//程式內容