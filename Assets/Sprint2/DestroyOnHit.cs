using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;


public class DestroyOnHit : MonoBehaviour
{
    public async void Test(int delay)
    {
        await Task.Delay(delay);
        Destroy(this.gameObject);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Bullet")
        {
            Test(2000);
        }
    }
}
