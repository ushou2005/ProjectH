using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class PlayerController : MonoBehaviour
{
    //[SerializeField] float Gender; 
    [SerializeField] float JumpPower;
    [SerializeField] LayerMask Ground;

    [SerializeField] GameObject boy;
    [SerializeField] GameObject girl;

    Rigidbody rb;

    private bool isJumping;

    private int hp = 3;
    public GameObject hp0;
    public GameObject hp1;
    public GameObject hp2;
    // Start is called before the first frame update
    void Start()
    {
        //if (Gender >= 3) return;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //DetectJump();
       if (Input.GetKeyDown(KeyCode.J))
        {
            BoyJumps();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            GirlJumps();
        }
        //Debug.DrawLine(transform.position,transform.position - transform.up * 1,color:Color.white);

        if (hp == 2) hp2.SetActive(false);
        if (hp == 1) hp1.SetActive(false);
        if (hp == 0) hp0.SetActive(false);
    }
    public void BoyJumps()
    {      
        if (isJumping) return;
        rb.AddForce(Vector3.up * JumpPower, ForceMode.VelocityChange);
        isJumping = true;
        Debug.Log("BoyJumps");
    }
    public void GirlJumps() 
    {
        if (isJumping) return;
        rb.AddForce(Vector3.up * JumpPower,ForceMode.VelocityChange);
        isJumping = true;
        Debug.Log("GirlJumps");
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
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("hit");
            hp--; 
        }
    }
    //private void OnCollisionExit(Collision collision)
    //{
    //    if (collision.gameObject.tag == "Ground")
    //    {
    //        Invoke("JumpSafety", 0.1f);
    //    }
    //    Debug.Log("jump");
    //}
    //void JumpSafety()
    //{
    //    isJumping = true;
    //}
}
