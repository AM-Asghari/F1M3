using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public int health = 100;
    public int damage = 50;

    void OnCollisionEnter(Collision collision)
    {
        GameObject otherObj = collision.gameObject;
        Debug.Log("Collided with: " + otherObj);

        if (collision.gameObject.name == "Cube")
        {
            health -= damage;
        }

        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
