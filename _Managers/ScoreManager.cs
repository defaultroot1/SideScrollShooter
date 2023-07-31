using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideScrollShooter._Managers
{
	public static class ScoreManager
	{
		public static int score = 0;
		private static int highScore = 0;

		public static void Update()
		{
			CheckHighScore();
			System.Diagnostics.Debug.WriteLine($"Score: {score} - High Score: {highScore}");
		}

		public static void CheckHighScore()
		{
			if (score >= highScore)
			{
				highScore = score;
			}

		}
	}
}
