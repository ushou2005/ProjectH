using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundController : MonoBehaviour
{
    // 背景スクロール
    void Update()
    {
        transform.Translate(-2f * Time.deltaTime, 0, 0);
        if(transform.position.x < -20)
        {
            transform.position += new Vector3(20, 0, 0);
        }
    }
}
