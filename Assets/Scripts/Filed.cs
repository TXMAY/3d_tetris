using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Filed : MonoBehaviour
{
    // 회전
    void Update()
    {
        // Q키 누르면 왼쪽, E키 누르면 오른쪽으로 회전
        if (Input.GetKeyDown(KeyCode.Q))
        {
            gameObject.transform.Rotate(new Vector3(0, -90, 0));
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            gameObject.transform.Rotate(new Vector3(0, 90, 0));
        }
    }
}