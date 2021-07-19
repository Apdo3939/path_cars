using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    public GameObject carObject;
    public GameObject particleObject;
    public PlayerController playerController;

    public ScoreController scoreController;

    [Space(10)]
    public GameObject gameOverPanelObject;
    public float timeToShowGameOver = 2.0f;

    void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Enemy"))
        {
            return;
        }

        Debug.Log("Colidiu!!!");
        Instantiate(particleObject, transform.position, transform.rotation);
        playerController.enabled = false;
        carObject.SetActive(false);
        GetComponent<BoxCollider>().enabled = false;
        scoreController.startScore = false;
        StartCoroutine(ShowGameOver());
    }

    IEnumerator ShowGameOver()
    {
        yield return new WaitForSeconds(timeToShowGameOver);
        gameOverPanelObject.SetActive(true);
    }
}
