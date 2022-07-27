using UnityEngine;
using TMPro;

public class GemPickup : MonoBehaviour
{
    private float gem = 0;
    public static float gemScore = 0f;

    public TextMeshProUGUI textGems;

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if(collider2D.transform.tag == "Gems")
        {
            SoundManager.PlaySound ("gemCollectSound");

            gem++;
            gemScore = gemScore + 50f;
            textGems.text = gem.ToString();

            // Destroying gems
            Destroy(collider2D.gameObject);
        }
    }
}
