using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

/// <summary>
/// プレイヤーの動きを制御するスクリプト
/// </summary>
public class PlayerController : MonoBehaviour
{
    [SerializeField] float Gender; //boyとgirlを判別する変数　0:boy　1:girl
    [SerializeField] float JumpPower; //ジャンプ力

    Rigidbody rb;

    private bool isJumping; //ジャンプ中を判定する
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
                BoyJump();
                isJumping = true;
            }
        }
<<<<<<< HEAD
        if (Input.GetKeyDown(KeyCode.F) && CompareTag("Girl") && !isGirlJumping)
        {
            isGirlJumping = true;
            transform.position += new Vector3(0, 1, 0);
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
    public void BoyJumps()
    {
        if (!isBoyJumping)
=======
        if (Gender == 1)
>>>>>>> main
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                GirlJump();
                isJumping = true;
            }
        }
    }
    public void BoyJump()
    {      
        if (isJumping) return;
        rb.AddForce(Vector3.up * JumpPower, ForceMode.VelocityChange);
        isJumping = true;
    }
   public void GirlJump() 
    {
        if (isJumping) return;
        rb.AddForce(Vector3.up * JumpPower,ForceMode.VelocityChange);
        isJumping = true;
    }
<<<<<<< HEAD
=======
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isJumping = false;
        }
    }
>>>>>>> main
}
