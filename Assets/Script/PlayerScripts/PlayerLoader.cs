using UnityEngine;


public class PlayerLoader : MonoBehaviour
{
    public GameObject playerPrefab;
    private GameObject playerInstance;

    // Start is called before the first frame update
    void Start()
    {
        playerInstance = Instantiate(playerPrefab, transform.position, Quaternion.identity);
    }
}
