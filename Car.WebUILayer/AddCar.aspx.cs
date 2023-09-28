using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel;
using Car.WebUILayer.ServiceReference1;

namespace Car.WebUILayer
{
    public partial class AddCar : System.Web.UI.Page
    {

     public static   ServiceReference1.CarServiceClient carServiceClientProxy = new ServiceReference1.CarServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            try
            {

                Car.Entities.Car carObj = new Entities.Car()
                {
                    CarName = txtCarName.Text,
                    ModelNumber = Convert.ToInt32(txtCarModel.Text),
                    Features =  txtFeature.Text,
                    Comments = txtComment.Text

                };
                carServiceClientProxy.AddACar(carObj);
                lblStatus.ForeColor = System.Drawing.Color.Green;
                lblStatus.Text = "Car details are added successfully!";
                

                txtCarModel.Text = "";
                txtCarName.Text = "";
                txtComment.Text = "";
                txtFeature.Text = "";
              
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
}