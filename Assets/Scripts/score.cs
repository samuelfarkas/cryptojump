using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public postRequest post;

    public Text btcScore;
    public Text ltcScore;
    public Text xrpScore;
    public Text ethScore;

    public static string username;
    public string playerName;
    public float btc = 0;
    public float ltc = 0;
    public float xrp = 0;
    public float eth = 0;

    private void Awake()
    {
        playerName = username;
    }

    public void ChangeScore(string coin)
    {

        switch(coin)
        {
            case "btc":
                btc++;
                break;

            case "ltc":
                ltc++;
                break;

            case "xrp":
                xrp++;
                break;

            case "eth":
                eth++;
                break;

            default:
                break;

        }
        WriteScore();
    }

    public void Death()
    {

        if(eth > 0)
        {
            eth -= 0.5f;
        }
        else if(xrp > 0)
        {
            xrp -= 0.5f;
        }
        else if (ltc > 0)
        {
            ltc -= 0.5f;
        }
        else if(btc > 0)
        {
            btc -= 0.5f;
        }
        else
        {
            eth = xrp = ltc = btc = 0;
        }

        WriteScore();
    }

    private void WriteScore()
    {
        btcScore.text = btc.ToString();
        ltcScore.text = ltc.ToString();
        xrpScore.text = xrp.ToString();
        ethScore.text = eth.ToString();
    }

    public void SetName(string name)
    {
        playerName = username = name;
        post.PostName();
    }

}
