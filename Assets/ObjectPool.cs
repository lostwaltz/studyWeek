using UnityEngine;
using System.Collections.Generic;

public class ObjectPool : MonoBehaviour
{
    public List<GameObject> prefabs = new List<GameObject>();

    private Dictionary<string, List<GameObject>> objectPoolDictionary = new Dictionary<string, List<GameObject>>();
    public int poolSize = 300;

    void Start()
    {
        // 미리 poolSize만큼 게임오브젝트를 생성한다.
        for(int i = 0; i < prefabs.Count; i++)
        {
            for (int j = 0; j < poolSize; j++)
            {
                GameObject instance = Instantiate(prefabs[i]);
                instance.SetActive(false);

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