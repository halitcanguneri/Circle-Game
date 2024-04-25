using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 2f;
    

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        // Rastgele bir y�n belirle
        Vector2 randomDirection = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
        rb.velocity = randomDirection * speed; // Hareketi bu y�nde ba�lat
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Barrier") // Tag'leri "Barrier" olarak ayarlay�n
        {
            //speed += 0.01f; // Bariyere her �arp��ta h�z� art�r
            //rb.velocity = rb.velocity.normalized * speed;
        }
        else if (collision.gameObject.tag == "Player") // Oyuncuyla �arp��ma
        {
            // Oyunu bitir
            Debug.Log("Oyun Bitti!");
            
            
            var gameManager = FindObjectOfType<GameManager>();
            
            gameManager.EndGame();
            
        }
        else if (collision.gameObject.tag == "Engel") // Oyuncuyla �arp��ma
        {
            speed += 0.01f; // Engele her �arp��ta h�z� art�r
            rb.velocity = rb.velocity.normalized * speed;
        }
    }
}
