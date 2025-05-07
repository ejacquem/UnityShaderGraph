using UnityEngine;

public class Grid3DLayout : MonoBehaviour
{
    [SerializeField]
    private GameObject _cellPrefab;
    [SerializeField]
    private float _rows;
    [SerializeField]
    private float _cols;
    [SerializeField]
    private float _spacing;

    public void GenerateGrid()
    {
        ClearGrid();

        for (int x = 0; x < _cols; x++)
        {
            for (int z = 0; z < _rows; z++)
            {
                Vector3 position = new Vector3(x * _spacing, 0, z * _spacing);
                GameObject cube = Instantiate(_cellPrefab, position, Quaternion.identity, transform);
                cube.name = $"Cube_{x}_{z}";
            }
        }
    }

    public void ClearGrid()
    {
        // Destroys all children
        for (int i = transform.childCount - 1; i >= 0; i--)
        {
            DestroyImmediate(transform.GetChild(i).gameObject);
        }
    }
}
