using SideScrollShooter._Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideScrollShooter._Models
{
	internal class GUI
	{
		private SpriteFont _scoreFont;
		public GUI() 
		{
			_scoreFont = Globals.ContentManger.Load<SpriteFont>("Fonts/scoreFont");
		}

		public void Update()
		{
			//
		}

		public void Draw()
		{
			DrawCurrentScore();
			DrawHiScore();
		}

		public void DrawCurrentScore()
		{
			string str = ScoreManager.score.ToString("D4");
			Globals.SpriteBatch.DrawString(_scoreFont, str, new Vector2(300, 10), Color.White);
		}
		public void DrawHiScore()
		{
			string str = $"HI {ScoreManager.HighScore.ToString("D4")}";
			Globals.SpriteBatch.DrawString(_scoreFont, str, new Vector2(700, 10), Color.White);
		}


	}
}
