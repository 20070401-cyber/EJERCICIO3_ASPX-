using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio_3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["ddlCategory"] != null)
                {
                    ddlCategory.SelectedValue = Session["ddlCategory"].ToString();
                    ddlSupplier.SelectedValue = Session["ddlSupplier"].ToString();

                    lblProduct.Text = Session["strProduct"].ToString();
                    txtDescription.Text = Session["strDescription"].ToString();
                    lblImage.Text = Session["strImage"].ToString();

                    Decimal decPrice;

                    if (decimal.TryParse(Session["decPrice"].ToString(), out decPrice))
                    {
                        lblPrice.Text = decPrice.ToString("c");
                    }
                    else
                    {
                        lblPrice.Text = "Precio inválido";
                    }
                    lblPrice.Text = decPrice.ToString("c");

                    lblNumberInStock.Text = Session["bytNumberInStock"].ToString();
                    lblNumberOnOrder.Text = Session["bytNumberOnOrder"].ToString();
                    lblReorderLevel.Text = Session["bytReorderLevel"].ToString();

                    byte bytNumberInStock;
                    byte bytNumberOnOrder;

                    if (byte.TryParse(Session["bytNumberInStock"].ToString(), out bytNumberInStock) &&
                        byte.TryParse(Session["bytNumberOnOrder"].ToString(), out bytNumberOnOrder))
                    {
                        Decimal decprice = Convert.ToDecimal(Session["decPrice"]);

                        Decimal decValueInStock = decPrice * bytNumberInStock;
                        Decimal decValueOnOrder = decPrice * bytNumberOnOrder;

                        lblValueInStock.Text = decValueInStock.ToString("c");
                        lblValueOnOrder.Text = decValueOnOrder.ToString("c");
                    }
                    else
                    {
                        lblValueInStock.Text = "Error en datos";
                        lblValueOnOrder.Text = "Error en datos";
                    }
                }
            }
        }

            protected void btnConfirm_Click(object sender, EventArgs e)
            {
                Session["ddlCategory"] = ddlCategory.SelectedValue;
                Session["ddlSupplier"] = ddlSupplier.SelectedValue;
                Session["strProduct"] = txtProduct.Text;
                Session["strDescription"] = txtDescription.Text;
                Session["strImage"] = txtImage.Text;
                Session["decPrice"] = txtPrice.Text;
                Session["bytNumberInStock"] = txtNumberInStock.Text;
                Session["bytNumberOnOrder"] = txtNumberOnOrder.Text;
                Session["bytReorderLevel"] = txtReorderLevel.Text;

                Response.Redirect("WebForm1.aspx");
            }
        }
    } 
//modificacion para commit