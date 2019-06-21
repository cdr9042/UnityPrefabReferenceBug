using DigitalRuby.Pooling;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject t_waveMonster = ReferenceManager.instance.GetData(UnityEngine.Random.Range(0, 1));

        FunctionHelper.AddPrefabCheck(t_waveMonster.name, t_waveMonster);
        GameObject t_go = SpawningPool.CreateFromCache(t_waveMonster.name);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
