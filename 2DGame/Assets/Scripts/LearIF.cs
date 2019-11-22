using UnityEngine;

public class LearIF : MonoBehaviour
{
    public bool open;
    public int score;
    private void Start()
    {
        if (true)
        {
            print("嗨!");
        }
        if (open)
        {
            print("開門~");
        }
        else
        {
            print("關門~");
        }

        if (score >= 60)
        {
            print("及格");
        }
        else if (score >= 40) 
        {
            print("補考");
        }
        else
        {
            print("被當了");
        }
    }
}
