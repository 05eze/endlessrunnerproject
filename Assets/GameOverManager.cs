using UnityEngine;
using UnityEngine.UI; 

public class GameOverManager : MonoBehaviour
{
    [SerialiseField] GameObject gameOverScreen;
    
    public void SetGameOver()
    {
        gameOverScreen.SetActice(true);
    }
}
