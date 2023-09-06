using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animwalkandjump : MonoBehaviour
{
      Animator animator;
      int yurume, ziplama;
      void Start()
    {
        animator = GetComponent<Animator>();
        yurume = Animator.StringToHash("yurume");
        ziplama = Animator.StringToHash("ziplama");
    }
    void Update()
    {
        bool yuruyor = animator.GetBool(yurume);
        bool zipliyor = animator.GetBool(ziplama);
        bool yurumeBasla = Input.GetKey("w");
        bool ziplamaBasla = Input.GetKey("space");

        if(!yuruyor && yurumeBasla)
        {
            animator.SetBool(yurume, true);
        }
        if (yuruyor && !yurumeBasla)
        {
            animator.SetBool(yurume, false);
        }
        if (!zipliyor && ziplamaBasla)
        {
            animator.SetBool(ziplama, true);
        }
        if (zipliyor && !ziplamaBasla)
        {
            animator.SetBool(ziplama, false);
        }
    }
}
