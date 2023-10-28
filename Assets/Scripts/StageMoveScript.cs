using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageMoveScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-2f * Time.deltaTime, 0, 0);
        if (transform.position.x < -17.78)
        {
            transform.position += new Vector3(17.78f, 0, 0);
        }
    }
}
