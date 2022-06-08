using BepInEx;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using HarmonyLib;
using System.Reflection;
using HarmonyLib.Tools;
using almost;

namespace BaseWeedPlugin
{
    [BepInPlugin(PLUGIN_GUID, PLUGIN_NAME, PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {

        public const string PLUGIN_GUID = "yoName.bepinex.weedshop3.plugin";
        public const string PLUGIN_NAME = "BaseWeedPlugin";
        public const string PLUGIN_VERSION = "0.0.1";
        public GameObject player = null;

        private void Awake()
        {
            // Plugin startup logic

            Logger.LogInfo($"Plugin BaseWeedPlugin is loaded!");

            Harmony harmony = new Harmony(PLUGIN_GUID);

            HarmonyFileLog.Enabled = true;

            MethodInfo original = AccessTools.Method(typeof(HighOS), "Boot");
            MethodInfo patch = AccessTools.Method(typeof(CustomPatches), "Boot_Patch");
            harmony.Patch(original, new HarmonyMethod(patch));

            Debug.Log("Test if unity debug log works");
            Logger.LogInfo($"Bepenix debug log ");
        }


        void Update() { 
            if (Input.GetKeyDown(KeyCode.LeftControl))
            {
                player = GameObject.FindGameObjectWithTag("Player").gameObject;
                // this makes the player huge when you hit P
                player.transform.localScale = new Vector3(1f, 15f, 1f);
                Logger.LogInfo($"Yo pressed the button that mad yo ass huge");

            }

            if (Input.GetKeyDown(KeyCode.RightControl))
            {
                player = GameObject.FindGameObjectWithTag("Player").gameObject;
                // this makes the player normal again
                player.transform.localScale = new Vector3(1, 1, 1);
                Logger.LogInfo($"Yo pressed the button that mad yo ass nominal again. whew");

            }

            if (Input.GetKeyUp("8"))
            {
                //loads the empty scene where you can playground fast without game stuff
                SceneManager.LoadScene("WeedGameBase");
            }

            if (Input.GetKeyUp("down"))
            {
                //use down arrow key to make a stupid canvas element that says TEST 

                GameObject g = new GameObject();
                Canvas canvas = g.AddComponent<Canvas>();
                canvas.renderMode = RenderMode.ScreenSpaceOverlay;
                CanvasScaler cs = g.AddComponent<CanvasScaler>();
                cs.scaleFactor = 10f;
                GraphicRaycaster gr = g.AddComponent<GraphicRaycaster>();
                g.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 3.0f);
                g.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 3.0f);
                GameObject g2 = new GameObject()
                {
                    name = "Text"
                };
                g2.transform.parent = g.transform;
                g2.transform.localPosition = new Vector3(0, 0, 0);

                Text t = g2.AddComponent<Text>();
                g2.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 3.0f);
                g2.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 3.0f);
                t.alignment = TextAnchor.MiddleCenter;
                t.horizontalOverflow = HorizontalWrapMode.Overflow;
                t.verticalOverflow = VerticalWrapMode.Overflow;
                Font ArialFont = (Font)Resources.GetBuiltinResource(typeof(Font), "Arial.ttf");
                t.font = ArialFont;
                t.fontSize = 7;
                t.text = "Test";
                t.enabled = true;
                t.color = Color.black;

                g.name = "Text Label";
                bool bWorldPosition = false;

                g.GetComponent<RectTransform>().SetParent(this.transform, bWorldPosition);
                g.transform.localPosition = new Vector3(0f, 0f, 0f);
                g.transform.localScale = new Vector3(
                                                     1.0f / this.transform.localScale.x * 0.1f,
                                                     1.0f / this.transform.localScale.y * 0.1f,
                                                     1.0f / this.transform.localScale.z * 0.1f);



                Debug.Log(g + " " + g.transform.localScale + " " + g.transform.localPosition);
                g.SetActive(true);

            }

        }


        
    }
}
