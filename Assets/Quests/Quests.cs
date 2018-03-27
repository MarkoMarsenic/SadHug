﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum QuestsEnum {Quest10, Level10};

public class Quests{
    public static Quest GetQuests(QuestsEnum quests)
    {
        switch (quests)
        {
            case QuestsEnum.Quest10:
                return new Quest(QuestType.money, "Money 10", 10);
            case QuestsEnum.Level10:
                return new Quest(QuestType.level, "Level 10", 10);
        }

        return null;
    }
}