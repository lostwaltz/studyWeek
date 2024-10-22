using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MonsterQuestDataSO", menuName = "Scriptable Object/MonsterQuestData", order = int.MaxValue)]

public class MonsterQuestDataSO : QuestDataSO
{
    public string TargetMonsterName;
    public int RequiredKillMonsterCount;

    public override void PrintQuestDataInfo(int Index)
    {
        base.PrintQuestDataInfo(Index);

        Debug.Log($"{TargetMonsterName}∏¶ {RequiredKillMonsterCount}∏∂∏Æ º“≈¡");
    }
}
