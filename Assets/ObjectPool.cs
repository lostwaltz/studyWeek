using UnityEngine;
using System.Collections.Generic;

public class ObjectPool : MonoBehaviour
{
    [System.Serializable]
    public class Pool
    {
        public string tag;
        public GameObject prefab;
    }

    public List<Pool> prefabs = new List<Pool>();

    private Dictionary<string, List<GameObject>> objectPoolDictionary = new Dictionary<string, List<GameObject>>();
    public int poolSize = 10;

    void Start()
    {
        // 미리 poolSize만큼 게임오브젝트를 생성한다.
        for(int i = 0; i < prefabs.Count; i++)
        {
            for (int j = 0; j < poolSize; j++)
            {
                GameObject instance = Instantiate(prefabs[i].prefab);
                instance.SetActive(false);

                if (!objectPoolDictionary.ContainsKey(prefabs[i].tag))
                {
                    objectPoolDictionary[prefabs[i].tag] = new List<GameObject>();
                }
                objectPoolDictionary[prefabs[i].tag].Add(instance);
            }
        }
    }

    public GameObject Get(string key)
    {
        // 꺼져있는 게임오브젝트를 찾아 active한 상태로 변경하고 return 한다. 
        foreach(GameObject pool in objectPoolDictionary[key])
        {
            if(false == pool.gameObject.activeSelf)
            {
                pool.SetActive(true);

                return pool;
            }
        }

        return null;
    }

    public void Release(GameObject obj)
    {
        // 게임오브젝트를 deactive한다.
        obj.SetActive(false);
    }
}