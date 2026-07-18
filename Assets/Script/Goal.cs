using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameManager gameManager;
    public bool isLeftGoal;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        // Debug.Log("Quelque chose est entré dans le trigger : " + collision.name);

        if (!collision.CompareTag("Ball"))
            return;

        if (isLeftGoal)
            gameManager.RightPlayerScored();
        else
            gameManager.LeftPlayerScored();
    }
}