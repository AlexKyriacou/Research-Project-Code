using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace ResearchProject
{
    public class TestRunner
    {
        public void RunTest(int ballcount, int time)
        {
			CMA_ComponentManager.ClearAll();
			CMA_SCollide cMA_SCollide = new();
			CMA_SMovement cMA_SMovement = new();
			CMA_SRender cMA_SRender = new();
			ECB_EntityManager ECB_Entities = new ECB_EntityManager();
			List<ECS_Entity> ECS_Entities = new List<ECS_Entity>();
			List<Ball> ETI_Entities = new List<Ball>();
			Stopwatch stopwatch = new();
			int currentTimer = time;

			#region RandomNumberGeneration
			Random rnd = new Random();
			int[] xLocations = new int[ballcount];
			int[] yLocations = new int[ballcount];
			int[] dxValues = new int[ballcount];
			int[] dyValues = new int[ballcount];
			int num;
			for (int i = 0; i < ballcount; i++)
			{
				xLocations[i] = rnd.Next(800);
				yLocations[i] = rnd.Next(600);
				num = rnd.Next(-3, 3);
				while (num == 0)
				{
					num = rnd.Next(-3, 3);
				}
				dxValues[i] = num;
				num = rnd.Next(-3, 3);
				while (num == 0)
				{
					num = rnd.Next(-3, 3);
				}
				dyValues[i] = num;
			}
			#endregion RandomNumberGeneration

			for (int i = 0; i < ballcount; i++)
			{
				ECB_Entities.AddEntity(ECB_EntityFactory.MakeBall(xLocations[i], yLocations[i], dxValues[i], dyValues[i]));
				ECS_Entities.Add(ECS_EntityFactory.MakeBall(xLocations[i], yLocations[i], dxValues[i], dyValues[i]));
				ETI_Entities.Add(new Ball(xLocations[i], yLocations[i], dxValues[i], dyValues[i]));
				CMA_EntityFactory.MakeBall(xLocations[i], yLocations[i], dxValues[i], dyValues[i]);
			}

			ECS_SCollide eCS_SCollide = new ECS_SCollide(ECS_Entities);
			ECS_SMovement eCS_SMovement = new ECS_SMovement(ECS_Entities);
			ECS_SRender eCS_SRender = new ECS_SRender(ECS_Entities);

			int frames = 0;
			stopwatch.Start();
			do
			{
				SplashKit.ProcessEvents();
				SplashKit.ClearScreen();
				ECB_Entities.Update();
				SplashKit.RefreshScreen();
				frames++;
			} while (stopwatch.ElapsedMilliseconds < currentTimer);
			AddRecord(ballcount, time, "ECB", frames);

			frames = 0;
			stopwatch.Restart();
			do
			{
				SplashKit.ProcessEvents();
				SplashKit.ClearScreen();
				eCS_SMovement.Update();
				eCS_SCollide.Update();
				eCS_SRender.Update();
				SplashKit.RefreshScreen();
				frames++;
			} while (stopwatch.ElapsedMilliseconds < currentTimer);
			AddRecord(ballcount, time, "ECS", frames);

			frames = 0;
			stopwatch.Restart();
			do
			{
				SplashKit.ProcessEvents();
				SplashKit.ClearScreen();
				foreach (Ball ball in ETI_Entities)
				{
					ball.Update();
					ball.Collide();
					ball.Render();
				}
				SplashKit.RefreshScreen();
				frames++;
			} while (stopwatch.ElapsedMilliseconds < currentTimer);
			AddRecord(ballcount, time, "ETI", frames);

			frames = 0;
			stopwatch.Restart();
			do
			{
				SplashKit.ProcessEvents();
				SplashKit.ClearScreen();
				cMA_SMovement.Update();
				cMA_SCollide.Update();
				cMA_SRender.Update();
				SplashKit.RefreshScreen();
				frames++;
			} while (stopwatch.ElapsedMilliseconds < currentTimer);
			AddRecord(ballcount, time, "CMA", frames);
		}
		public static void AddRecord(int balls, int time, string type, int frames)
		{
			try
			{
				using (System.IO.StreamWriter file = new($"C:/Users/Alex/Desktop/OOP/ResearchResults/Results{ type }.txt", true))
				{
					file.WriteLine($"{balls},{time},{type},{frames}");
				}
			}
			catch (Exception ex)
			{
				throw new ApplicationException("Something went wrong writing to results csv", ex);
			}
		}
	}
}
