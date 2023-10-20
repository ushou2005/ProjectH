using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float Gender; //boy??girl???????????????@0:boy?@1:girl
    [SerializeField] float JumpPower; //?W?????v??

    Rigidbody rb;

    private bool isJumping; //?W?????v????????????
    // Start is called before the first frame update
    void Start()
    {
        if (Gender >= 3) return;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Gender >= 3) return;
        if (isJumping) return;
        if (Gender == 0)
        {
            if (Input.GetKeyDown(KeyCode.J))
            {
                BoyJumps();
                isJumping = true;
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                GirlJumps();
                isJumping = true;
            }
        }
        
    }
    public void BoyJumps()
    {      
        if (isJumping) return;
        rb.AddForce(Vector3.up * JumpPower, ForceMode.VelocityChange);
        isJumping = true;
    }
   public void GirlJumps() 
    {
        if (isJumping) return;
        rb.AddForce(Vector3.up * JumpPower,ForceMode.VelocityChange);
        isJumping = true;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isJumping = false;
        }
    }
}
