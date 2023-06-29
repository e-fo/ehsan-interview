using System.Collections;
using UnityEngine;
using UnityEngine.Tilemaps;

public class ObjectGenerator : MonoBehaviour
{
    [SerializeField] string _groundTileMapTag = "Ground";
    [SerializeField] GameObject _prefab;
    [SerializeField] float _generateInterval;
    
    private Vector3Int _tileMapSize;

    private void OnEnable()
    {
        var tilemap = GameObject.FindGameObjectWithTag(_groundTileMapTag).GetComponent<Tilemap>();
        _tileMapSize = tilemap.size;
        StartCoroutine(StartGenerating());
    }

    private IEnumerator StartGenerating()
    {
        while(true)
        {
            Instantiate(_prefab, GenerateObjectPosition(), Quaternion.identity);
            yield return new WaitForSeconds(_generateInterval);
        }
    }

    private Vector3 GenerateObjectPosition()
    {
        return new Vector3(
            Random.Range(0, _tileMapSize.y-1),
            Random.Range(0, _tileMapSize.x-1),
            0
            );
    }
}