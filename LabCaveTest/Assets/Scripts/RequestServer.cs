using System.Collections;
using System.Collections.Generic;
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
                Debug.LogError("Error While Sending: " + uwr.error);
            }
            else
            {
                Debug.Log("Received: " + uwr.downloadHandler.text);
                callback.Invoke(uwr.downloadHandler.text);
            }
        }
    }
}
