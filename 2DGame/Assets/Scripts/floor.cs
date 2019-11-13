using UnityEngine;

public class floor : MonoBehaviour
{
    [Header("速度"), Range(-0.1f, 10f)]
    public float Ground = 1f;

    public Transform ground;
    private void Update()
    {
        ground.Translate(-0.05f,0,0);
    }
}
