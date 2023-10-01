using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject boy;
    public GameObject girl;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J) && CompareTag("Boy"))
        {
            transform.position += new Vector3(0, 1, 0);
        }
        if (Input.GetKeyDown(KeyCode.F) && CompareTag("Girl"))
        {
            transform.position += new Vector3(0, 1, 0);
        }
    }
    public void BoyJumps()
    {
        boy.transform.position += new Vector3(0, 1, 0);
    }
    public void GirlJumps()
    {
        girl.transform.position += new Vector3(0, 1, 0);
    }
}
