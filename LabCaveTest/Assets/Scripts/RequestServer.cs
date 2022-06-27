using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Networking;
namespace ServerTool 
{
    public class RequestServer
    {

        const string serverPath = "http://localhost";
        const string port = "3000";
        /// <summary>
        /// Makes a request to the server
        /// </summary>
        /// <param name="request">request</param>
        /// <param name="callback">return an Action<string> value with the request result</param>
        /// <returns></returns>
        static public IEnumerator getRequest(string request, System.Action<string> callback = null)
        {
            UnityWebRequest uwr = UnityWebRequest.Get(serverPath + ":" + port + "/" + request);
            yield return uwr.SendWebRequest();

            if (uwr.isNetworkError)
            {
                Debug.Log("Borosa : " + uwr.error);
#if UNITY_EDITOR
                PopupWindow.Show( new Rect(new Vector2(Screen.width/2,Screen.height/2),new Vector2(200,50)), new PopupExample(uwr.error));
#endif

            }
            else
            {
                if (uwr.downloadHandler.text.Contains("Error"))
                {
#if UNITY_EDITOR
                    PopupWindow.Show(new Rect(new Vector2(Screen.width / 2, Screen.height / 2), new Vector2(200, 250)), new PopupExample(uwr.error, uwr.downloadHandler.text));                
#endif
                }
                else 
                {
                    Debug.Log("Received: " + uwr.downloadHandler.text);
                    callback.Invoke(uwr.downloadHandler.text);
                }
               
            }
        }
    }
#if UNITY_EDITOR
    internal class PopupExample : PopupWindowContent
    {
        private string message;
        private string extrainfo;
        /// <summary>
        /// Popup constructor
        /// </summary>
        /// <param name="error">server error</param>
        /// <param name="info">server info about the error</param>
        public PopupExample(string error, string info="") 
        {
            message = error;
            extrainfo = info;
        }
        /// <summary>
        /// Contains the server error info 
        /// </summary>
        /// <param name="rect">Position and size of the popup</param>
        public override void OnGUI(Rect rect)
        {
            GUILayout.Label("Server Error", EditorStyles.boldLabel);
            GUILayout.TextArea(message);
            GUILayout.TextArea(extrainfo);

        }
    }
#endif

}
