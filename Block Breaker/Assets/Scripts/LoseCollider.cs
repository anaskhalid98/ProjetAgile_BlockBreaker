using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LoseCollider : MonoBehaviour {

    [SerializeField] public static int tries = 3;
    [SerializeField] int pointsPerBlockDestroyed = 5;
    [SerializeField] int currentScore = 0;
    [SerializeField] TextMeshProUGUI scoreText;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (tries == 0) {
            SceneManager.LoadScene("Game Over");
            tries = 3;
        }
        else {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentSceneIndex);
            tries--;
            currentScore -= pointsPerBlockDestroyed;
            scoreText.text = currentScore.ToString();

        }
        
    }
    

}
