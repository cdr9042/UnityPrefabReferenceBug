using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System.Diagnostics;
public class DebugManager : MonoBehaviour
{
    //PerformanceCounter cpuCounter;
    //PerformanceCounter ramCounter;


    public const string testerCode = "hoppitest";
    public static DebugManager instance;
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
        FunctionHelper.SetRootThenDontDestroy(this.gameObject);

        //cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        //ramCounter = new PerformanceCounter("Memory", "Available MBytes");

        if (!UnityEngine.Debug.isDebugBuild)
            this.gameObject.SetActive(false);
    }

    //public static void LogMemoryUsage()
    //{
    //    if (instance.gameObject.activeSelf)
    //        UnityEngine.Debug.Log(string.Format("> cpu: {0}, ram: {1}", instance.getCurrentCpuUsage(), instance.getAvailableRAM()));
    //}

    //public string getCurrentCpuUsage()
    //{
    //    cpuCounter.NextValue();
    //    System.Threading.Thread.Sleep(1000); // wait a second to get a valid reading
    //    var usage = cpuCounter.NextValue();

    //    return usage + "%";
    //}

    //public string getAvailableRAM()
    //{
    //    return ramCounter.NextValue() + "MB";
    //}

    public static bool IsDebugMode()
    {
        return (
            //Debug.isDebugBuild && 
            instance.gameObject.activeSelf);
    }
}
