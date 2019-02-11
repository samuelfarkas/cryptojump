using UnityEngine;

public class triggers : MonoBehaviour {

    public Transform respawn;
    public score score;
    public playerMovement movement;
    public postRequest post;

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.tag == "Danger")
        {
            transform.position = respawn.position;
            score.Death();
        }

        if (other.tag == "btc")
        {
            score.ChangeScore("btc");
            Destroy(other.gameObject);
        }

        if (other.tag == "ltc")
        {
            score.ChangeScore("ltc");
            Destroy(other.gameObject);
        }

        if (other.tag == "xrp")
        {
            score.ChangeScore("xrp");
            Destroy(other.gameObject);
        }

        if (other.tag == "eth")
        {
            score.ChangeScore("eth");
            Destroy(other.gameObject);
        }


        if (other.tag == "Finish")
        {
            movement.enabled = false;
            post.Post();
        }

    }
}
