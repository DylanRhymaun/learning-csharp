using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class madLibs : MonoBehaviour
{

        private TextMeshProUGUI textMeshPro;
        public bool statement = false;
        public string verb = "piss";
        public string noun = "watermelon";
        public string adjective = "fluffy";
        public int number = 89;
        public string pluralNoun = "ducks";
        public float percent = 30.5F;

        void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        textMeshPro.text = $"The statement is {statement}. I do not {verb} the {noun}. I am not guilty. I am a {adjective} person. The act was performed by {number} wandering {pluralNoun}. I am {percent}% sure.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
