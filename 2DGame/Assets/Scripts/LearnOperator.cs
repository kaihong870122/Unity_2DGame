using UnityEngine;

public class LearnOperator : MonoBehaviour
{
    public int a = 100, b = 3;
    public int c = 20 , d = 10;
    public int coin;
    public int gold;
    private void Start()
    {
        #region 數學運算式
        print(a + b);
        print(a - b);
        print(a * b);
        print(a / b);
        print(a % b);
        //=指定方向
        a = a + 100;
        print(a);
        print(a++);//先輸出在+1
        print(++a);//先+1在輸出
        a = a + 100;
        a += 10;
        print(a);
        //比較運算式 傳回布林值
        print(a > b);     // 大於
        print(c < d);     // 小於
        print(a >=b);    // 大於等於
        print(c <= d);    // 小於等於
        print(a == b);    // 等於
        print(c != d);    // 不等
        //邏輯運算式 傳回 true flase
        // 並且 && shift + 7        
        //print(boolA && boolB);  // 只要有一個 false 結果為 false
        print(true && true);    // ture
        print(true && false);   // false
        print(false && true);   // false
        print(false && false);  // false
        // 或者 || shift + 鎮
        //print(boolA || boolB);  // 只要有一個 true 結果為 true
        print(true || true);    // true
        print(true || false);   // true
        print(false || true);   // true
        print(false || false);  // flase
        //相反 !
        print(!false);
        //需要10個金幣或是5個黃金
        //true > 過關 flase > 沒過關
        print(coin >= 10 || gold >= 5);
  
        #endregion
    }
    

}
