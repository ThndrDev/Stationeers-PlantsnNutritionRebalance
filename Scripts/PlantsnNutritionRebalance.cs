using Stationeers.Addons;
using Stationeers.Addons.API;
using UnityEngine;


namespace PlantsnNutritionRebalance.Scripts
{
    public class PNRebalance : IPlugin
    {
        public void OnLoad()
        {
            Debug.Log("PlantsnNutritionRebalance: Mod is running!");
            PlantGrowStagePatch.PatchPrefabs();
        }
        public void OnUnload()
        {
            Debug.Log("PlantsnNutritionRebalance: Bye!");

        }
    }
}