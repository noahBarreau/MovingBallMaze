using UnityEngine;

public class BallRespawn : MonoBehaviour
{
    public Vector3 respawnPoint = Vector3.zero;
    public PopupManager popupManager;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Respawn();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            Debug.Log("Collision avec Trap");
            Respawn();
        }
        if (collision.gameObject.CompareTag("Finish"))
        {
            popupManager.ShowPopup("Bravo, tu as marqué + que le jeu");
        }
    }

    void Respawn()
    {
        GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
        transform.localPosition = respawnPoint;
    }
}
