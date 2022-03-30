using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraDraai : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Lookatmouse();
    }
    void Lookatmouse()
    {
        Plane playerplane = new Plane(Vector3.up, transform.position);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float hitdist;

        if (playerplane.Raycast(ray, out hitdist))
        {
            Vector3 targetpoint = ray.GetPoint(hitdist);
            Quaternion targetrotation = Quaternion.LookRotation(targetpoint - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetrotation, speed * Time.deltaTime);
        }
    }
}