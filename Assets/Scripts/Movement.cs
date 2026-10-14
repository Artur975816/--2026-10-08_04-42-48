using UnityEngine;
using TMPro;

public class Movement : MonoBehaviour
{
    public float speed = 5f;
    public TextMeshProUGUI coinText;
    private int coins = 0;

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        transform.Translate(
            x * speed * Time.deltaTime,
            0,
            z * speed * Time.deltaTime
        );

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 300);
        }
    }

    void OnTriggerEnter(Collider coin)
    {
        Destroy(coin.gameObject);

        coins++;

        coinText.text = "Монеты: " + coins;
    }
}