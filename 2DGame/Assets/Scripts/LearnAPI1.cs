using UnityEngine;

public class LearnAPI1 : MonoBehaviour
{
    public chicken Chicken;

    private void Start()
    {
        //存放其他欄位
        Chicken.jumpHight = 555;

        //取得其他類別的欄位
        print("小雞跳躍" + Chicken.jumpHight);
    }
}
