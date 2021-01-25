using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _towerHead;
    [SerializeField] private int _shootPower;
    [SerializeField] private float _shootDistance;
    [SerializeField] private float _shootDelay;
    [SerializeField] private float _bulletSpeed;
    [SerializeField] private float _bulletSplashRadius;

    public Sprite GetTowerHeadIcon ()
    {
        return _towerHead.sprite;
    }
}
