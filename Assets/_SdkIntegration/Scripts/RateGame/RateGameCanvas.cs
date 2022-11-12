using System;
using ATSoft;
using Sirenix.OdinInspector;
using UnityEditor;
using UnityEngine;

public class RateGameCanvas : MonoBehaviour
{
    [Button]
    public void OnClickRate()
    {
        var packageName = PlayerSettings.applicationIdentifier;
#if UNITY_ANDROID
        var OPEN_LINK_RATE = "market://details?id=" + packageName;
#else
        var OPEN_LINK_RATE = "itms-apps://itunes.apple.com/app/id" + appleAppId;
#endif
        Application.OpenURL(OPEN_LINK_RATE);
        PlayerPrefs.SetInt("CAN_SHOW_RATE", 1);
        gameObject.SetActive(false);
    }
}