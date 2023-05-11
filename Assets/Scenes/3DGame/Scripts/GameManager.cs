using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void RestartGame() //string sceneName a () zárójelben utána 3DGame helyére írjuk akkor következõ rész lehet benneni pl pálya lépésnél. itt ugyan azt a rész hívjuk újra az elejétõl
    {
        SceneManager.LoadScene("3DGame");
    }
}
