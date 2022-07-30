using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    public GameManager gameManager;
    public TextMeshProUGUI scoreText;
    public ParticleSystem fireworks;

    [SerializeField]
    Animator CarAnim;

    private int score;
    private bool endingGame;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = Object.FindObjectOfType<GameManager>(); 
        score = 1;
        endingGame = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Active")
        {
            score++;
            scoreText.text = $"Score: {score}";
            other.gameObject.GetComponent<MeshRenderer>().enabled = false;
            if (!fireworks.isPlaying)
            {
                fireworks.Play();
            }

            if (!endingGame)
            {
                StartCoroutine(Finish());
            }
        }
    }

    IEnumerator Finish()
    {
        yield return new WaitForSecondsRealtime(5);
        endingGame = true;
        gameManager.showNextButton();
        CarAnim.enabled = true;
    }

}
