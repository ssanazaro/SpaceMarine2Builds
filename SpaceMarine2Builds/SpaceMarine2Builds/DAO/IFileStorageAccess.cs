using SpaceMarine2Builds.Models;

namespace SpaceMarine2Builds.DAO
{
	public interface IFileStorageAccess
	{
		List<SpaceMarine> GetAllSpaceMarines();
		List<Perk> GetPerksByClassId();
	}
}
