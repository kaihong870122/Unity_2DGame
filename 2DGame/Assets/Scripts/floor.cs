using UnityEngine;

public class floor : MonoBehaviour
{
    [Header("速度"), Range(0.01f, 10f)]
    public float Ground = 1f;

    public Transform ground;
    /// <summary>
    /// 地板移動
    /// </summary>
    private void Move()
    {
        //以上方定義的名詞來做偵數變化
        //Time.deltaTime 一個影格的時間(根據電腦效能不同)
        ground.Translate(-Ground * Time.deltaTime, 0, 0);
    }
    private void Update()
    {
        Move();
    }
}
