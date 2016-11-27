using UnityEngine;
using System.Collections;

public class CoinController : MonoBehaviour {

    public AudioSource coinSound;
    private WaitForSeconds waitTime = new WaitForSeconds(0.25f);

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void OnTriggerEnter(Collider other) {

        if (other.gameObject.CompareTag("Player")) {
            StartCoroutine(playSoundAndDestroy());
        }
    }

    IEnumerator playSoundAndDestroy() {

        coinSound.Play();

        Vector3 newPosition = transform.position;
        newPosition.y = -10000;
        transform.position = newPosition;

        yield return waitTime;
        Destroy(this.gameObject);
    }
}
