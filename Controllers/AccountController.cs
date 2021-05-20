using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AllSpice.Models;
using AllSpice.Services;
using CodeWorks.Auth0Provider;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AllSpice.Controllers 
{

    [ApiController]
    [Route("[controller]")]
    [Authorize]
    
    public class AccountController : ControllerBase
    {
        private readonly AccountsService _service;
        private readonly RecipesService _serviceRecipe;

    public AccountController(AccountsService service, RecipesService serviceRecipe)
    {
      _service = service;
      _serviceRecipe = serviceRecipe;
    }

    [HttpGet]
    public async Task<ActionResult<Account>> Get()
    {
        try
        {
        Account userInfo = await HttpContext.GetUserInfoAsync<Account>();
        Account currentUser = _service.GetOrCreateAccount(userInfo);
        return Ok(currentUser);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }


  }
}