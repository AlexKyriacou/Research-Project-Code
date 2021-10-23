using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchProject
{
    /// <summary>
    /// Component manager for ECS with objects are pure aggregation
    /// </summary>
    public class CMA_ComponentManager
    {
        private static CMA_ComponentManager _instance;
        public List<CMA_CTransform> transforms;
        public List<CMA_CMovement> movements;
        public List<CMA_CColor> colors;
        private CMA_ComponentManager()
        {
            transforms = new();
            movements = new();
            colors = new();
        }
        public static void CreateInstance()
        {
            if(_instance == null)
            {
                _instance = new CMA_ComponentManager();
            }
        }
        public static CMA_ComponentManager GetInstance()
        {
            return _instance;
        }
        public static void ClearAll()
        {
            _instance = new CMA_ComponentManager();
        }
    }
}
