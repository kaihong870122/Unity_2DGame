using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("目前分數")]
    public int sorce;
    [Header("最高分數")]
    public int bestSorce;
    [Header("水管群組")]
    public GameObject pipe;  //GameObject 可存場景上的物件或是預制物
    /// <summary>
    /// 設定目前分數
    /// </summary>
    /// <param name="sorce">每次加分為1</param>
    private void Thesorce(int sorce = 1)
    {

    }
    /// <summary>
    /// 設定最高分數
    /// </summary>
    private void Thebestsorce()
    {

    }
    /// <summary>
    /// 設置生成水管
    /// </summary>
    private void SpwanPipe()
    {
        //Vector3 p = new Vector3 (4, y, 0);三圍向量 制定水管三圍位置
        float y = Random.Range(-1.5f, 1.3f);
        Vector3 p = new Vector3 (4, y, 0);
        //     實例化      物件 位置 角度
        Object.Instantiate(pipe,p,Quaternion.identity);
        //Quaternion.identity 零角度
    }

    private void Start()
    {
        //設置水管
        //SpwanPipe();

        //延遲水管時間
        //Invoke ("SpwanPipe", 1.5f);

        //延遲水管時間並且無限複製水管
        InvokeRepeating("SpwanPipe", 0, 2.25f);
        
    }
}
