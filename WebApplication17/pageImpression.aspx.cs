using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrystalDecisions.ReportSource;
using CrystalDecisions.CrystalReports.Engine;
namespace WebApplication17
{
    public partial class pageImpression : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string a = Request.QueryString["etat"];
            ReportClass cr;
            //System.Diagnostics.Debug.WriteLine("etat="+a);
            switch (a)
            {
                case "1": 
                     cr = new listeOuvrages();
                     cr.SetDatabaseLogon("sa", "P@ssw0rd");
                     CrystalReportViewer1.ReportSource = cr;
                    break;
                case "2":
                    cr = new listeEditeurs();
                    cr.SetDatabaseLogon("sa", "P@ssw0rd");
                    CrystalReportViewer1.ReportSource = cr;
                   break;
            }

       
        }
    }
}