using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostKillScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(this.pinkGhostAgent)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
