using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ChastInfo", menuName = "Gameplay/New Chest info")]
public class ChestInfo : ScriptableObject
{
    [SerializeField] private string _id;
    [SerializeField] private GameObject _prefab;
    [SerializeField] private Sprite _sprite;
    public string id => this._id;
    public GameObject prefab => this._prefab;
    public Sprite sprite => this._sprite;

}
