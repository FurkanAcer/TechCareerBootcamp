using System;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Animator _animator;
    private float Speed = 4.0f;
    
    void Start()
    {
        _animator = GetComponent<Animator>();
    }
    
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            float TargetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;

            transform.rotation = Quaternion.Euler(0f, TargetAngle, 0f).normalized;
            Vector3 moveDirection = Quaternion.Euler(0f, TargetAngle, 0f).normalized * Vector3.forward;
            transform.position += moveDirection.normalized * (Speed * Time.deltaTime);
            _animator.SetBool("isWalking", true);
        } 
        else
        {
            _animator.SetBool("isWalking", false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _animator.SetBool("isJumping", true);
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            _animator.SetBool("isJumping", false);
        }

    }
}