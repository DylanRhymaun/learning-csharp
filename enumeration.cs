using UnityEngine;
using TMPro;


public enum MovementAxis
{
    Down = -1, 
    Up = 1
}

public enum DamageType
{
    Single = 1,
    Double = 2,
    Quad = 4
}

public class enumeration : MonoBehaviour
{    
    public MovementAxis playerDirection;
    public int damageAmount;
    public DamageType damageType;
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

        textMeshPro.text = $"You did this much damage: {damageAmount * (int) damageType}";
    }


}
