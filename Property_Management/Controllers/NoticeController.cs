using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Property_Management.Models;
namespace Property_Management.Controllers
{
    public class NoticeController : ApiController
    {
        WuyeProjectEntities db = new WuyeProjectEntities();

        /*添加公告*/
        public IHttpActionResult addNotice(w_announcement info)
        {
            db.w_announcement.Add(info);
            if (db.SaveChanges() > 0)
            {
                return Ok(new { code = 200 });
            }
            return Ok(new { code = 200 });
        }

        /*修改公告*/
        public IHttpActionResult putNotice(w_announcement info)
        {
            db.Entry(info).State = System.Data.Entity.EntityState.Modified;
            if (db.SaveChanges() > 0)
            {
                return Ok(new { code = 200 });
            }
            return Ok(new { code = 50001 });
        }
    }
}
