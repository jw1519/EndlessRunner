using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    void Update()
    {
        transform.position += new Vector3(-4, 0, 0) * Time.deltaTime;
    }
}
