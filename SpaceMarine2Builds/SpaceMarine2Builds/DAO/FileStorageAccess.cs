using SpaceMarine2Builds.Models;
using System.Text.Json;

namespace SpaceMarine2Builds.DAO
{
	public class FileStorageAccess : IFileStorageAccess
	{
		private readonly string _spaceMarinefilePath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "SpaceMarines.json");
		private readonly string _perksfilePath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "Perks.json");


		public List<SpaceMarine> GetAllSpaceMarines()
		{
			if (!File.Exists(_spaceMarinefilePath))
			{
				return new List<SpaceMarine>(); // Return an empty list if the file doesn't exist
			}

			var jsonData = File.ReadAllText(_spaceMarinefilePath);
			return JsonSerializer.Deserialize<List<SpaceMarine>>(jsonData);
		}

		public List<Perk> GetPerksByClassId()
		{
			if (!File.Exists(_perksfilePath))
			{
				return new List<Perk>(); // Return an empty list if the file doesn't exist
			}

			var jsonData = File.ReadAllText(_perksfilePath);
			return JsonSerializer.Deserialize<List<Perk>>(jsonData);
		}
	}
}
