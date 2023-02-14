using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{

    private int scoreToGive = 1;
    [SerializeField]
    private int clicksToPop = 5;

    private Vector3 scaleIncreasePerClick = new(0.2f, 0.2f, 0.2f);

    private ScoreManager _scoreManager;
    private void Start()
    {
        _scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }
    private void OnMouseDown()
    {
        clicksToPop -= 1;
        transform.localScale += scaleIncreasePerClick;
        if (clicksToPop == 0)
        {
            Destroy(gameObject);
            _scoreManager.AddScore(scoreToGive);
        }
    }
}
