using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : MonoBehaviour
{
    public ObjectPool pool;

    List<GameObject> objectList = new List<GameObject>();

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            GameObject gameObject = pool.Get("Arrow");


            if(gameObject != null)
                objectList.Add(gameObject);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            for(int i = 0; i < objectList.Count; i++)
            {
                pool.Release(objectList[i]);
            }
        }
    }
}
