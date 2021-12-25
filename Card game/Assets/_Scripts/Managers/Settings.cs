using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace SA
{
    public static class Settings
    {
        private static ResourceManager _resourceManager;

        public static ResourceManager GetResourceManager() 
        {            
            if (_resourceManager == null)
            {
                _resourceManager = Resources.Load("ResourceManager") as ResourceManager;
            }
            return _resourceManager;
        }
    }
}

