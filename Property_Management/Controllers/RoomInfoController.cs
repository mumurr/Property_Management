using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Property_Management.Models;
namespace Property_Management.Controllers
{
    public class RoomInfoController : ApiController
    {
        WuyeProjectEntities db = new WuyeProjectEntities();
        
        public IHttpActionResult getInfo()
        {
            var data = db.w_room_info.ToList();

            var time=Convert.ToDateTime(data[0].construct_date).ToString("yyyy-MM-dd");
            return Ok( new { code = 200,data, time });
        }

        public IHttpActionResult updateInfo(w_room_info info)
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
