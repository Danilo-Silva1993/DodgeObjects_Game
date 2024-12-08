using UnityEngine;

public class rotate : MonoBehaviour
{

    float xAngle = 0f;
    float yAngle = 1f;
    float zAngle = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xAngle,yAngle,zAngle);
    }
}
