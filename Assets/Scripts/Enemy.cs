﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character{

    public enum EnemyType { Grunt, TestBoi};


    public Enemy(EnemyType enemyType)
    {
        switch (enemyType)
        {
            case EnemyType.Grunt:
                initializeHealth(100);
                setSprite(Resources.Load<Sprite>("Sprites/CharacterSprites/enemyone") as Sprite);
                break;
            case EnemyType.TestBoi:
                initializeHealth(1000);
                setSprite(Resources.Load<Sprite>("Sprites/CharacterSprites/enemyone") as Sprite);
                break;
        }
    }
}