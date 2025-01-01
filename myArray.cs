using UnityEngine;
using TMPro;

public class myArray : MonoBehaviour
{

float[] reviewScores = {5.9f, 6.0f, 8.5f, 3.1f };
public string[] reviewers;
private int counter = 0;

private TextMeshProUGUI textMeshPro;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowMessage()
    {
        string reviewer = reviewers[counter];
        float score = reviewScores[counter];
        textMeshPro.text = $"{reviewer}: {score}";
        counter = (counter + 1) % reviewers.Length;
    }
}
