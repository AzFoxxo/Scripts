using UnityEngine;

public class GenerateGridOfGameObjectsFromCentre : MonoBehaviour
{
    [SerializeField] ushort width = 3; // Width

    [SerializeField] ushort height = 3; // Height

    [SerializeField] private GameObject objectToPlace; // Gameobject to spawn

    [SerializeField] private Transform initalPoint; // Initial position to start from

    [SerializeField] private float objectSizeInUnits = 4f; // Should be the size of the gameobject exactly

    private void Start()
    {

        // Change initial position to centre it
        float offsetX = -(width * objectSizeInUnits + objectSizeInUnits);
        float offsetZ = height * objectSizeInUnits + objectSizeInUnits;

        // Create the cubes where towers can be placed
        for (var x = 0; x < width * 2 + 1; x++)
        for (var z = 0; z < height * 2 + 1; z++)
        {
            // Create the placeable object
            var towerPlace = Instantiate(objectToPlace, initalPoint);

            // Make the object's position match it's position in the grid
            towerPlace.transform.position =
                new Vector3(offsetX +
                    (towerPlace.transform.position.x + objectSizeInUnits * x),
                    towerPlace.transform.position.y,
                    offsetZ + (towerPlace.transform.position.z + objectSizeInUnits * -z));
        }

        // Destroy this instance of it since it contains this script and overlaps with the newly placed one
        Destroy (gameObject);
    }
}
