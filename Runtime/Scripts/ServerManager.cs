using System;
using System.Collections;
using UnityEngine.Networking;

namespace Simulanis.ContentSDK
{
    public static class ServerManager
    {
        private static string token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1dWlkIjoiZDQ5NTA4ZGItMzFhYS00ODY4LWFiNjktOTQ1M2RkYTllOTQ2IiwiY2hhbm5lbCI6IjEwYjMzOTA3LTRiOGUtNDQyMC1hYzQ5LWYwZDNhYzc3YzQ1YSIsImdyb3VwSWQiOiI5Yzk4N2VjZS1iMjE0LTQ3NTktOWFiNy0xMjA2NDNmOTdiZWUiLCJjaGFubmVsRGVmYXVsdEdyb3VwIjoiZTJkMjEzYWUtNTU0Ni00NmYyLWI0M2ItMGQ4Y2JlZjVjMmE5IiwiaWF0IjoxNzM1MTkzNzIzLCJleHAiOjE3Mzc3ODU3MjN9.90XkstVnZ0_K7oENruqAyflaU1oif1o-IsAxOff3vjU";
        private static string baseUrl ="https://api.xr.simulanis.io/api/application/assessment/";
        /// <summary>
        /// Coroutine to fetch data from the server.
        /// </summary>
        public static IEnumerator FetchDataCoroutine(string url, Action<string> onSuccess, Action<string> onError)
        {
            using (UnityWebRequest request = UnityWebRequest.Get(baseUrl+url))
            {
                request.SetRequestHeader("Content-Type", "application/json");
                 request.SetRequestHeader("Authorization", $"Bearer {token}");

                yield return request.SendWebRequest();

                if (request.result == UnityWebRequest.Result.Success)
                {
                    onSuccess?.Invoke(request.downloadHandler.text);
                }
                else
                {
                    onError?.Invoke(request.error);
                }
            }
        }
    }
}