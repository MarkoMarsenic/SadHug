﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    private Vector3 MovingDirection = Vector3.up;
    //limits between the enemy will move from
    public float Uplimit = 3.0F;
    public float Downlimit = -3.0F;
    //speed that enemy moves at
    public float MovementSpeed = 2.0F;

    void Update()
    {
        //Transforms enemy between the positions
        gameObject.transform.Translate(MovingDirection * Time.deltaTime * MovementSpeed);

        //Checks if reaches limit then changes direction appropriately
        if (gameObject.transform.position.y > Uplimit)
        {
            MovingDirection = Vector3.down;
        }
        //Checks if reaches limit then changes direction appropriately
        else if (gameObject.transform.position.y < Downlimit)
        {
            MovingDirection = Vector3.up;
        }
    }
}

