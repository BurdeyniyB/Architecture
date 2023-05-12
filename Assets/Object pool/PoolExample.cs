using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolExample : MonoBehaviour
{
    [SerializeField] private int poolCount = 3;
    [SerializeField] private bool autoExpand = false;
    [SerializeField] private Cube cubePrefab;

    private PoolMono<Cube> pool;

    private void Start()
    {
        this.pool = new PoolMono<Cube>(this.cubePrefab, poolCount, this.transform);
        this.pool.autoExpand = autoExpand;
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            CreateCube();
        }
    }

    private void CreateCube()
    {
        var rX = Random.Range(-5, 5);    
        var rZ = Random.Range(-5, 5);
        var y = 0;

        var rPosition = new Vector3(rX, y, rZ);
        var cube = this.pool.GetFreeElement();
        cube.transform.position = rPosition;
    }
}
