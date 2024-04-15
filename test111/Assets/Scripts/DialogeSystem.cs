using System.Collections;
using UnityEngine;
using TMPro;


public class DialogeSystem : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textMeshPro;
    [SerializeField] private float typingSpeed = 10f;

    private string fullText;
    private Coroutine typingCoroutine;

    void Start()
    {
        fullText = textMeshPro.text;
        textMeshPro.text = "";
        StartCoroutine(TypeText());
    }

    IEnumerator TypeText()
    {
        float timeBetweenChars = 1f / typingSpeed;
        foreach (char c in fullText)
        {
            textMeshPro.text += c;
            yield return new WaitForSeconds(timeBetweenChars);
        }
    }

    public void SkipTyping()
    {
        if (typingCoroutine != null)
        {
            StopCoroutine(typingCoroutine);
            textMeshPro.text = fullText;
        }
    }


}
