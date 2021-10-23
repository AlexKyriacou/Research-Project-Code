using System;
using SplashKitSDK;
using ResearchProject;
using System.Diagnostics;
using System.Collections.Generic;
using System.Timers;

public class Program
{
	public static void Main()
	{
		CMA_ComponentManager.CreateInstance();
		TestRunner testRunner = new();
		Window w = new Window("ECB", 800, 600);
		for (int time = 5000; time <= 60000; time+=5000)
		{
			for (int BallCount = 50; BallCount <= 5000; BallCount+=50)
			{
				for(int k = 0; k<5; k++)
                {
					testRunner.RunTest(BallCount, time);
					GC.Collect();
                }
				Console.WriteLine($"Test Balls: {BallCount} Time: {time} Done");
			}
		}
	}
}
