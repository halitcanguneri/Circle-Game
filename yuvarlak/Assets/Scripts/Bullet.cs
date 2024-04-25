using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 2f;
    

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        // Rastgele bir yön belirle
        Vector2 randomDirection = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
        rb.velocity = randomDirection * speed; // Hareketi bu yönde baþlat
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Barrier") // Tag'leri "Barrier" olarak ayarlayýn
        {
            //speed += 0.01f; // Bariyere her çarpýþta hýzý artýr
            //rb.velocity = rb.velocity.normalized * speed;
        }
        else if (collision.gameObject.tag == "Player") // Oyuncuyla çarpýþma
        {
            // Oyunu bitir
            Debug.Log("Oyun Bitti!");
            
            
            var gameManager = FindObjectOfType<GameManager>();
            
            gameManager.EndGame();
            
        }
        else if (collision.gameObject.tag == "Engel") // Oyuncuyla çarpýþma
        {
            speed += 0.01f; // Engele her çarpýþta hýzý artýr
            rb.velocity = rb.velocity.normalized * speed;
        }
    }
}
