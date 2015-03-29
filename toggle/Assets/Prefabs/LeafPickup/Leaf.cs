using UnityEngine;
using System.Collections;

public class Leaf : MonoBehaviour 
{
    //Leaf will appear once this timer reaches 0
    private float displayTimer = 1.0f;

    void FixedUpdate()
    {
        print(displayTimer); //print timer to console
        if (displayTimer > 0)
        {
            displayTimer -= Time.deltaTime;
        }
        else
        {
            //Timer reached 0, so display object
            this.gameObject.GetComponent<SpriteRenderer>().enabled = true;
            this.gameObject.GetComponent<BoxCollider2D>().enabled = true;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            //Call addPoints method in score script and destroy this object

            Destroy(this.gameObject);
        }
    }
}