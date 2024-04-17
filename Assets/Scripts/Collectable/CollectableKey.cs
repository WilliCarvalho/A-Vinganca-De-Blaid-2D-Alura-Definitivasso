using UnityEngine;

public class CollectableKey : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("O item foi coletado");
        Destroy(this.gameObject);
    }
}
