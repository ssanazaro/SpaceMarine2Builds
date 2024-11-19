using Microsoft.AspNetCore.Mvc;
using SpaceMarine2Builds.DAO;
using SpaceMarine2Builds.Models;

namespace SpaceMarine2Builds.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class CharacterController : Controller
	{
		private readonly IFileStorageAccess _fileStorageAccess;

		public CharacterController(IFileStorageAccess fileStorageAccess)
		{
			_fileStorageAccess = fileStorageAccess;
		}

		[HttpGet("/GetAllSpaceMarines")]
		public IActionResult GetAllSpaceMarines()
		{
			var response = _fileStorageAccess.GetAllSpaceMarines();
			return Ok(response); // Ensuring a proper JSON response
		}


		[HttpGet("/GetPerksByClassId/{classId}")]
		public List<Perk> GetPerksByClassId(int classId)
		{
			var response = _fileStorageAccess.GetPerksByClassId();
			return response;
		}
	}
}
