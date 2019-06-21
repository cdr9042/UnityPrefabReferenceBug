using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugSwitchActive : MonoBehaviour
{
    void Awake()
    {
#if !UNITY_EDITOR
        if (!DebugManager.IsDebugMode())
            gameObject.SetActive(false);
#endif
    }
}
