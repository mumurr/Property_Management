using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Property_Management.Models;

namespace Property_Management.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class AdminLoginController : ApiController
    {
        WuyeProjectEntities db = new WuyeProjectEntities();

        [HttpPost]
        public IHttpActionResult getUser([FromBody] w_user user)
        {
            var date = db.w_admin.FirstOrDefault(p => p.username == user.username);
            if (date == null)
            {
                var message = new { msg = "账户不存在" };
                return Content(HttpStatusCode.OK, message);
            }else if (date.pass != user.password)
            {
                return Content(HttpStatusCode.OK,new { message = "密码不正确" });
            }
            else
            {
                var data = new { token = "abc" };
                return Ok(new { message = "成",code=200,
                    token = "abc"
                });
            }
        }
    }
}
