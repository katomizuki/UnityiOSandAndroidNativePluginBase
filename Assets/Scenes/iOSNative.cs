using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class iOSNative : MonoBehaviour
{

    [DllImport("__Internal")]
    private static extern long swiftPmPlugin_toNumber();
    void Start()
    {
        Debug.Log(swiftPmPlugin_toNumber() + "確認だぜい");
    }

        
}
