﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using webAPI.Models;

namespace webAPI.Controller
{
    public class AccountController : ApiController
    {
      //  [HttpPost]
        public async Task<IHttpActionResult> registration(userData account)
        {
            //User.Identity.Name==>Claims["Name"]
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                UserStore<IdentityUser> store =
                    new UserStore<IdentityUser>(new context());

                UserManager<IdentityUser> manager =
                    new UserManager<IdentityUser>(store);
                IdentityUser user = new IdentityUser();
                user.UserName = account.Name;
                user.PasswordHash = account.Password;

                IdentityResult result = await manager.CreateAsync(user, account.Password);
                if (result.Succeeded)
                {
                    //string locat = Url.Link("DefaultApi", new { })
                    return Created("", "register Sucess " + user.UserName);
                }
                else
                    return BadRequest((result.Errors.ToList())[0]);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
