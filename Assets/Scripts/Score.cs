using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform Player;
    public TMP_Text ScoreText;
    void Update()
    {
        ScoreText.text = "Score - "+ ((int)Player.position.z).ToString();
    }
}
