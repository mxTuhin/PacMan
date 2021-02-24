using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class RegisterUser : MonoBehaviour
{

    public IEnumerator Register(string _name, string _age)
    {
        WWWForm form = new WWWForm();
        form.AddField("name", _name);
        form.AddField("age", _age);
        form.AddField("score", Constants.conScore);

        using (UnityWebRequest www = UnityWebRequest.Post(Constants.nameEntryURL, form))
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
                    SceneManager.LoadScene("Level1");
                }

            }
        }
    }
}
