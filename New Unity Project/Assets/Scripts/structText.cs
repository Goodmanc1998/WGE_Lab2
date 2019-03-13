using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class structText : MonoBehaviour {

    public ClassInts[] cInts;
    public StructInts[] sInts;

    const int SIZE = 100;

    // Use this for initialization
    void Start () {
        

        cInts = new ClassInts[SIZE];
        sInts = new StructInts[SIZE];

        for (int i = 0; i < SIZE; i++)
        {
            cInts[i] = new ClassInts();
        }

        //For loop 1
        for (int i = 0; i < SIZE; i++)
        {
            RandomiseClass(cInts[i]);
        }

        //For loop 2
        for (int i = 0; i < SIZE; i++)
        {
            RandomiseStruct(ref sInts[i]);
        }
	}

    void RandomiseStruct(ref StructInts s)
    {
        s.x = Random.Range(0, 100);
    }
    void RandomiseClass(ClassInts c)
    {
        c.x = Random.Range(0, 100);
    }
}

public class ClassInts
{
    public int x;
}

public struct StructInts
{
    public int x;
}