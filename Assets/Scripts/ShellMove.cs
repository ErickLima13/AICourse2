using UnityEngine;

public class ShellMove : MonoBehaviour
{
    public float speed = 1;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, (speed * Time.deltaTime) / 2.0f, speed * Time.deltaTime);
    }
}
