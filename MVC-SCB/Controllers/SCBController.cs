using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using MVC_SCB.Models;
using Newtonsoft.Json;

namespace MVC_SCB.Controllers
{
    public class SCBController : Controller
    {
        // GET: SCB
        // http://stackoverflow.com/questions/37324/what-is-the-syntax-for-an-inner-join-in-linq-to-sql
        public ActionResult First()
        {
            using (var db = new PopulationContext())
            {
                var query = db.Municipalities.Include("MultiplicityName").Include("BirthRate.Gender");

                return View(query.ToList());
            }
        }

        public ActionResult Chart()
        {
            int rows;
            ViewBag.ChartData = ChartData(out rows);
            ViewBag.ChartRows = rows;

            return View("Chart");
        }

        [HttpPost]
        public ActionResult Chart(string txtSearch)
        {
            int rows;
            ViewBag.ChartData = ChartData(out rows, txtSearch);
            ViewBag.ChartRows = rows;

            return View("Chart");
        }

        private string ChartData(out int rows, string search = null)
        {
            using (var db = new PopulationContext())
            {
                var multiplicityQuery = db.Municipalities.Include("MultiplicityName").Include("BirthRates").OrderBy(m => m.MultiplicityName.Name);

                if (!string.IsNullOrWhiteSpace(search))
                    multiplicityQuery = (DbQuery<Multiplicity>)multiplicityQuery.Where(m => m.MultiplicityName.Name.ToLower().Contains(search.ToLower()));

                var chartData = new List<List<string>>
                {
                    new List<string>()
                    {
                        "Kommun",
                        "2010 - Male",
                        "2010 - Female",
                        "2011 - Male",
                        "2011 - Female",
                        "2012 - Male",
                        "2012 - Female",
                        "2013 - Male",
                        "2013 - Female",
                        "2014 - Male",
                        "2014 - Female",
                        "2015 - Male",
                        "2015 - Female"
                    }
                };

                rows = 0;

                foreach (var multiplicity in multiplicityQuery.ToList())
                {
                    rows++;

                    var list = new List<string>() {multiplicity.MultiplicityName.Name};

                    var birthRatesOrderd =multiplicity.BirthRates.OrderBy(b => b.Year).ThenBy(b => b.GenderId);

                    foreach (var birthRate in birthRatesOrderd)
                    {
                        list.Add(birthRate.Born.ToString());
                    }

                    chartData.Add(list);
                }

                var jsonS = new JavaScriptSerializer();

                return jsonS.Serialize(chartData);
            }
        }
    }
}

/*
     
     */
