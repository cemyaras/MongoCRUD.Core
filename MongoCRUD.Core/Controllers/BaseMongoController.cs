using Microsoft.AspNetCore.Mvc;
using MongoCRUD.Core.Models;
using MongoCRUD.Core.Services;

namespace MongoCRUD.Core.Controllers
{
    public class BaseMongoController<TModel> : ControllerBase
        where TModel : MongoBaseModel
    {
        public BaseMongoRepository<TModel> baseMongoRepository { get; set; }

        public BaseMongoController(BaseMongoRepository<TModel> baseMongoRepository)
        {
            this.baseMongoRepository = baseMongoRepository;
        }

        [HttpGet("{id}")]
        public virtual ActionResult GetModel(string id)
        {
            return Ok(baseMongoRepository.GetById(id));
        }

        [HttpGet]
        public virtual ActionResult GetModelList()
        {
            return Ok(baseMongoRepository.GetList());
        }

        [HttpPost]
        public virtual ActionResult AddModel(TModel model)
        {
            return Ok(baseMongoRepository.Create(model));
        }

        [HttpPut]
        public virtual ActionResult UpdateModel(string id,TModel model)
        {
            baseMongoRepository.Update(id, model);
            return Ok();
        }

        [HttpDelete("{id}")]
        public virtual void DeleteModel(string id)
        {
            baseMongoRepository.Delete(id);
        }
    }
}