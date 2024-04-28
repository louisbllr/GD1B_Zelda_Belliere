using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class bulletScript : MonoBehaviour
{
    
    public  GameObject Player;
    private Rigidbody2D rb;
    public float force;
    public float PlayerHealth;
    public float health;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Player = GameObject.FindGameObjectWithTag("Player");
        Vector3 direction = Player.transform.position - transform.position;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * force;

        float rot = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot + 90);

    }

    // Update is called once per frame
    void Update()
    {
/*        timer += Time.deltaTime;
 
             
        if(timer>10)              
        {                         
            Destroy(gameObject);  
        }   */                      
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerHealth>().health -= 20;
            Destroy(gameObject);
        }
 
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
               Destroy(gameObject);
    }
}
