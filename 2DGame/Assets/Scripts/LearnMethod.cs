using UnityEngine;

public class LearnMethod : MonoBehaviour
{
    //定義方式Method
    //修飾詞 傳回類型 方式名稱(){陳述式、演算法}
    //private public    
    //自訂方式:不會執行，需要呼叫

    //void 無傳回
    private void Test()
    {
        print("測試方法@@");
    }
    //有傳回
    private int Ten()
    {
        return 10;
    }
    private string Hi()
    {
        return "安安";
    }
    //                      參數類型 參數名稱
    private void DriveMethod(float speed)
    {
        print("特效聲音");
        print("開車速度");
        print("開車" + "加速" + " " + speed);
    }
    //                  參數1，參數2，參數3=變數   (有變數的要放在最右邊)
    //quantity數量 property屬性 direction方向
    /// <summary>
    /// 射擊弓箭
    /// </summary>
    /// <param name="count">弓箭數量</param>
    /// <param name="property">弓箭特性</param>
    /// <param name="direction">角色方向，預設為前方</param>
    private void Shoot(int count, string property, string direction = "前方")
    {
        print("弓箭數量：" + count);
        print("弓箭特性：" + property);
        print("主角方向：" + direction);
    }
    private void Start()
    {
        //傳回方式
        Test();

        int a = Ten();
        print("有傳回方式" + a);
        print("有傳回方式" + " " + Ten());
        print("有傳回字串" + " " + Hi());
        DriveMethod(100f);
        Shoot(100, "冰凍");
        Shoot(100, "火焰","左邊");
    }
}
