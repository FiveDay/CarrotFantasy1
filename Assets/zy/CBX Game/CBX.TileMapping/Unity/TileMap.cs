namespace CBX.TileMapping.Unity
{
    using UnityEngine;

    /// <summary>
    /// Provides a component for tile mapping.
    /// </summary>
    public class TileMap : MonoBehaviour
    {

        /// <summary>
        /// Gets or sets the number of rows of tiles.
        /// </summary>
        public int Rows;

        /// <summary>
        /// Gets or sets the number of columns of tiles.
        /// </summary>
        public int Columns;

        /// <summary>
        /// Gets or sets the value of the tile width.
        /// </summary>
        public float TileWidth = 1;

        /// <summary>
        /// Gets or sets the value of the tile height.
        /// </summary>
        public float TileHeight = 1;

        /// <summary>
        /// Used by editor components or game logic to indicate a tile location.
        /// </summary>
        /// <remarks>This will be hidden from the inspector window. See <see cref="HideInInspector"/></remarks>
        [HideInInspector]
        public Vector3 MarkerPosition;

        /// <summary>
        /// Initializes a new instance of the <see cref="TileMap"/> class.
        /// </summary>
        public TileMap()
        {
            this.Columns = 20;
            this.Rows = 10;
        }

		// Use this for initialization
		void Start () {

		}

		private void EraseAll()
		{
			// get reference to the TileMap component
			var map = (TileMap)this;
		}
		private void DrawAll()
		{
			var map = (TileMap)this;
			var rows = map.Rows;
			var cols = map.Columns;
			
			for (int row = 0; row < rows; row++) {
				for (int col = 0; col < cols; col++) {
					
					var objcet = GameObject.Find(string.Format("Tile_{0}_{1}", row, col));
					
					// if there is already a tile present and it is not a child of the game object we can just exit.
					if (objcet != null && objcet.transform.parent != map.transform)
					{
						return;
					}
					
					// if no game object was found we will create a cube
					if (objcet == null)
					{
						//cube = GameObject.CreatePrimitive(PrimitiveType.Quad);
						objcet = new GameObject();
					}
					
					// set the cubes position on the tile map
					var tilePositionInLocalSpace = new Vector3((row * map.TileWidth) + (map.TileWidth / 2), (col * map.TileHeight) + (map.TileHeight / 2));
					objcet.transform.position = map.transform.position + tilePositionInLocalSpace;
					
					// we scale the cube to the tile size defined by the TileMap.TileWidth and TileMap.TileHeight fields 
					objcet.transform.localScale = new Vector3(map.TileWidth, map.TileHeight, 1);
					
					// set the cubes parent to the game object for organizational purposes
					objcet.transform.parent = map.transform;
					
					objcet.AddComponent("Tile");
					
					// give the cube a name that represents it's location within the tile map
					objcet.name = string.Format("Tile_{0}_{1}", row, col);
				}
			}
		}
		/// <summary>
        /// When the game object is selected this will draw the grid
        /// </summary>
        /// <remarks>Only called when in the Unity editor.</remarks>
        private void OnDrawGizmosSelected()
        {
            // store map width, height and position
            var mapWidth = this.Columns * this.TileWidth;
            var mapHeight = this.Rows * this.TileHeight;
            var position = this.transform.position;

            // draw layer border
            Gizmos.color = Color.white;
            Gizmos.DrawLine(position, position + new Vector3(mapWidth, 0, 0));
            Gizmos.DrawLine(position, position + new Vector3(0, mapHeight, 0));
            Gizmos.DrawLine(position + new Vector3(mapWidth, 0, 0), position + new Vector3(mapWidth, mapHeight, 0));
            Gizmos.DrawLine(position + new Vector3(0, mapHeight, 0), position + new Vector3(mapWidth, mapHeight, 0));

            // draw tile cells
            Gizmos.color = Color.black;
            for (float i = 1; i < this.Columns; i++)
            {
                Gizmos.DrawLine(position + new Vector3(i * this.TileWidth, 0, 0), position + new Vector3(i * this.TileWidth, mapHeight, 0));
            }
            
            for (float i = 1; i < this.Rows; i++)
            {
                Gizmos.DrawLine(position + new Vector3(0, i * this.TileHeight, 0), position + new Vector3(mapWidth, i * this.TileHeight, 0));
            }

            // Draw marker position
			Gizmos.color = Color.yellow;    
			var startPos1 = this.MarkerPosition + new Vector3 (-this.TileWidth/2, this.TileHeight/2, 0);
			Gizmos.DrawLine (startPos1, startPos1 + new Vector3 (this.TileWidth, 0, 0));
			Gizmos.DrawLine (startPos1, startPos1 + new Vector3 (0, -this.TileHeight, 0));
			var startPos2 = this.MarkerPosition + new Vector3 (this.TileWidth/2, -this.TileHeight/2, 0);
			Gizmos.DrawLine (startPos2, startPos2 + new Vector3 (-this.TileWidth, 0, 0));
			Gizmos.DrawLine (startPos2, startPos2 + new Vector3 (0, this.TileHeight, 0));
		}
	}
}
