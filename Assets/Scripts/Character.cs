using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string name;
    public int exp = 0;

    public Character()
    {
        Reset();
        name = "not assigned";
    }

    public Character(string name)
    {
        this.name = name;
    }

    public virtual void PrintStatsInfo()

    {
        Debug.LogFormat("Hero: {0} - {1} EXP", name, exp);
    }


    private void Reset()
    {
        this.name = "Not assigned";
        this.exp = 0;
    }

}
