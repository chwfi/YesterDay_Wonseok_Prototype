using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void swordAttack()
    {
        anim.SetTrigger("swordAttack");
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            swordAttack();
        }
    }
    private IEnumerator AttackCo()
    {
        anim.SetBool("Attacking", true);
        yield return null;
        anim.SetBool("Attacking", false);
        yield return new WaitForSeconds(.33f);
        

    }
}
