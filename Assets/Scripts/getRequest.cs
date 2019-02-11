using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using LitJson;

public class getRequest : MonoBehaviour {

    private JsonData jsonData;
    public Text playerName1;
    public Text playerName2;
    public Text playerName3;
    public Text playerName4;
    public Text playerName5;

    public Text playerScore1;
    public Text playerScore2;
    public Text playerScore3;
    public Text playerScore4;
    public Text playerScore5;

    private void Start()
    {
        GetScore();
    }

    public void GetScore()
    {
        string url = "https://cryptojump.herokuapp.com/public/scoreboard";

        WWW www = new WWW(url);

        StartCoroutine(Request(www));

    }

    IEnumerator Request(WWW www)
    {
        yield return www;
        Cursor.visible = true;
        jsonData = JsonMapper.ToObject(www.text);

        playerName1.text = jsonData["data"][0]["name"].ToString();
        playerScore1.text = jsonData["data"][0]["score"].ToString();

        playerName2.text = jsonData["data"][1]["name"].ToString();
        playerScore2.text = jsonData["data"][1]["score"].ToString();

        playerName3.text = jsonData["data"][2]["name"].ToString();
        playerScore3.text = jsonData["data"][2]["score"].ToString();

        playerName4.text = jsonData["data"][3]["name"].ToString();
        playerScore4.text = jsonData["data"][3]["score"].ToString();

        playerName5.text = jsonData["data"][4]["name"].ToString();
        playerScore5.text = jsonData["data"][4]["score"].ToString();

    }

}
