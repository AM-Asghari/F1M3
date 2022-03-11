using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lopen : MonoBehaviour
{

    public Vector3 velocity = new Vector3();

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
            transform.position += transform.right * Time.deltaTime;

        if (Input.GetKey(KeyCode.A))
            transform.position += -transform.right * Time.deltaTime;

        if (Input.GetKey(KeyCode.W))
            transform.position += transform.forward * Time.deltaTime;

        if (Input.GetKey(KeyCode.S))
            transform.position += -transform.forward * Time.deltaTime;

        if (Input.GetKey(KeyCode.Space))
            transform.position += new Vector3(0, 5, 0) * Time.deltaTime;

        if (Input.GetKey(KeyCode.LeftControl))
            transform.position += new Vector3(0, -2, 0) * Time.deltaTime;
    }
}
