using UnityEngine;

public class IncreaseScore : MonoBehaviour
{ 
    [SerializeField] private BoxCollider boxCollider;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerView>() != null)
        {
            GameManager.Instance.increaseScore();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerView>() != null)
        {
            boxCollider.gameObject.SetActive(false);
        }
    }
}
