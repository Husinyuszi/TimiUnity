using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void RestartGame() //string sceneName a () z�r�jelben ut�na 3DGame hely�re �rjuk akkor k�vetkez� r�sz lehet benneni pl p�lya l�p�sn�l. itt ugyan azt a r�sz h�vjuk �jra az elej�t�l
    {
        SceneManager.LoadScene("3DGame");
    }
}
