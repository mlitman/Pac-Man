using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelletKillScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            CORE.score++;
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter("Enemy")
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            Destroy(this.pinkGhostAgent)
        }
    }
       

    // Update is called once per frame
    void Update()
    {

    }
}
