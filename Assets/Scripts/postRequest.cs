using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using LitJson;

public class postRequest : MonoBehaviour
{
    public score scoreS;
    public playerInterphace manager;
    private JsonData jsonData;

    public GameObject finish;
    public Text totalScore;
    public Text actualScore;

    public void Post()
    {
        string url = "https://cryptojump.herokuapp.com/public/store";

        WWWForm formDate = new WWWForm();

        formDate.AddField("name", scoreS.playerName);
        formDate.AddField("btc", scoreS.btc.ToString());
        formDate.AddField("ltc", scoreS.ltc.ToString() );
        formDate.AddField("xrp", scoreS.xrp.ToString() );
        formDate.AddField("eth", scoreS.eth.ToString() );
        

        WWW www = new WWW(url, formDate);

        StartCoroutine(Request(www));

    }
    IEnumerator Request(WWW www)
    {
        finish.SetActive(true);
        Cursor.visible = true;
        yield return www;
        
        jsonData = JsonMapper.ToObject(www.text);


        totalScore.text = jsonData["data"]["totalScore"].ToString();
        actualScore.text = jsonData["data"]["newScore"].ToString();

        
    }

    public void PostName()
    {
        string url = "https://cryptojump.herokuapp.com/public/user/isregistered";

        WWWForm formDate = new WWWForm();

        formDate.AddField("name", scoreS.playerName);

        WWW www = new WWW(url, formDate);

        StartCoroutine(RequestName(www));

    }


    IEnumerator RequestName(WWW www)
    {
        yield return www;

        jsonData = JsonMapper.ToObject(www.text);

        Debug.Log(jsonData["data"]["registered"].ToString());
        if (jsonData["data"]["registered"].ToString() != "True")
        {
            Debug.Log(jsonData["data"]["registered"].ToString());
            SceneManager.LoadScene("0.0.1");
        }
        else
        {
            manager.Levels();
        }

    }
}