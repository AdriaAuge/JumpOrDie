using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag== "Player")
        {
            anim.SetTrigger("explosion");
            StartCoroutine("Destroy");
        }
    }

    private IEnumerator Destroy()
    {
        yield return new WaitForSeconds(0.4f);
        Destroy(gameObject);
    }
}
