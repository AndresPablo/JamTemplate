using UnityEngine;

public class LaneSorter : MonoBehaviour
{
    [SerializeField] float spacing = 5;


    public void Sort()
    {
        int amount = transform.childCount;
        float xOffset = (amount * spacing) /2;

        for (int i = 0; i < amount; i++)
        {
            Transform child = transform.GetChild(i);
            float x = i*spacing-xOffset;
            Vector3 newPos = new Vector3(x, child.position.y, child.position.z);
            child.position = newPos;
        }
    }
}
