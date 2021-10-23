using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchProject
{
    public class ECB_EntityManager
    {
		public List<ECB_Entity> entities;
		public ECB_EntityManager()
        {
			entities = new();
        }
		public void AddEntity(ECB_Entity e)
        {
			entities.Add(e);
        }
		public void Update()
		{
			foreach (ECB_Entity e in entities)
				e.Update();
		}
	}
}
