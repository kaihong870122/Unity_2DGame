using UnityEngine;
//可繼承 類別 所有的動作
public class Pipe : floor
{
    //在所有攝影機看不到時執行一次
    private void OnBecameInvisible()
    {
        Destroy(gameObject, 3f);
    }
    //在所有攝影機看到時執行一次
    private void OnBecameVisible()
    {
        
    }
}
