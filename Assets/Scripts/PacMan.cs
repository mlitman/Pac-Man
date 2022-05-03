using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacMan
{
    public void addScore()
    {
        this.scoreCount++;
    }

    public int getScoreCount()
    {
        return this.scoreCount;
    }
}
