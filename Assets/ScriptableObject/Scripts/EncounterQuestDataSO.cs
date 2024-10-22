using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EncounterQuestDataSO", menuName = "Scriptable Object/EncounterQuestData", order = int.MaxValue)]
public class EncounterQuestDataSO : QuestDataSO
{
    public string NPC;

    public override void PrintQuestDataInfo(int Index)
    {
        base.PrintQuestDataInfo(Index);

        Debug.Log($"{NPC} 과 대화하기");
    }
}
