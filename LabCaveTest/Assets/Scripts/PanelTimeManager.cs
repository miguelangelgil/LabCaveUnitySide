using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ServerTool;
public class PanelTimeManager : MonoBehaviour
{
    public Text timeText;

    /// <summary>
    /// Update timeText with the current server time with the specified format
    /// Example of format : yyyy-mm-dd:hh:mm:ss -> return : 2022-21-Sa:04:21:33
    /// The format follow the following rules https://momentjs.com/docs/#/parsing/string-format/
    /// </summary>
    public void UpdateTimeText() 
    {
        StartCoroutine(RequestServer.getRequest("time?format=hh:mm:ss", callback: (returnValue) => { 
            timeText.text = returnValue;
        }));
    }
}
