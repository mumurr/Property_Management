using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Property_Management.Models;
namespace Property_Management.Controllers
{
    public class UpdateFacilityController : ApiController
    {
        WuyeProjectEntities db = new WuyeProjectEntities();
        public IHttpActionResult Update(w_installation installation)
        {
            db.Entry(installation).State = System.Data.Entity.EntityState.Modified;
            if (db.SaveChanges() > 0)
            {
                return Ok(new { code = 200 });
            }

            return Ok(new { code = 50001 });
        }

    }
}
