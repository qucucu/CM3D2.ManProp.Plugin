using UnityEngine;
using UnityInjector;
using UnityInjector.Attributes;
using PluginExt;

namespace CM3D2.ManProp.Plugin
{
    [PluginFilter("CM3D2x64"),
    PluginFilter("CM3D2x86"),
    PluginFilter("CM3D2VRx64"),
    PluginFilter("CM3D2OHx64"),
    PluginName("Man Prop"),
    PluginVersion("1.0.0.0")]
    public class ManProp : ExPluginBase
    {
        #region Constants
        class PluginConfig
        {
            public string[] manMenu= { "mhead000_i_.menu", "mhead001_i_.menu", "mhead002_i_.menu", "mhead003_i_.menu", "mhead004_i_.menu" };
        }

        #endregion
        #region Variables

        private PluginConfig config;

        #endregion
        #region Override Methods

        public void Awake()
        {
            GameObject.DontDestroyOnLoad(this);
            this.config = ReadConfig<PluginConfig>();
        }

        public void Start()
        {
        }

        public void OnLevelWasLoaded(int level)
        {
            var characterMgr = GameMain.Instance.CharacterMgr;
            var menus = config.manMenu;
            for (int number = 1; number < characterMgr.GetManCount(); number++)
            {
                var index = number - 1;
                if (menus.Length <= index)
                    break;
                var menu = menus[index];

                var man = characterMgr.GetMan(number);
                man.SetProp(MPN.head, menu, 0);
                man.AllProcProp();
            }
        }
        #endregion
    }
}
