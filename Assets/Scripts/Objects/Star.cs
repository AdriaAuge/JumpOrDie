using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            StartCoroutine("Destroy");
        }
    }

    private IEnumerator Destroy()
    {
        yield return new WaitForSeconds(0.1f);
        Destroy(gameObject);
    }
}
