using Stationeers.Addons;
using Stationeers.Addons.API;
using UnityEngine;
using System;
using System.IO;

namespace PlantsnNutritionRebalance.Scripts
{
    public class PNRebalance : IPlugin
    {
        public void OnLoad()
        {
            Debug.Log("PlantsnNutritionRebalance: Mod is running!");
        }
        public void OnUnload()
        {
            Debug.Log("PlantsnNutritionRebalance: Bye!");

        }
    }
}