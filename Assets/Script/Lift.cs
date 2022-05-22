using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lift : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == ("End"))
        {
            Destroy(other.transform.root.gameObject);
        }

        //if (other.name == ("SpaceEnd"))
        //{
        //    Instantiate(other.transform.root.gameObject, other.transform.position, Quaternion.identity);
        //}
    }
}
