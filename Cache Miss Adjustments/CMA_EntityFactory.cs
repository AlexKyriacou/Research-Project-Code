using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace ResearchProject
{
    public class CMA_EntityFactory
    {
        public static void MakeBall(int x, int y, int dx, int dy)
        {
            CMA_CTransform transform = new();
            transform.x = x;
            transform.y = y;
            CMA_ComponentManager.GetInstance().transforms.Add(transform);
            CMA_CColor color = new();
            color.color = Color.Blue;
            CMA_ComponentManager.GetInstance().colors.Add(color);
            CMA_CMovement movement = new();
            movement.dx = dx;
            movement.dy = dy;
            CMA_ComponentManager.GetInstance().movements.Add(movement);
        }
    }
}
