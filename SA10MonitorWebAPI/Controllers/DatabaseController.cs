using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Sql;
using SA10MonitorDatabaseAccess;
using Newtonsoft.Json;


namespace SA10MonitorWebAPI.Controllers
{
    public class DatabaseController : ApiController
    {
        SA10_Monitor_DatabaseEntities db = new SA10_Monitor_DatabaseEntities();

        [HttpGet]
        public IEnumerable<AssetStatus> Get()
        {
            return db.AssetStatus.ToList();
        }

        [HttpGet]
        public IEnumerable<AssetStatus> GetbyAssetID(string id)
        {
            return db.AssetStatus.Where(e => e.assetID == id).ToList();
        }

        [HttpPost]
        public void PostDatabase([FromBody] AssetStatus request)
        {
            db.AssetStatus.Add(request);
            db.SaveChanges();
        }
    }
}
