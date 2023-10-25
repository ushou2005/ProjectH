using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusPositionController : MonoBehaviour
{
    public float gameLength = 60f;
    public float barLength = 17.76f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-8.65f, -0.26f, -0.1f);
    }

        // Update is called once per frame
        void Update()
    {
        transform.position += new Vector3(barLength/gameLength * Time.deltaTime,0,0);
    }
}
