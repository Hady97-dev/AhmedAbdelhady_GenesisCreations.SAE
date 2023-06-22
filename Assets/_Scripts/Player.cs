using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public float Speed;
    public Animator anim;
    public Rigidbody rb;
    public GameObject ShowButton;
  
    public GameObject AnimCamera;
    public float AnimCamAngle;

    public AudioSource attackSound;
    public AudioSource JumpingSound;

    public void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    public void FixedUpdate()
    {
          
        if (Input.GetKey(KeyCode.Space) )
        {
            Attack();
        }
       
    }

    IEnumerator AttackDuration(int secs)
    {
        yield return new WaitForSeconds(secs);
        anim.SetBool("IsAttacking", false);

    }
    IEnumerator JumpingDuration(int secs)
    {
        yield return new WaitForSeconds(secs);
        anim.SetBool("IsJumping", false);
        AnimCamera.SetActive(false);
    }

    public void Attack()
    {
        StartCoroutine(AttackDuration(2));
        anim.SetBool("IsAttacking", true);
        attackSound.Play();
    }

    public void AttackAndJump()
    {
        StartCoroutine(JumpingDuration(3));
        anim.SetBool("IsJumping", true);
        AnimCamera.SetActive(true);
        AnimCamera.transform.RotateAround(gameObject.transform.position, transform.position, AnimCamAngle);
        JumpingSound.Play();
    }
    public void Hide()
    {
        gameObject.SetActive(false);
        ShowButton.SetActive(true);
    }
    public void Show()
    {
        gameObject.SetActive(true);
        ShowButton.SetActive(false);

    }



}
