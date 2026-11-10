
using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed = 3f;
    [SerializeField] private Transform _playerTransform;

    private bool _isChasing = false;

    private void Update()
    {
        if (_isChasing && _playerTransform != null)
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                _playerTransform.position,
                _speed * Time.deltaTime
            );
        }
    }

    public void ChasePlayer()
    {
        _isChasing = true;
    }

    public void StopChasingPlayer()
    {
        _isChasing = false;
    }
}
