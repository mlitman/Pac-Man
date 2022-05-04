using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    private TextMesh tm;

    // Start is called before the first frame update
    void Start()
    {
        this.tm = this.gameObject.GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        this.tm.text = "Score: " + CORE.score;
    }
}
