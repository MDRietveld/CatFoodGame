using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProefTentamen
{
	abstract public class GameObject
	{
		public Texture2D       Texture		{ get; set; }
		public Vector2         Position    { get; set; }
		protected Vector2      Centerpoint { get; set; }
		protected Color        Color       { get; set; }
		protected float        Speed       { get; set; }
		protected float        Scale       { get; set; }
		protected float        Rotation 	{ get; set; }

		public GameObject(Vector2 position)
		{
			Position = position;
			Centerpoint = Vector2.Zero;
			Scale = 1;

		}

		public Rectangle Bounds
		{
			get
			{
				return new Rectangle(
					(int)Position.X,
					(int)Position.Y,
					(int)(Texture.Width * Scale),
					(int)(Texture.Height * Scale));
			}
		}


		//Abstract gemaakt omdat alle classes die van GameObject erven een eigen update moeten hebben
		public abstract void Update (GameTime gameTime);

		//Abstract gemaakt omdat ik wil dat beide classes een klik functie moeten hebben
		public abstract void ButtonClick();

		public virtual void Draw(SpriteBatch spriteBatch){
			spriteBatch.Draw(
				Texture,
				Position,
				null,
				Color.White,
				Rotation,
				Centerpoint,
				1,
				SpriteEffects.None,
				0);
		}
	}
}

