using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    private static QuestManager instance;

    public List<QuestDataSO> questDataCollection;

    public static QuestManager Instance { get {
            if (instance == null)
            {
                instance = FindObjectOfType<QuestManager>();
                if(instance == null)
                {
                    GameObject questManager = new GameObject("QuestManager");

                    instance = questManager.AddComponent<QuestManager>();
                    DontDestroyOnLoad(questManager);
                }
            }
            return instance;
        } }

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;

            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        PrintQuestList();
    }


    private void PrintQuestList()
    {
        int index = 1;
        foreach (var questData in questDataCollection)
        {
            questData.PrintQuestDataInfo(index++);
        }
    }
}

