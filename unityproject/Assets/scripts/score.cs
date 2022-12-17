
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
   public Transform player;
   private Text _scoreText;

    private void Awake()
    {
        _scoreText = GetComponent<Text>();
    }

    private void Update()
    {
        _scoreText.text = player.position.z.ToString("0");
    }
}
