using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyAPINetCore6.Models;
using MyAPINetCore6.Repositories;

namespace MyAPINetCore6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThongTinCCCNController : ControllerBase
    {
        private readonly IThongTinCCCNRepository _ThongTinCCCN;

        public ThongTinCCCNController(IThongTinCCCNRepository repo)
        {
            _ThongTinCCCN = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _ThongTinCCCN.GetAllThongTinCCCNAsync());
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByID(int id)
        {
            var ThongTinCCCN = await _ThongTinCCCN.GetThongTinCCCNAsync(id);
            return ThongTinCCCN == null ? NotFound() : Ok(ThongTinCCCN);
        }

        [HttpPost]
        //[Authorize]
        public async Task<IActionResult> AddNew(ThongTinCCCNModel model)
        {
            try
            {
                var newThongTinCCCNId = await _ThongTinCCCN.AddThongTinCCCNAsync(model);
                var ThongTinCCCN = await _ThongTinCCCN.GetThongTinCCCNAsync(newThongTinCCCNId);
                return ThongTinCCCN == null ? NotFound() : Ok(ThongTinCCCN);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        //[Authorize]
        public async Task<IActionResult> Update(int id, ThongTinCCCNModel model)
        {
            try
            {
                if(id != model.Id)
                {
                    return NotFound();
                }
                await _ThongTinCCCN.UpdateThongTinCCCNAsync(id, model);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
            
        }

        [HttpDelete("{id}")]
        //[Authorize]
        public async Task<IActionResult> Delete(int id, ThongTinCCCNModel model)
        {
            try
            {
                await _ThongTinCCCN.DeleteThongTinCCCNAsync(id);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
            
        }
    }
}
