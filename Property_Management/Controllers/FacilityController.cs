using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Property_Management.Models;
namespace Property_Management.Controllers
{
    public class FacilityController : ApiController
    {
        WuyeProjectEntities db = new WuyeProjectEntities();

        /*添加周边设施方法*/
        public IHttpActionResult addFac(w_installation installation)
        {
            db.w_installation.Add(installation);
            if (db.SaveChanges() > 0)
            {
                return Ok(new { code = 200 });
            }
            return Ok(new { code = 50001 });
        }

        /*周边设施类型查询方法*/
        public IHttpActionResult getFacCate()
        {
            /*var data = db.w_system_params.ToList();*/
            /*外键关系问题,不能tolist*/
            var data = db.w_system_params.Select(s => new
            {
                s.id,
                s.name,
                s.type

            }).Where(p=>p.type=="周边设施");

            return Ok(new { code = 200, data });
        }
        /*周边设施列表查询方法*/
        public IHttpActionResult getFacList()
        {
            
            var date = db.w_installation.Join(db.w_system_params,m=>m.sp_id,f=>f.id,(m,f) => new
            {

                m.id,
                m.name,
                m.phone,
                m.main_name,
                m.contents,
                m.title,
                m.sp_id,
                nameca=f.name,
                type=f.type,
                codeid=f.code
            });
            var cate = db.w_installation.Join(db.w_system_params, m => m.sp_id, f => f.id, (m, f) => new
            {
                m.sp_id,
                nameca = f.name,
                type = f.type,
                codeid = f.code
            }).Distinct();
            
            /*            var data = db.w_installation.Select(s => new
                        {

                            s.id,
                            s.name,
                            s.phone,
                            s.main_name,
                            s.contents,
                            s.title,
                            s.sp_id
                        });*/


            return Ok(new { code = 200,date,cate
            });
        }

        /*周边设施列表修改方法*/
        public IHttpActionResult putFac(w_installation installation)
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
