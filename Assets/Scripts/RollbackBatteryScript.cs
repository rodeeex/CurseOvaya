using UnityEngine;

public class RollbackBatteryScript : MonoBehaviour
{
    private GameManager gameManager;

    void Start()
    {
        gameManager = GameManager.Instance;
    }

    void OnTriggerEnter(Collider other)
    {
        gameManager.canRollback = true;
        Destroy(gameObject);
    }
}