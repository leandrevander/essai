using UnityEngine;

public class LockZ : MonoBehaviour
{
    void LateUpdate()
    {
        Vector3 pos = transform.position;
        pos.z = 0f;
        transform.position = pos;
    }
}

