using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GlobalsItems
{
    private static int totalCollected = 0;
    private static string[] itemTags = {"Beer", "Volleyball", "Lifesaver", "Beachball"};
    private static bool[] itemsCollected = {false, false, false, false};

    public static string GetItemTag(int id)
    {
        return itemTags[id];
    }

    public static bool IsItemCollected(int id)
    {
        return itemsCollected[id];
    }

    public static void CollectItem(int id)
    {
        if (!itemsCollected[id])
        {
            itemsCollected[id] = true;
            totalCollected++;
        }
    }

    public static int GetTotalCollected()
    {
        return totalCollected;
    }

    public static int GetTotalItems()
    {
        return itemTags.Length;
    }
}
