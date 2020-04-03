using System.Collections;using System.Collections.Generic;
using UnityEngine;using UnityEngine.UI;
using System;
//using SimpleJSON; 
using System.IO;
using UnityEngine.Networking;using UnityEngine.SceneManagement;

public class PushTEST : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         StartCoroutine(PushNot("1"));
    }
    //public void ClickPush(){StartCoroutine(PushNot(1));}
    //public void ClickPush(){SceneManager.LoadScene("M1");}

    IEnumerator PushNot(string id){WWWForm form = new WWWForm(); 
         form.AddField("id", id);
        //form.AddField("_phone", phone);form.AddField("_email", email);
        using (UnityWebRequest www = UnityWebRequest.Post("http://p905504y.beget.tech/notification1.php",form))
        {yield return www.SendWebRequest(); if (www.isNetworkError || www.isHttpError) { Debug.Log(www.error);}else{
        //g_save_ok.SetActive(true);
        //t_title_order.text = www.downloadHandler.text;
        //PlayerPrefs.SetString("phone", www.downloadHandler.text);
        Debug.Log("" + www.downloadHandler.text);
        }}
    }
}
