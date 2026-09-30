using TMPro;
using UnityEngine;

public class DEMOMONO : MonoBehaviour
{
    
        public TextMeshProUGUI textbox;

    public void OnClick()
    {
        textbox.text = "i have changed";
    }
}