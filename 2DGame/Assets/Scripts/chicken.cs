using UnityEngine;

public class chicken : MonoBehaviour
{
    [Header("跳高"), Range(-10, 10)]
    public int jumpHight = 0;
    [Header("死亡"),Tooltip("你已死了")]
    public bool isdead;

    /// <summary>
    /// 小雞跳躍
    /// </summary>
    private void Jump()
    {
        
    }
    /// <summary>
    /// 小雞死亡
    /// </summary>
    private void Dead()
    {

    }
    /// <summary>
    /// 通過水管
    /// </summary>
    private void PassPopi()
    {

    }
}
