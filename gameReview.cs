using UnityEngine;
using TMPro;

public enum Game 
{
    Starfield, 
    AlienIsolation,
    BaldursGate,
    Gollum
}

public class gameReview : MonoBehaviour
{
    public Game game;
    private  TextMeshProUGUI TextMeshPro;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TextMeshPro = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowMessage()
    {
        switch (game)
        {
            case Game.Starfield:
                TextMeshPro.text = "meh";
                break;
            case Game.AlienIsolation:
                TextMeshPro.text = "Scary";
                break;
            case Game.BaldursGate:
                TextMeshPro.text = "Amazeballs";
                break;
            case Game.Gollum: 
                TextMeshPro.text = "Are you a dumbass?";
                break;
        }
    }
}
