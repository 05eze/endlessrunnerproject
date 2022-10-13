using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour {

    public Text pointsText;

    public void SetUp(int score) {
        gameObject.SetActive(true);
        pointsText.text = score.ToString() + " POINTS";
    }
}