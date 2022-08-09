using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class square_logic : MonoBehaviour
{
    public float speed = 100;
    public Transform obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 tempVect = new Vector3(h, v, 0);
        tempVect = tempVect.normalized * speed * Time.deltaTime;

        obj.transform.position += tempVect;
    }

    public void respawn()
    {
        obj.transform.position = new Vector3(Random.Range(-5,5), Random.Range(-5,5), 0);
    }
}
