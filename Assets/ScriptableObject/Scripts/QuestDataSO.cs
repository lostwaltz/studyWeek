using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

[CreateAssetMenu(fileName = "QuestDataSO", menuName = "Scriptable Object/QuestData", order = int.MaxValue)]

public class QuestDataSO : ScriptableObject
{
    public string QuestName;
    public int QuestRequiredLevel;
    public int QuestNPC;
    public List<int> QuestPrerequisites;


    public virtual void PrintQuestDataInfo(int Index)
    {
        Debug.Log($"Quest {Index} - {QuestName} (최소 레벨{QuestRequiredLevel})");
    }
}
