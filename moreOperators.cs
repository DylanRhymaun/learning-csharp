using UnityEngine;

public class moreOperators : MonoBehaviour
{

    void Start()
    {
        // int x = 1;
        // int y = 2;
        // bool result = x == y;
        // Debug.Log(result);

        int coins = 100;
        int totalLives = 3;
        int maxLives = 10;
        bool isPremiumMember = true;

        bool shouldIncreaseDifficulty = isPremiumMember == false && totalLives > 5;
        Debug.Log(shouldIncreaseDifficulty);


        bool shouldIncreaseLifeCount = coins >= 100 && totalLives < maxLives || isPremiumMember == true;
        //Debug.Log(shouldIncreaseLifeCount);

        string firstName = null;
        bool isUppercase = firstName != null && firstName.ToUpper() == "Dylan";
        //Debug.Log(isUppercase);
    }

    void Update()
    {
        
    }
}
