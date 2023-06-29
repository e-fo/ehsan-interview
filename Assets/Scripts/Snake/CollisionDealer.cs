using UnityEngine;
using UnityAtoms.BaseAtoms;

public class CollisionDealer : MonoBehaviour
{
    [SerializeField] string _appleTag;
    [SerializeField] string _enemyTag;
    [SerializeField] string _wallTag;
    [SerializeField] VoidEvent _onPlayerDeath;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == _appleTag) {
            Destroy(collision.gameObject);
            //TODO: Add to tale
        }

        if(collision.tag == _enemyTag || collision.tag == _wallTag)
        {
           _onPlayerDeath.Raise();
        }
    }
}