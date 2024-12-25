using UnityEngine;

public class myTypes : MonoBehaviour
{
    public string message = "Strings contain text, not cheese";
    public string phoneNumber = "123456789";
    public string whitespace = " ";

    public string emptyString = "";

    public char tempType = 'C';
    //char type needs to use apostrophes, not quotations

    public bool wetClothes = true;
    public bool lovingRelationship = false;

    public int myInt = 1_000_000;
    // underscores can act as commas for long numbers

    public uint myUInt = 4_000_000_000;
    // ints go up to +/- ~2B. uints can be a bigger positive number. 

    public long myLongNumber = 50_000_000_000;
    // longs can be any number

    public double Pi = 3.1415;
    //default decimal type (64bit)

    public float pi = 3.1415F;
    // F is required at the end. Use this more often. 

  // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
