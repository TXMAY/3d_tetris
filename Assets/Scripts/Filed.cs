using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Filed : MonoBehaviour
{
    // ȸ��
    void Update()
    {
        // QŰ ������ ����, EŰ ������ ���������� ȸ��
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