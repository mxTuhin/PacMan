using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class EntryScore : MonoBehaviour
{
    public IEnumerator entryScore(string _playerID, string _score)
    {
        WWWForm form = new WWWForm();
        form.AddField("playerID", _playerID);
        form.AddField("score", _score);

        using (UnityWebRequest www = UnityWebRequest.Post(Constants.scoreEntryURL, form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                if (www.downloadHandler.text == "Successful")
                {
                    Debug.Log("meow");

                }

            }
        }
    }
}
