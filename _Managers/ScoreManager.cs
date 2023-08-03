using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace SideScrollShooter._Managers
{
	public static class ScoreManager
	{
		private const string highScoreFileName = "C:\\Users\\u01\\OneDrive\\C#\\Games\\SideScrollShooter\\highscore.txt";
		public static int score = 0;
		private static int highScore = 0;
		public static int HighScore => highScore;

		public static void Update()
		{
			CheckHighScore();
			System.Diagnostics.Debug.WriteLine($"Score: {score} - High Score: {highScore}");
			SaveHighScore();
		}

		public static void CheckHighScore()
		{
			if (score >= highScore)
			{
				highScore = score;
			}

		}

		public static void LoadHighScore()
		{

			string highScoreString = File.ReadAllText(highScoreFileName);
			int.TryParse(highScoreString, out highScore);
			
		}

		public static void SaveHighScore()
		{
			if (score >= highScore)
			{
				File.WriteAllText(highScoreFileName, score.ToString());
			}


		}
	}
}
