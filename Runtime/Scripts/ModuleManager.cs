using UnityEngine;

namespace Simulanis.ContentSDK
{
    /// <summary>
    /// Manages the lifecycle of different modules.
    /// </summary>
    public class ModuleManager : MonoBehaviour
    {
        public static ModuleManager Instance;
        void Awake()
        {
            Instance = this;
        }
        /// <summary>
        /// Starts the specified task.
        /// </summary>
        /// <param name="taskID">ID of the task to start.</param>
        public void StartTask(string taskID)
        {
            
        }
        /// <summary>
        /// Ends the specified task.
        /// </summary>
        /// <param name="taskID">ID of the task to stop.</param>
        public void EndTask(string taskID)
        {
            
        }
        /// <summary>
        /// Performs actions associated with button clicks in tasks.
        /// </summary>
        /// <param name="taskID">ID of the task for the button action.</param>
        public void ButtonTask(string taskID)
        {
            
        }
        /// <summary>
        /// Fetch assessment data from server
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="onSuccess"></param>
        /// <param name="onError"></param> <summary>
        /// 
        /// </summary>
        /// <param name="appId">ID of the module, ref. "vault.simulanis.io"</param>
        /// <param name="onSuccess">Get response in string</param>
        /// <param name="onError">Get error response in string</param>
        public void GetAssessment(string appId, System.Action<string> onSuccess, System.Action<string> onError)
        {
            string result = string.Empty;
            StartCoroutine(ServerManager.FetchDataCoroutine(
                appId,
                (response) => 
                {
                    Debug.Log("Fetch Successful: " + response);
                    onSuccess?.Invoke(response);
                },
                (error) => 
                {
                    Debug.LogError("Fetch Error: " + error);
                    onError?.Invoke(error);
                }
            ));
        }
        /// <summary>
        /// User response in string format
        /// </summary>
        /// <param name="userResponse"> user response</param>
        public void SendAssessment(string userResponse)
        {

        }
    }
}
