using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TunnelSpawnPointScript : MonoBehaviour
{
    public GameObject theOtherSpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.transform.position = this.theOtherSpawnPoint.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
