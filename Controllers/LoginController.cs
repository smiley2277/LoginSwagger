using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EYPractice.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SQLitePCL;

namespace EYPractice
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly LoginInfoContext _context;
        public LoginController(LoginInfoContext context){
            _context = context;
        }
        [HttpPost("Login")]
        public ApiResult Login(LoginInfo info){
            ApiResult result = new ApiResult();
            try{
                LoginInfo logingInfo = _context.LoginInfos.SingleOrDefault(x=> x.account==info.account && x.password == info.password);
                if (logingInfo != null){
                    result.message = "Success";
                    result.code = 1;
                    result.data = "";
                    result.status = "1";
                }
            }
            catch(Exception e){

                result.code = 0;
                result.message = e.Message;
                result.status = "";
                result.data = "";
            }
            return result;
        }

        [HttpPost("Register")]
        public ApiResult Register(LoginInfo info){
            ApiResult result = new ApiResult();
            try{
                _context.LoginInfos.Add(info);
                _context.SaveChanges();

                result.code = 1;
                result.message = "";
                result.status = "Successed";
                result.data = "";

            }catch(Exception e){

                result.code = 0;
                result.message = e.Message;
                result.status = "";
                result.data = "";
            }
            return result;
            
        }
        [HttpGet("Try")]
        public string Try(){ 
            string result = "";
            try{
                result = "Function normally";
            }
            catch(Exception e){
                result = e.Message;
            }
            return result;
        }
    }
}