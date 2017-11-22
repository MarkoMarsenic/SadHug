﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character{

    public enum EnemyType { Grunt };

    public EnemyType enemyType;

    public Enemy()
    {
        switch (enemyType)
        {
            case EnemyType.Grunt:
                initializeHealth(100);
                break;
        }
    }
}
