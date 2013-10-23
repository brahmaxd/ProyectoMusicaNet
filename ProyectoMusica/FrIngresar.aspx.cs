using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class FrIngresar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btIngresar_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrBuscador.aspx");
    }
    protected void btCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("FrMaestro.aspx");
    }
}
