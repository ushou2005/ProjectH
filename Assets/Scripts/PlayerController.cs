using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject boy;
    public GameObject girl;
    bool isBoyJumping = false;
    bool isGirlJumping = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J) && CompareTag("Boy") && !isBoyJumping)
        {
            isBoyJumping = true;
            transform.position += new Vector3(0, 1, 0);
        }
        if (Input.GetKeyDown(KeyCode.F) && CompareTag("Girl") && !isGirlJumping)
         {
            isGirlJumping = true;
            transform.position += new Vector3(0, 1, 0);
         }
        
    }
    public void BoyJumps()
    {
        if (!isBoyJumping)
        {
            isBoyJumping = true;
            boy.transform.position += new Vector3(0, 1, 0);
        }
    }
    public void GirlJumps()
    {
        if (!isGirlJumping)
        {
            isGirlJumping = true;
            girl.transform.position += new Vector3(0, 1, 0);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground" && CompareTag("Boy"))
        {
            isBoyJumping = false;
        }
        if (collision.gameObject.tag == "Ground" && CompareTag("Girl"))
        {
            isGirlJumping = false;
        }
    }
}
