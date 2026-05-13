using UnityEngine;

public class CylinderSpin : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0, 0, 200 * Time.deltaTime);
    }
}