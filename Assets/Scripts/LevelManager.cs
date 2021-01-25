using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private Transform _towerUIParent;
    [SerializeField] private GameObject _towerUIPrefab;

    [SerializeField] private Tower[] _towerPrefabs;

    private List<TowerUI> _activeTowerUIs = new List<TowerUI> ();

    private void Start ()
    {
        InstantiateAllTower ();
    }

    private void InstantiateAllTower ()
    {
        foreach (Tower tower in _towerPrefabs)
        {
            GameObject newTowerUIObj = Instantiate (_towerUIPrefab.gameObject, _towerUIParent);
            TowerUI newTowerUI = newTowerUIObj.GetComponent<TowerUI> ();

            newTowerUI.ChangeTowerIcon (tower.GetTowerHeadIcon ());
            newTowerUI.transform.name = tower.name;

            _activeTowerUIs.Add (newTowerUI);
        }
    }
}
