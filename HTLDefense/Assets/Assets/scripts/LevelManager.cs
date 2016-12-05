using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

    [SerializeField]//damit man es in Unity zuweisen kann
    private GameObject tile;
    public float TileSize
    {
        get {return tile.GetComponent<SpriteRenderer>().sprite.bounds.size.x; }//kann nicht verändert werden und gibt immer richtigen Wert zurück
    }
	// Use this for initialization
	void Start ()
    {
        CreateLevel();
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    private void CreateLevel()
    {
        Vector3 worldStart = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height));
        for (int y = 0; y < 6; y++)//y position
        {
            for (int x = 0; x < 15; x++)//x position
            {
                PlaceTile(x,y, worldStart);
            }
        }

    }

    private void PlaceTile(int x, int y, Vector3 worldStart)
    {
        GameObject newTile = Instantiate(tile);//Instanzieren
        newTile.transform.position = new Vector3(worldStart.x + TileSize * x ,worldStart.y - TileSize * y, 0);
    }
}
