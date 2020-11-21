

using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Score : MonoBehaviour
{
    static uint score = 0;
    static bool win = false;
    static TextMeshProUGUI scoreTextStatic;
    public TextMeshProUGUI scoreText;

    public static void Increment()
    {
        score++;
        if (scoreTextStatic)
            scoreTextStatic.text = "Score: " + score;
        if (!win && score > 10)
        {
            win = true;
            Debug.Log("win");
            // end minigame
            // TODO: TransitionScene
            SceneManager.LoadScene("TransitionScene");
        }
        Debug.Log(score.ToString());
    }

    void Start()
    {
        if (scoreText != null)
            scoreTextStatic = scoreText;
        Debug.Log("here!");
        Debug.Log(scoreText);
    }
}