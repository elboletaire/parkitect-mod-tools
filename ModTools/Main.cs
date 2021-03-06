﻿using ModTools.Tools;
using ModTools.Tools.ObjectBrowser;
using UnityEngine;

namespace ModTools
{
    public class Main : IMod
    {
        private GameObject _go;

        public void onEnabled()
        {
            _go = new GameObject("Mod Tools");

            _go.AddComponent<ObjectBrowser>();
            _go.AddComponent<Console>();

            Debug.Log(_go);
        }

        public void onDisabled()
        {
            Object.Destroy(_go);
        }

        public string Name { get { return "ModTools"; } }
        public string Description { get { return "Helpers for mods"; } }
    }
}
