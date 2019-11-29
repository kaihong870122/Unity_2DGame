using UnityEngine;

public class chicken : MonoBehaviour
{
    [Header("跳高"), Range(100, 1000)]
    public int jumpHight = 250;
    [Header("旋轉"), Range(10,100)]
    public float angle = 50f;
    [Header("死亡"), Tooltip("你已死了")]
    public bool isdead;
    public GameObject goScore, goGM;
    public Rigidbody2D r2d;   //2D剛體
    public GameManager gm;

    [Header("音效區域")]
    public AudioSource aud;
    public AudioClip soundJump, soundHit, soundPass;

  
    /// <summary>
    /// 小雞跳躍
    /// </summary>
    private void Jump()
    {
        if (isdead) return; //如果已死亡 勾選就跳出
     
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            goScore.SetActive(true);
            goGM.SetActive(true);

            r2d.Sleep();
            r2d.gravityScale = 1;   //地心引力 = 1
            r2d.AddForce(new Vector2(0, jumpHight));  //推力
            aud.PlayOneShot(soundJump);
        }
        r2d.SetRotation(angle * r2d.velocity.y);
    }
    private void Update()
    {
        Jump();
    }
    //碰撞開始事件：物件碰撞開始時執行一次(紀路碰撞物件資訊)
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //print(collision.gameObject.name);  //碰撞,遊戲物件物件.名稱
        Dead();
    }
    //觸發開始事件：物件觸發開始時執行一次(紀錄狀物件資訊),針對有勾選 Is Trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "水管上" || collision.gameObject.name == "水管下")
        
        {
            Dead();
            aud.PlayOneShot(soundHit);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "通過")
        {
            print("加分~~");
            aud.PlayOneShot(soundPass);
            gm.Thesorce();
        }
    }

    /// <summary>
    /// 小雞死亡
    /// </summary>
    private void Dead()
    {
        isdead = true;
        gm.GameOver();
        floor.Ground = 0;
    }
    /// <summary>
    /// 通過水管
    /// </summary>
    private void PassPopi()
    {

    }
}
