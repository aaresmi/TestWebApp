using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Car.WebUILayer.ServiceReference1;
using System.ServiceModel;

namespace Car.WebUILayer
{
    public partial class RetirveCarDetails : System.Web.UI.Page
    {
        ServiceReference1.CarServiceClient carServiceClientProxy = new ServiceReference1.CarServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               // string[] all = carServiceClientProxy.RetrieveAllCars();

                try
                {
                    ddlCars.DataSource = carServiceClientProxy.RetrieveAllCars();

                    ddlCars.DataTextField = "CarName";
                    ddlCars.DataValueField = "CarId";
                
                    ddlCars.DataBind();
                }
                catch (FaultException<CarServiceError> ex)
                {
                    lblStatus.ForeColor = System.Drawing.Color.Red;

                    //Display the error message in a label in the web.
                    lblStatus.Text = ex.InnerException.Message;

                }

                catch (Exception ex)
                {
                    lblStatus.ForeColor = System.Drawing.Color.Red;

                    //Display the error message in a label in the web.
                    lblStatus.Text = ex.InnerException.Message;
                }


            }
        }

        protected void ddlCars_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {

                DropDownList list = (DropDownList)sender;
                int i = list.SelectedIndex + 2;
                List<Entities.Car> listOfCars = carServiceClientProxy.RetrieveAllCarsDetails(i).ToList<Entities.Car>();
                gridCars.DataSource = listOfCars;
                gridCars.DataBind();
            }
            catch (FaultException<CarServiceError> ex)
            {
                lblStatus.ForeColor = System.Drawing.Color.Red;

                //Display the error message in a label in the web.
                lblStatus.Text = ex.InnerException.Message.ToString();

            }

            catch (Exception ex)
            {
                lblStatus.ForeColor = System.Drawing.Color.Red;

                //Display the error message in a label in the web.
                lblStatus.Text = ex.InnerException.Message.ToString();
            }

            
        }

    }
}