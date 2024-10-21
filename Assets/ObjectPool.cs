using UnityEngine;
using System.Collections.Generic;

public class ObjectPool : MonoBehaviour
{
    public List<GameObject> prefabs = new List<GameObject>();

    private Dictionary<string, List<GameObject>> objectPoolDictionary = new Dictionary<string, List<GameObject>>();
    public int poolSize = 300;

    void Start()
    {
        // �̸� poolSize��ŭ ���ӿ�����Ʈ�� �����Ѵ�.
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
        // �����ִ� ���ӿ�����Ʈ�� ã�� active�� ���·� �����ϰ� return �Ѵ�. 
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
        // ���ӿ�����Ʈ�� deactive�Ѵ�.
        obj.SetActive(false);
    }
}