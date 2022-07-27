using UnityEngine;
using TMPro;

public class CherryPickup : MonoBehaviour
{
    private float cherry = 0;
    public static float cherryScore = 0f;
 
    
    public TextMeshProUGUI textCherries;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.transform.tag == "Cherries")
        {
            SoundManager.PlaySound ("cherryPickup");

            cherry++;
            cherryScore = cherryScore + 20f;
            textCherries.text = cherry.ToString();

            // Destroying cherries
            Destroy(other.gameObject);
        }
    }
}
