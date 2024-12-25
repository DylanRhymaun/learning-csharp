using UnityEngine;
using TMPro;

public class myOperators : MonoBehaviour
{
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

    public void Displaymessage()
    {
        int xp = 990;
        xp = xp + 10;
        xp += 10; 
        textMeshPro.text = $"{xp}";
    }
}
