using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProefTentamen
{
	public class Cat : GameObject, IObserver
	{

		private MouseState _previousMouse;
		private MouseState _mouse;
		IState state;
		FoodBowl bowl;

		public Cat(Vector2 position, FoodBowl b) : base (position) {
			state = new Sleeping (this);
			bowl = b;
		}



		// update functie kijkt of er geklikt is binnen de bounds
		public override void Update(GameTime gameTime){
			_mouse = Mouse.GetState();

			bool mouseHit = (Bounds.Contains(_mouse.X, _mouse.Y));
			bool mouseClicked = (_mouse.LeftButton != _previousMouse.LeftButton && _mouse.LeftButton == ButtonState.Pressed);

			if(mouseHit && mouseClicked) {
				ButtonClick();
			}

			_previousMouse = _mouse;

			state.Update (gameTime);
		}

		//Zodra de IState Awake wordt zorgt de constructor van Awake ervoor dat deze functie wordt uitgevoerd.
		//Deze functie zelf zorgt ervoor dat de functie in FoodBowl wordt uitgevoerd waardoor die aan de lijst wordt toegevoegd om eten te kunnen krijgen
		public void RegisterCat()
		{
			bowl.RegisterCat (this);
		}

		//Veranderd state met ingave van de state die wordt doorgegeven zie Sleeping.cs Eating.cs en Playing.cs
		public void ChangeState(IState s)
		{
			state = s;
		}

		//Word uitgevoerd als er op de bak wordt geklikt (Voor alle observers uit de list)
		public void OnFood ()
		{
			state = new Eating (this);
		}

		//Na de click gaat hij de functie uitvoeren in de state die momenteel is aangegeven
		public override void ButtonClick(){
			state.StateClick ();
		}
	}
}