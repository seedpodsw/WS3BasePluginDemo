using UnityEngine;
using BepInEx;

public class CustomPatches : BaseUnityPlugin
{
        public static bool Boot_Patch(Computer pc, GameObject character)
        {
            //it has been patched, the PC will not load this is an example
            //of patching a function within weed shop 3
            return false;
        }

    }
