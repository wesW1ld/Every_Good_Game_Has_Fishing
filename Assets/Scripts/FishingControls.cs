using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingControls : MonoBehaviour
{
    float start; //-253
    float end; //244;

    public float speed;

    Rigidbody2D rb;

    void Start()
    {
        start = transform.position.y;
        rb = GetComponent<Rigidbody2D>();

        end = start + 497;

        rb.velocity = new Vector2(0, -speed);

        StartCoroutine(Move());
    }

    void Update()
    {
        if(transform.position.y > end)
        {
            transform.position = new Vector3(transform.position.x, end, transform.position.z);
        }

        if(transform.position.y < start)
        {
            transform.position = new Vector3(transform.position.x, start, transform.position.z);
        }
    }

    IEnumerator Move()
    {
        while(true)
        {
            rb.velocity *= -1;
            yield return new WaitForSeconds(Random.Range(.3f, 2f));
        }
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Fish"))
        {
            GameManager.Instance.fill = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        if(other.CompareTag("Fish"))
        {
            GameManager.Instance.fill = false;
        }
    }
}
