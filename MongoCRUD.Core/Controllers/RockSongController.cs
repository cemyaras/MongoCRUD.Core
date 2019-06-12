using Microsoft.AspNetCore.Mvc;
using MongoCRUD.Core.Models;
using MongoCRUD.Core.Services;

namespace MongoCRUD.Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RockSongController : BaseMongoController<RockSong>
    {
        public RockSongController(RockSongRepository rockSongRepository):base (rockSongRepository)
        {

        }
    }
}