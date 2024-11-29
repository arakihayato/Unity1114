using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject MonsterPrefab;
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            GameObject monster = Instantiate(MonsterPrefab);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }


}
