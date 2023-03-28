using BlazorSyncfusionCrm.Server.Data;
using BlazorSyncfusionCrm.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorSyncfusionCrm.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ContactsController : ControllerBase
	{
        private readonly DataContext _context;

        public ContactsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Contact>>> GetAllContacts()
        {
            return await _context.Contacts
                .Where(c => !c.isDeleted)
                .ToListAsync();
        }

		[HttpGet("{id}")]
		public async Task<ActionResult<Contact>> GetContactById(int id)
		{
            var result = await _context.Contacts.FindAsync(id);

            if (result is null)
            {
                return NotFound("Contact not found");
            }
            return result;
		}
	}
}
