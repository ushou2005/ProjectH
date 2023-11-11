using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float Gender; 
    [SerializeField] float JumpPower;
    [SerializeField] LayerMask Ground;

    Rigidbody rb;

    private bool isJumping; 
    // Start is called before the first frame update
    void Start()
    {
        if (Gender >= 3) return;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //DetectJump();
        if (Gender == 0)
        {
            if (Input.GetKeyDown(KeyCode.J))
            {
                BoyJumps();
            }
        }
        if (Gender == 1)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                GirlJumps();
            }
        }
        //Debug.DrawLine(transform.position,transform.position - transform.up * 1,color:Color.white);
    }
    public void BoyJumps()
    {      
        if (isJumping) return;
        rb.AddForce(Vector3.up * JumpPower, ForceMode.VelocityChange);
    }
   public void GirlJumps() 
    {
        if (isJumping) return;
        rb.AddForce(Vector3.up * JumpPower,ForceMode.VelocityChange);
    }
    //void DetectJump()
    //{
    //    isJumping = Physics2D.Linecast(transform.position,transform.position - transform.up * 0.001f,Ground);
    //}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isJumping = false;
        }
        Debug.Log("run");
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            //isJumping = true;
        }
        Debug.Log("jump");

    }
}
