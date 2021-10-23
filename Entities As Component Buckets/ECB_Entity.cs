using System;
using System.Collections.Generic;
using System.Text;

namespace ResearchProject
{
	public class ECB_Entity
	{
		public List<ECB_Component> components;
		//Try Dict Later
		//public Dictionary<Type, Component> components;
		public ECB_Entity()
        {
			components = new();
        }
		public void Update()
		{
			foreach (ECB_Component c in components)
            {
				c.Update();
			}
		}

		public void AddComponent(ECB_Component c)
		{
			components.Add(c);
			c.entity = this;
		}
		public T GetComponent<T>() where T : ECB_Component
		{
			foreach (ECB_Component component in components)
			{
				if (component.GetType().Equals(typeof(T)))
				{
					return (T)component;
				}
			}
			return null;
		}
	}
}
