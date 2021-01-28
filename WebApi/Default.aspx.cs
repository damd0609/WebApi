using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Serialization;
using WebService_WebAPI.Models;

namespace WebApi
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //CargarCategorias();
            //BloquearCampos();
        }


        /*private void limpiarCampos()
        {
            txtId.Text = "";
            txtLong.Text = "";
            txtShort.Text = "";
            lblResult.Text = "";
        }
        private void EliminarCategorias()
        {
            // Configurar la url para pasar un parametro y poder eliminar
            string url = "https://localhost:44325/api/Categories/"+txtId.Text;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);

              
                var deleteTask = client.DeleteAsync(client.BaseAddress);
                deleteTask.Wait();

                var result = deleteTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    CargarCategorias();
                    lblResult.Text = "Registro Eliminado";

                   
                }
                else
                {
                    lblResult.Text = "Ha ocurrido un error";
                }
            }
        }
        private void BloquearCampos()
        {
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void CargarCategorias()
        {
            // Configurar la url para realizar la petición HTTP
            string url = "https://localhost:44325/api/Categories/";
            HttpWebRequest solicitud = (HttpWebRequest)WebRequest.Create(url);
            solicitud.Method = "GET";
            solicitud.ContentType = "text/xml; encoding='utf-8'";
            // Enviar la solicitud, obtener la respuesta con los datos en formato XML
            // y convertir el XML a un objeto de tipo: Stream
            WebResponse response = solicitud.GetResponse();
            Stream stream = response.GetResponseStream();
            // Leer los datos de tipo: Stream con el método ReadXml(), y pasar
            // los datos a un DataSet para vincularlos a un GridView
            DataSet ds = new DataSet();
            ds.ReadXml(stream);
            // Vincular los datos a un GridView
            gvCategories.DataSource = ds.Tables[0];
            gvCategories.DataBind();
        }

        protected void gvCategories_PreRender(object sender, EventArgs e)
        {
            gvCategories.HeaderRow.TableSection = TableRowSection.TableHeader;
        }

        protected void gvCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            HabilitarCampos();
            GridViewRow row = gvCategories.SelectedRow;
            txtId.Text = row.Cells[1].Text;
            txtShort.Text = row.Cells[3].Text;
            txtLong.Text = row.Cells[2].Text;
            DeshabilitarInsertarID();
        }

        private void HabilitarCampos()
        {
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void DeshabilitarInsertarID()
        {
            txtId.ReadOnly = true;
            btnInsertar.Enabled = false;
        }

        private void HabilitarInsertarID()
        {
            txtId.ReadOnly = false;
            btnInsertar.Enabled = true;
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            HabilitarInsertarID();
            BloquearCampos();
            limpiarCampos();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarCategorias();
            HabilitarInsertarID();
            BloquearCampos();
            limpiarCampos();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarCategoria();
            HabilitarInsertarID();
            BloquearCampos();
            limpiarCampos();
        }

        private void ActualizarCategoria()
        {
            if (ValidarCampos())
            {
                Category categoria = new Category();
                categoria.CategoryID = txtId.Text;
                categoria.ShortName = txtShort.Text;
                categoria.LongName = txtLong.Text;
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44325/api/Categories/" + txtId.Text);
                    //metodo post
                    var putTask = client.PutAsJsonAsync<Category>(client.BaseAddress, categoria);
                    putTask.Wait();

                    var result = putTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        lblResult.Text = "Registro Actualizado";
                        
                        CargarCategorias();
                    }
                    else
                    {
                        lblResult.Text = "Ha ocurrido algun error";
                      
                    }
                }
            }
            
        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            InsertarCategoria();
        }


        private bool ValidarCampos() {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                lblResult.Text = "Ingrese el Id de la Categoria";

                return false;
            }
            else
            {
                if (string.IsNullOrEmpty(txtShort.Text))
                {
                    lblResult.Text = "Ingrese el nombrecorto de la categoria";
                 
                    return false;
                }
                else
                {
                    if (string.IsNullOrEmpty(txtLong.Text))
                    
                    {
                        lblResult.Text = "Ingrese el nombrelargo de la categoria";
                    
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                    
                }
            }
        }

        private void InsertarCategoria()
        {
            if (ValidarCampos())
            {
                Category categoria = new Category();
                categoria.CategoryID = txtId.Text;
                categoria.ShortName = txtShort.Text;
                categoria.LongName = txtLong.Text;
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44325/api/Categories/");
                    //metodo post
                    var postTask = client.PostAsJsonAsync<Category>("Categories", categoria);
                    postTask.Wait();
                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        lblResult.Text = "Registro Ingresado";
                        CargarCategorias();
                        limpiarCampos();
                        HabilitarInsertarID();
                    }
                    else
                    {
                        lblResult.Text = "Ha ocurrido un ERROR";
                    }
                }
            }

        }*/
    }

}
