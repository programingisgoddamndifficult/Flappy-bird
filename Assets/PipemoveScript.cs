using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipemoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -45;//管子到达该位置后 从内存中删除
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;//Time.deltaTime确保不同帧率下速度一样
        if(transform.position.x<deadZone)
        {
            Debug.Log("Pipe destroyed");
            Destroy(gameObject);
        }
    }
}
