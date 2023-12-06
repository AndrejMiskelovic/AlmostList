using AlmostList.Client.Models.Properties.Common;
using Android.Hardware.Lights;
using Xamarin.KotlinX.Coroutines;

namespace AlmostList.Client.Models.Properties.Character
{
    public class CharacterName : Name
    {
		public List<string>? AlternativeSpoiler {  get; set; }
	}
}