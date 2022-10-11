using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soda : MonoBehaviour
{
    [SerializeField]
    private int healPoints = 20;
    public int HealPoints { get { return healPoints; } }

    int Xrotate = 0;
    int Yrotate = 2;
    int Zrotate = 0;

    private void Update() 
    {
        transform.Rotate(Xrotate, Yrotate,  Zrotate);
    }

}

