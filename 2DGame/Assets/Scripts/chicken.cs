using UnityEngine;

public class chicken : MonoBehaviour
{
    [Header("跳高"), Range(-10, 10)]
    public int jumpHight = 0;
    [Header("死亡"),Tooltip("你已死了")]
    public bool isdead;
}
