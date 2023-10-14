using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

/// <summary>
/// �v���C���[�̓����𐧌䂷��X�N���v�g
/// </summary>
public class PlayerController : MonoBehaviour
{
    [SerializeField] float Gender; //boy��girl�𔻕ʂ���ϐ��@0:boy�@1:girl
    [SerializeField] float JumpPower; //�W�����v��

    Rigidbody rb;

    private bool isJumping; //�W�����v���𔻒肷��
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
