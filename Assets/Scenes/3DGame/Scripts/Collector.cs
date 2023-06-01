using TMPro;
using UnityEngine;

public class Collector : MonoBehaviour
{
    [SerializeField] TMP_Text collectedText;
    int collectedValue = 0;

    void Start()
    {
        UpdateUI();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Collectable collectable))
        {
            collectedValue += collectable.Value;
            collectable.Jump();
            UpdateUI();
        }
    }

    void UpdateUI()
    {
        collectedText.text = collectedValue.ToString();
    }
}
