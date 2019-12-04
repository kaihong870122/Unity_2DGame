using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("目前分數")]
    public int score;
    [Header("最高分數")]
    public int bestScore;
    [Header("水管群組")]
    public GameObject pipe;  //GameObject 可存場景上的物件或是預制物
    [Header("結束畫面")]
    public GameObject goFinal;
    public Text textScore;
    public Text textHeight;
    /// <summary>
    /// 設定目前分數
    /// </summary>
    /// <param name="sorce">每次加分為1</param>
    public void Thesorce(int add = 1)
    {
        score = score + add;
        textScore.text = score.ToString();

        Thebestscore();
    }
    /// <summary>
    /// 設定最高分數
    /// </summary>
    private void Thebestscore()
    {
        if (score > bestScore)
        {
            PlayerPrefs.SetInt("最佳分數", score);
        }
    }
    public void GameOver()
    {
        goFinal.SetActive(true);
        CancelInvoke("SpwanPipe");
    }
    /// <summary>
    /// 設置生成水管
    /// </summary>
    public void SpwanPipe()
    {
        //Vector3 p = new Vector3 (4, y, 0);三圍向量 制定水管三圍位置
        float y = Random.Range(-1.5f, 1.3f);
        Vector3 p = new Vector3 (4, y, 0);
        //     實例化      物件 位置 角度
        Object.Instantiate(pipe,p,Quaternion.identity);
        //Quaternion.identity 零角度
    }

    public void Start()
    {
        //設置水管
        //SpwanPipe();
        //延遲水管時間
        //Invoke ("SpwanPipe", 1.5f);
        //延遲水管時間並且無限複製水管
        InvokeRepeating("SpwanPipe", 0, 2.25f);
        bestScore = PlayerPrefs.GetInt("最佳分數");
        textHeight.text = bestScore.ToString();        
    }
    /// <summary>
    /// 重新開始
    /// </summary>
    public void reaple()
    {
        print("重新開始");
        SceneManager.LoadScene("遊戲場景");
    }
    /// <summary>
    /// 離開遊戲
    /// </summary>
    public void exit()
    {
        print("離開遊戲");
        Application.Quit();
    }

}

