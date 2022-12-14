using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMove : MonoBehaviour
{
    Coin coinScript;
    CoinMove coinMoveScript;
    void Start()
    {
        coinScript = GetComponent<Coin>();
        coinMoveScript = GetComponent<CoinMove>();
    }
    void Update()
    {
        Vector3 playerNewTransform = coinScript.playerTransform.position;
        playerNewTransform.y += 1f;

        transform.position = Vector3.MoveTowards(transform.position, playerNewTransform, coinScript.moveSpeed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
        }
    }
}
