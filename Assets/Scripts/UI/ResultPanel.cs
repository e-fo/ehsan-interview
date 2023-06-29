using UnityEngine;
using UnityAtoms.BaseAtoms;

public class ResultPanel : MonoBehaviour
{
    [SerializeField] VoidEvent _onPlayerDeath;
    [SerializeField] GameObject _playerLosePanel;

    private void OnEnable()
    {
        _onPlayerDeath.Register(OnPlayerDeath);
    }

    private void OnDisable()
    {
        _onPlayerDeath.Unregister(OnPlayerDeath);
    }

    void OnPlayerDeath()
    {
        _playerLosePanel.SetActive(true);
    }
}