using UnityEngine;
//可繼承 類別 所有的動作
public class Pipe :floor
{
    private void Start()
    {
        //刪除(此遊戲物件，延遲4秒)
        Destroy(gameObject,4f);
    }

}
