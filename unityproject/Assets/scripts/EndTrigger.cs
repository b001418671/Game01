
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    
    public GameManager gameManager;

    void OnTriggerEnter ()
    {
            gameManager.CompleteLevel();
    }
}

/* did not work.
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<GameManager>().CompleteLevel();
        }
    }
}
*/



