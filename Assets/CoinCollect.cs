using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    public int coinValue = 1;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            GameManager.instance.AddScore(coinValue);

            Destroy(gameObject);
        }
    }
}