using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WcfService;

namespace WebApp
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Int32 n1 = Request["n1"] != null ? Int32.Parse(Request["n1"]) : 0;
            //Int32 n2 = Request["n2"] != null ? Int32.Parse(Request["n2"]) : 0;
            //lbl_result.Text = client.Add(n1, n2).ToString(); 
        }



        protected async void btn_encrypt_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
                string cipherCode = client.Encrypt(tbx_plaintext.Text, tbx_passphrase.Text);
                lbl_result.Text = cipherCode;
           
                using (var db = new Nome_CodeContext())
                {
                    var nome_code = new Nome_Code { Name = tbx_name.Text, Code = cipherCode };
                    db.Names_Codes.Add(nome_code);

                    db.SaveChanges();
                }

                // Svuoto i campi
                tbx_name.Text = tbx_passphrase.Text = tbx_plaintext.Text = "";
            });
        }




        protected async void btn_decrypt_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                if (!string.IsNullOrEmpty(tbx_name_for_decrypt.Text))
                {
                    using (var db = new Nome_CodeContext())
                    {
                        var name_code = db.Names_Codes
                        .Where(n => n.Name == tbx_name_for_decrypt.Text)
                        .FirstOrDefault();

                        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
                        lbl_result_after_decrypt.Text = client.Decrypt(name_code.Code, tbx_passphrase_for_decrypt.Text);

                        tbx_name_for_decrypt.Text = tbx_passphrase_for_decrypt.Text = "";
                    }
                }
                else
                {
                    lbl_result.Text = "Il campo Name non può essere vuoto.";
                }
            });
        }
    }
}