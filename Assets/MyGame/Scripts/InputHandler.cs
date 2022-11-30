using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InputHandler : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textMeshPro;
    [SerializeField] InputField inputField;

    void Awake()
    {
        textMeshPro.gameObject.SetActive(false);
    }
    public void Execute()
    {
        textMeshPro.text = inputField.text;
        if (!textMeshPro.gameObject.activeSelf) textMeshPro.gameObject.SetActive(true);
    }
}